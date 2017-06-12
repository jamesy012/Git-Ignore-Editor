using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using FolderSelect;

//for LikeOperator.LikeString
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Git_Ignore_Editor {

	public partial class Form1 : Form {

		private FolderSelectDialog m_FolderSelect = new FolderSelectDialog();

		private string m_Dir;
		private int m_DirFolderCount = 0;

		private class FileFolderHolder {

			public string filename;
			public string relativePath;
			public string path;

			public bool isExcluded;

			public bool isFile;

			public TreeNode node;
			public FileFolderHolder parent;

			public List<FileFolderHolder> children;

		}

		private FileFolderHolder m_Base;

		private Font m_FontStrikeOut;
		private Font m_FontNormal;

		private string[] m_GitIgnore;

		public Form1() {
			InitializeComponent();
			//ofofd.AcceptFiles = false;
			//ofofd.RootFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

			TreeNode node = treeView1.Nodes.Add("test");
			node.Nodes.Add("test1");
			treeView1.Nodes.Add("test2");
			node.Text = "Example";
			node.Expand();

			m_FontNormal = new Font(treeView1.Font, FontStyle.Regular);
			m_FontStrikeOut = new Font(treeView1.Font, FontStyle.Strikeout);
		}

		private void button1_Click(object sender, EventArgs e) {
			//folderBrowserDialog1.ShowDialog();
			bool dr = m_FolderSelect.ShowDialog();
			if (dr) {

				treeView1.Nodes.Clear();
				m_Dir = m_FolderSelect.FileName;

				m_DirFolderCount = m_Dir.Split('\\').Length;

				label1.Text = m_Dir + "\\";

				try {
					m_GitIgnore = File.ReadAllLines(m_Dir + "\\.gitignore");
				} catch {
					label1.Text = "Folder does not have .gitignore";
					return;
				}

				setUpFolderList();

				//addFolders("", null);
				//addFiles("", null);
			}
		}

		private void setUpFolderList() {
			m_Base = new FileFolderHolder();
			m_Base.children = new List<FileFolderHolder>();
			m_Base.path = m_Dir;
			m_Base.filename = "";
			m_Base.isFile = false;

			addFolders(m_Base);
			addFiles(m_Base);

			//check git ignore
			runThroughGit(m_Base);
			//run through strikeout
			updateTreeExclude(m_Base);
		}

		private void addFolders(FileFolderHolder a_Node) {
			string path = a_Node.path + a_Node.filename;
			string[] folders = Directory.GetDirectories(path);

			for (int i = 0; i < folders.Length; i++) {
				string[] folderSlit = folders[i].Split('\\');
				string folderName = folderSlit[folderSlit.Length - 1];

				if (folderName == ".git") {
					continue;
				}

				FileFolderHolder folder = new FileFolderHolder();
				folder.children = new List<FileFolderHolder>();
				folder.path = path + "\\";
				folder.filename = folderName;
				folder.isFile = false;
				folder.parent = a_Node;

				for (int q = m_DirFolderCount; q < folderSlit.Length; q++) {
					folder.relativePath += folderSlit[q] + "\\";
				}

				folder.node = addNode(folder.filename, a_Node.node);

				a_Node.children.Add(folder);

				addFolders(folder);
				addFiles(folder);

			}
		}

		private void addFiles(FileFolderHolder a_Node) {
			//parent node is file, files cant have nested files
			if (a_Node.isFile) {
				return;
			}

			string path = a_Node.path + a_Node.filename;
			string[] files = Directory.GetFiles(path);

			for (int i = 0; i < files.Length; i++) {
				string[] folderSlit = files[i].Split('\\');
				string fileName = folderSlit[folderSlit.Length - 1];

				if (fileName == ".gitignore") {
					continue;
				}

				FileFolderHolder file = new FileFolderHolder();
				file.path = path + "\\";
				file.filename = fileName;
				file.isFile = true;
				file.parent = a_Node;

				for (int q = m_DirFolderCount; q < folderSlit.Length; q++) {
					file.relativePath += folderSlit[q] + "\\";
				}

				file.node = addNode(file.filename, a_Node.node);


				a_Node.children.Add(file);

			}
		}

		private bool isParentExcluded(FileFolderHolder a_Ffh) {
			FileFolderHolder parent = a_Ffh.parent;

			while (parent != null) {
				if (parent.isExcluded) {
					return true;
				}
				parent = parent.parent;
			}

			return false;
		}


		private void runThroughGit(FileFolderHolder a_Ffh) {
			for (int i = 0; i < a_Ffh.children.Count; i++) {
				FileFolderHolder current = a_Ffh.children[i];

				if (isParentExcluded(current)) {
					current.isExcluded = true;
				} else {

					string prefix;
					if (current.isFile) {
						prefix = "";
					} else {
						prefix = "/";
					}
					string dir = prefix + current.relativePath.Replace('\\', '/');

					dir = dir.Remove(dir.Length - 1);

					if (!isFileAllowed(dir)) {
						current.isExcluded = true;
					}
				}

				if (!current.isFile) {
					runThroughGit(current);
				}
			}
		}

		private void updateTreeExclude(FileFolderHolder a_Ffh) {
			for (int i = 0; i < a_Ffh.children.Count; i++) {
				FileFolderHolder current = a_Ffh.children[i];

				if (current.isExcluded) {
					current.node.NodeFont = m_FontStrikeOut;
				} else {
					current.node.NodeFont = m_FontNormal;
				}

				if (!current.isFile) {
					updateTreeExclude(current);
				}
			}
		}

		/// <summary>
		/// checks the git ignore file to see if we should use the file
		/// </summary>
		/// <param name="a_FileDir">text to compare against git ignore text</param>
		/// <returns>is the file allowed to be added</returns>
		private bool isFileAllowed(string a_FileDir) {
			for (int i = 0; i < m_GitIgnore.Length; i++) {
				if(m_GitIgnore[i].Length <= 2) {
					continue;
				}
				if (LikeOperator.LikeString(a_FileDir,"*" + m_GitIgnore[i], CompareMethod.Binary)) {
					return false;
				}
			}
			return true;
		}

		/// <summary>
		/// adds a node to a_Parent,
		/// if a_Parent is null then it will add to treeView1
		/// </summary>
		/// <param name="a_Text">node text</param>
		/// <param name="a_Parent">parent node</param>
		/// <returns>node created</returns>
		private TreeNode addNode(string a_Text, TreeNode a_Parent) {
			if (a_Parent == null) {
				return treeView1.Nodes.Add(a_Text);
			}
			return a_Parent.Nodes.Add(a_Text);
		}

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) {
			if (m_Dir == null) {
				return;
			}
			FileFolderHolder selected = getFfhFromNode(e.Node);

			Info_FileName.Text = selected.filename;
			Info_RelPath.Text = selected.relativePath;
			Info_Path.Text = selected.path;
			Info_IsExcluded.Checked = selected.isExcluded;
			Info_IsFile.Checked = selected.isFile;
		}

		/// <summary>
		/// has the chance to not be right, if the data is not the same
		/// </summary>
		/// <param name="a_Node"></param>
		/// <returns></returns>
		private FileFolderHolder getFfhFromNode(TreeNode a_Node) {
			string[] pathSplit = (a_Node.FullPath).Split('\\');
			int index = -1;
			FileFolderHolder current = m_Base;

			//todo change to use a_Node.Index;

			while (current.node != a_Node) {
				index++;
				if (index >= pathSplit.Length) {
					break;
				}
				for (int i = 0; i < current.children.Count; i++) {
					if (pathSplit[index] == current.children[i].filename) {
						current = current.children[i];
						break;
					}
				}


			}

			return current;
		}
	}
}
