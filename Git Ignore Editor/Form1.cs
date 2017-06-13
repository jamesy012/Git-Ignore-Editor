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

			public string m_Filename;
			public string m_RelativePath;
			public string m_Path;

			public bool m_IsExcluded;

			public bool m_IsFile;

			public TreeNode m_Node;
			public FileFolderHolder m_Parent;

			public List<FileFolderHolder> m_Children;

			public List<GitIgnoreLine> m_Effects;

		}

		/// <summary>
		/// this class holds information about each line in the .gitignore
		/// </summary>
		private class GitIgnoreLine {

			public GitIgnoreLine(string a_Base, int a_Line) {
				m_LineInex = a_Line;
				m_BaseLine = a_Base;
				m_Line = a_Base.Replace('\\', '/');

				bool startsWithHash = false;
				bool onlySpaces = true;
				bool startsWithAllow = false;//starts with !

				//char lastChar = ' ';

				char currentChar = ' ';
				for (int i = 0; i < m_Line.Length; i++) {
					currentChar = m_Line[i];

					if (currentChar == '\n') {
						break;
					}

					//if there has only been spaces since the start
					if (onlySpaces) {
						if (currentChar == '!') {
							m_Line = m_Line.Remove(0, i + 1);
							startsWithAllow = true;
							break;
						}

						if (currentChar == '#') {
							startsWithHash = true;
							break;
						}

						if (currentChar == '/') {
							m_Line = m_Line.Remove(0, i + 1);
							break;
						}
					}

					if (onlySpaces) {
						if (currentChar != ' ') {
							onlySpaces = false;
							break;
						}
					}

				}

				if (currentChar != ' ') {
					onlySpaces = false;
				}

				if (onlySpaces) {
					m_Type = LineType.Empty;
				} else if (startsWithHash) {
					m_Type = LineType.Comment;
				} else if (startsWithAllow) {
					m_Type = LineType.Allow;
				} else {
					m_Type = LineType.Ignore;
				}

				//if (a_Base[0] == '/') {
				//	m_Path = a_Base.Remove(0, 1);
				//}

			}

			/// <summary>
			/// the line as it appears in the .gitignore
			/// </summary>
			public string m_BaseLine;
			/// <summary>
			/// modified version of the baseLine, removes some information
			/// </summary>
			public string m_Line;

			public int m_LineInex = 0;

			public enum LineType {
				Ignore,
				Allow,
				Comment,
				Empty
			}

			public LineType m_Type;
		}

		private FileFolderHolder m_Base;

		private Font m_FontStrikeOut;
		private Font m_FontNormal;

		
		private GitIgnoreLine[] m_GitLines;

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

			listBox1.Items.Add("Git Ignore File appears here");

		}

		private void button1_Click(object sender, EventArgs e) {
			//folderBrowserDialog1.ShowDialog();
			bool dr = m_FolderSelect.ShowDialog();
			if (dr) {

				treeView1.Nodes.Clear();
				listBox1.Items.Clear();

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
					listBox1.Items.Add(i.ToString() + ":\t" + m_GitLines[i].m_BaseLine);
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

				for (int q = m_DirFolderCount; q < folderSlit.Length; q++) {
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

				for (int q = m_DirFolderCount; q < folderSlit.Length; q++) {
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

					dir = dir.Remove(dir.Length - 1);

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
								if (LikeOperator.LikeString(dir, "*" + m_GitLines[q].m_Line + "*", CompareMethod.Binary)) {
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

		///// <summary>
		///// checks the git ignore file to see if we should use the file
		///// </summary>
		///// <param name="a_FileDir">text to compare against git ignore text</param>
		///// <returns>is the file allowed to be added</returns>
		//private bool isFileAllowed(string a_FileDir) {
		//	bool allowed = true;
		//	for (int i = 0; i < m_GitLines.Length; i++) {
		//		switch (m_GitLines[i].m_Type) {
		//			case GitIgnoreLine.LineType.Comment:
		//			case GitIgnoreLine.LineType.Empty:
		//				break;
		//			case GitIgnoreLine.LineType.Allow:
		//			case GitIgnoreLine.LineType.Ignore:
		//				if (LikeOperator.LikeString(a_FileDir, "*" + m_GitIgnore[i] + "*", CompareMethod.Binary)) {
		//					allowed = m_GitLines[i].m_Type != GitIgnoreLine.LineType.Ignore;
		//				}
		//				break;
		//		}
		//	}
		//	return allowed;
		//}

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

			Info_FileName.Text = selected.m_Filename;
			Info_RelPath.Text = selected.m_RelativePath;
			Info_Path.Text = selected.m_Path;
			Info_IsExcluded.Checked = selected.m_IsExcluded;
			Info_IsFile.Checked = selected.m_IsFile;

			label2.Text = "";

			if (selected.m_Effects.Count == 0) {
				label2.Text = "Nothing.";
			} else {
				for (int i = 0; i < selected.m_Effects.Count; i++) {
					GitIgnoreLine gil = selected.m_Effects[i];
					if (gil.m_Type == GitIgnoreLine.LineType.Ignore) {
						label2.Text += "Exluded: ";
					} else {
						label2.Text += "Included: ";
					}

					label2.Text += "L(" + gil.m_LineInex + "): " + gil.m_BaseLine + "\n";
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
	}
}
