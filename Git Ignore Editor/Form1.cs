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

/// <summary>
/// IMPROVEMENTS:
/// 
/// 1. (NOT WORKING)
/// _TESTING AREA/* and _TESTING AREA/ are two separate things
/// they both can do the same thing, the first one allow the use of ! for files within that folder
/// 2. (MOSTLY WORKING)
/// when listing a file extension is only affects that extension
/// *.me should not include .me2
/// unless there was a wild card(*) after it eg. *.me*
/// 
/// </summary>

namespace Git_Ignore_Editor {

	public partial class Form1 : Form {

		/// <summary>
		/// handles the folder selecting dialog
		/// </summary>
		private FolderSelectDialog m_FolderSelect = new FolderSelectDialog();

		/// <summary>
		/// normal/default font for the TreeView
		/// </summary>
		private Font m_FontNormal;
		/// <summary>
		/// strikeout font for the TreeView
		/// </summary>
		private Font m_FontStrikeOut;

		/// <summary>
		/// current path to current folder
		/// </summary>
		private string m_Dir;
		/// <summary>
		/// how many folders are there between the drive and the current folder
		/// </summary>
		private int m_DirFolderCount = 0;

		/// <summary>
		/// base/state/root of the FileFolderHolder
		/// </summary>
		private FileFolderHolder m_Base;

		/// <summary>
		/// which FileFolderHolder is currently selected
		/// </summary>
		private FileFolderHolder m_Selected = null;

		/// <summary>
		/// list of all the lines in the gitIgnore
		/// (might have to change to list??)
		/// </summary>
		private GitIgnoreLine[] m_GitLines;

		/// <summary>
		/// when removing other selected form ListBox's it calls the SelectedIndexChanges, this is a bool that is run first to prevent that
		/// </summary>
		private bool m_RemoveOtherSelectedListBox = true;

		public Form1() {
			InitializeComponent();
			//ofofd.AcceptFiles = false;
			//ofofd.RootFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

			TreeNode node = treeView1.Nodes.Add("test");
			node.Nodes.Add("test1");
			treeView1.Nodes.Add("test2");
			node.Text = "Example";
			node.Expand();

			Info_FileName.Text = Info_Path.Text = Info_RelPath.Text = "";

			m_FontNormal = new Font(treeView1.Font, FontStyle.Regular);
			m_FontStrikeOut = new Font(treeView1.Font, FontStyle.Strikeout);

			GitIgnore_Contents.Items.Add("Git Ignore File appears here");

		}

		private void button1_Click(object sender, EventArgs e) {
			//folderBrowserDialog1.ShowDialog();
			bool dr = m_FolderSelect.ShowDialog();
			if (dr) {
				m_Base = null;
				treeView1.Nodes.Clear();
				GitIgnore_Contents.Items.Clear();

				m_Dir = m_FolderSelect.FileName;

				m_DirFolderCount = m_Dir.Split('\\').Length;

				label1.Text = m_Dir + "\\";

				string[] gitIgnore;

				try {
					gitIgnore = File.ReadAllLines(m_Dir + "\\.gitignore");
				} catch {
					label1.Text = "Folder does not have .gitignore";
					return;
				}

				m_GitLines = new GitIgnoreLine[gitIgnore.Length];

				for (int i = 0; i < m_GitLines.Length; i++) {
					m_GitLines[i] = new GitIgnoreLine(gitIgnore[i], i);
					GitIgnore_Contents.Items.Add(i.ToString() + ":\t" + m_GitLines[i].m_BaseLine);
					//if (m_GitIgnore[i].Length >= 2) {
					//	if (m_GitIgnore[i][0] == '/') {
					//		m_GitIgnore[i] = m_GitIgnore[i].Remove(0, 1);
					//	}
					//}
				}

				setUpFolderList();

				//addFolders("", null);
				//addFiles("", null);
			}
		}

