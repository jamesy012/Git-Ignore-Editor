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

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Git_Ignore_Editor {

	public partial class Form1 : Form {

		private FolderSelectDialog m_FolderSelect = new FolderSelectDialog();

		private string m_Dir;

		private struct FileFolderHolder {
			public string filename;
			public string path;

			public bool isExcluded;

			public bool isFile;

			public TreeNode node;
		}

		private string[] m_GitIgnore;

		public Form1() {
			InitializeComponent();
			//ofofd.AcceptFiles = false;
			//ofofd.RootFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

			TreeNode node = treeView1.Nodes.Add("test");
			node.Nodes.Add("test1");
			treeView1.Nodes.Add("test2");
			node.Expand();
		}

		private void button1_Click(object sender, EventArgs e) {
			//folderBrowserDialog1.ShowDialog();
			bool dr = m_FolderSelect.ShowDialog();
			if(dr) {
				treeView1.Nodes.Clear();
				m_Dir = m_FolderSelect.FileName;
				label1.Text = m_Dir + "\\";

				m_GitIgnore = File.ReadAllLines(m_Dir + "\\.gitignore");



				addFolders("", null);
				addFiles("", null);
			}
		}


		private void addFolders(string a_Suffix,TreeNode a_Node) {
			string dir = m_Dir + a_Suffix;

			string[] folders = Directory.GetDirectories(dir);

			for (int i = 0; i < folders.Length; i++) {
				string[] folderSlit = folders[i].Split('\\');
				string folderName = folderSlit[folderSlit.Length - 1];

				if(LikeOperator.LikeString(folders[i], "*.git", CompareMethod.Binary)) {
					continue;
				}
				if (!isFileAllowed(a_Suffix + "/" + folderName + "/")) {
					continue;
				}

				TreeNode node;
				if (a_Node == null) {
					node = treeView1.Nodes.Add(folderName + "\\");
				} else {
					node = a_Node.Nodes.Add(folderName + "\\");
				}
				string nextSuffix = a_Suffix + "\\" + folderName;
				addFolders(nextSuffix, node);
				addFiles(nextSuffix, node);
			}
		}

		private void addFiles(string a_Suffix, TreeNode a_Node) {
			string dir = m_Dir + a_Suffix;

			string[] folders = Directory.GetFiles(dir);

			for (int i = 0; i < folders.Length; i++) {
				string[] folderSlit = folders[i].Split('\\');
				string folderName = folderSlit[folderSlit.Length - 1];

				if (LikeOperator.LikeString(folders[i], "*.gitignore", CompareMethod.Binary)) {
					continue;
				}
				if (!isFileAllowed(folders[i])) {
					continue;
				}

				if (a_Node == null) {
					treeView1.Nodes.Add(folderName);
				} else {
					a_Node.Nodes.Add(folderName);
				}
			}
		}


		private bool isFileAllowed(string a_FileDir) { 
			for(int i = 0; i < m_GitIgnore.Length; i++) {
				if (LikeOperator.LikeString(a_FileDir, m_GitIgnore[i] , CompareMethod.Binary)) {
					return false;
				}
			}
			return true;
		}

	}
}
