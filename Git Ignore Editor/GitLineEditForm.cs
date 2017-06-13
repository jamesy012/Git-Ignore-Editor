using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Git_Ignore_Editor {
	public partial class GitLineEditForm : Form {

		private Form1 m_MainForm = null;

		private int m_LineIndex = -1;

		private bool m_ClosedByButton = false;

		public GitLineEditForm(Form1 a_Form) {
			m_MainForm = a_Form;
			InitializeComponent();
		}

		public string openForm(string a_String,int a_Index) {
			m_LineIndex = a_Index;
			textBox1.Text = a_String;
			m_ClosedByButton = false;

			DialogResult dr = ShowDialog();

			if(dr == DialogResult.OK || m_ClosedByButton) {
				return textBox1.Text;
			}

			return "";
		}

		private void Button_Accept_Click(object sender, EventArgs e) {
			m_ClosedByButton = true;
			Close();
		}
	}
}