		private void setUpFolderList() {



			m_Base = new FileFolderHolder();
			m_Base.m_Children = new List<FileFolderHolder>();
			m_Base.m_Path = m_Dir;
			m_Base.m_Filename = "";
			m_Base.m_IsFile = false;

			addFolders(m_Base);
			addFiles(m_Base);

			//check git ignore
			runThroughGit(m_Base);
			//run through strikeout
			updateTreeExclude(m_Base);
		}

		private void addFolders(FileFolderHolder a_Node) {
			string path = a_Node.m_Path + a_Node.m_Filename;
			string[] folders = Directory.GetDirectories(path);

			for (int i = 0; i < folders.Length; i++) {
				string[] folderSlit = folders[i].Split('\\');
				string folderName = folderSlit[folderSlit.Length - 1];

				if (folderName == ".git") {
					continue;
				}

				FileFolderHolder folder = new FileFolderHolder();
				folder.m_Children = new List<FileFolderHolder>();
				folder.m_Path = path + "\\";
				folder.m_Filename = folderName;
				folder.m_IsFile = false;
				folder.m_Parent = a_Node;

				folder.m_RelativePath = "";

				for (int q = m_DirFolderCount; q < folderSlit.Length-1; q++) {
					folder.m_RelativePath += folderSlit[q] + "\\";
				}


				folder.m_Node = addNode(folder.m_Filename, a_Node.m_Node);

				a_Node.m_Children.Add(folder);

				addFolders(folder);
				addFiles(folder);

			}
		}

		private void addFiles(FileFolderHolder a_Node) {
			//parent node is file, files cant have nested files
			if (a_Node.m_IsFile) {
				return;
			}

			string path = a_Node.m_Path + a_Node.m_Filename;
			string[] files = Directory.GetFiles(path);

			for (int i = 0; i < files.Length; i++) {
				string[] folderSlit = files[i].Split('\\');
				string fileName = folderSlit[folderSlit.Length - 1];

				if (fileName == ".gitignore") {
					continue;
				}

				FileFolderHolder file = new FileFolderHolder();
				file.m_Path = path + "\\";
				file.m_Filename = fileName;
				file.m_IsFile = true;
				file.m_Parent = a_Node;

				file.m_RelativePath = "";

				for (int q = m_DirFolderCount; q < folderSlit.Length-1; q++) {
					file.m_RelativePath += folderSlit[q] + "\\";
				}

				file.m_Node = addNode(file.m_Filename, a_Node.m_Node);


				a_Node.m_Children.Add(file);

			}
		}

		private bool isParentExcluded(FileFolderHolder a_Ffh) {
			FileFolderHolder parent = a_Ffh.m_Parent;

			while (parent != null) {
				if (parent.m_IsExcluded) {
					return true;
				}
				parent = parent.m_Parent;
			}

			return false;
		}


		private void runThroughGit(FileFolderHolder a_Ffh) {
			for (int i = 0; i < a_Ffh.m_Children.Count; i++) {
				FileFolderHolder current = a_Ffh.m_Children[i];

				if (isParentExcluded(current)) {
					current.m_IsExcluded = true;
				} else {

					string prefix;
					if (current.m_IsFile) {
						prefix = "";
					} else {
						prefix = "";
					}
					string suffix;
					if (current.m_IsFile) {
						suffix = "";
					} else {
						suffix = "/";
					}
					string dir = prefix + current.m_RelativePath.Replace('\\', '/');

					dir += current.m_Filename + "/";

					if (dir.Length >= 1) {
						dir = dir.Remove(dir.Length - 1);
					}

					dir += suffix;

					//if (!isFileAllowed(dir)) {
					//	current.m_IsExcluded = true;
					//}

					current.m_Effects = new List<GitIgnoreLine>();

					bool allowed = true;
					for (int q = 0; q < m_GitLines.Length; q++) {
						switch (m_GitLines[q].m_Type) {
							case GitIgnoreLine.LineType.Comment:
							case GitIgnoreLine.LineType.Empty:
								break;
							case GitIgnoreLine.LineType.Allow:
							case GitIgnoreLine.LineType.Ignore:
								if (LikeOperator.LikeString(dir, "*" + m_GitLines[q].m_Line, CompareMethod.Binary)) {
									allowed = m_GitLines[q].m_Type != GitIgnoreLine.LineType.Ignore;
									current.m_Effects.Add(m_GitLines[q]);
								}
								break;
						}
					}

					current.m_IsExcluded = !allowed;


				}

				if (!current.m_IsFile) {
					runThroughGit(current);
				}
			}
		}

		/// <summary>
		/// checks if parent objects have been excluded
		/// </summary>
		/// <param name="a_Ffh"></param>
		private void updateTreeExclude(FileFolderHolder a_Ffh) {
			for (int i = 0; i < a_Ffh.m_Children.Count; i++) {
				FileFolderHolder current = a_Ffh.m_Children[i];

				if (current.m_IsExcluded) {
					current.m_Node.NodeFont = m_FontStrikeOut;
				} else {
					current.m_Node.NodeFont = m_FontNormal;
				}

				if (!current.m_IsFile) {
					updateTreeExclude(current);
				}
			}
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
			if (m_Base == null) {
				return;
			}

			m_RemoveOtherSelectedListBox = false;

			GitIgnore_Contents.ClearSelected();
			Info_IgnoreList.ClearSelected();

			m_RemoveOtherSelectedListBox = true;


			m_Selected = getFfhFromNode(e.Node);

			Info_FileName.Text = m_Selected.m_Filename;
			Info_RelPath.Text = m_Selected.m_RelativePath;
			Info_Path.Text = m_Selected.m_Path;
			Info_IsExcluded.Checked = m_Selected.m_IsExcluded;
			Info_IsFile.Checked = m_Selected.m_IsFile;

			Info_IgnoreList.Items.Clear();

			if (m_Selected.m_Effects == null || m_Selected.m_Effects.Count == 0) {
				Info_IgnoreList.Items.Add("Nothing.");
			} else {
				for (int i = 0; i < m_Selected.m_Effects.Count; i++) {
					string text = "";
					GitIgnoreLine gil = m_Selected.m_Effects[i];
					if (gil.m_Type == GitIgnoreLine.LineType.Ignore) {
						text = "Exluded: ";
					} else {
						text = "Included: ";
					}

					text += "L(" + gil.m_LineIndex + "): " + gil.m_BaseLine + "\n";

					Info_IgnoreList.Items.Add(text);
				}
			}
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

			while (current.m_Node != a_Node) {
				index++;
				if (index >= pathSplit.Length) {
					break;
				}
				for (int i = 0; i < current.m_Children.Count; i++) {
					if (pathSplit[index] == current.m_Children[i].m_Filename) {
						current = current.m_Children[i];
						break;
					}
				}


			}

			return current;
		}

		private void Info_IgnoreList_SelectedIndexChanged(object sender, EventArgs e) {
			if (!m_RemoveOtherSelectedListBox || Info_IgnoreList.SelectedIndex == -1) {
				return;
			}
			m_RemoveOtherSelectedListBox = false;

			GitIgnore_Contents.ClearSelected();
			treeView1.SelectedNode = null;

			m_RemoveOtherSelectedListBox = true;

			if (m_Base == null || m_Selected == null) {
				return;
			}


		}

		private void GitIgnore_Contents_SelectedIndexChanged(object sender, EventArgs e) {
			if (!m_RemoveOtherSelectedListBox || GitIgnore_Contents.SelectedIndex == -1) {
				return;
			}
			m_RemoveOtherSelectedListBox = false;

			Info_IgnoreList.ClearSelected();
			treeView1.SelectedNode = null;

			m_RemoveOtherSelectedListBox = true;

			if (m_Base == null) {
				return;
			}


		}
	}
}
