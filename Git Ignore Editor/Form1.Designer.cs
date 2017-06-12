namespace Git_Ignore_Editor {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.button1 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.label1 = new System.Windows.Forms.Label();
			this.Info_FileName = new System.Windows.Forms.Label();
			this.Info_IsFile = new System.Windows.Forms.CheckBox();
			this.Info_Path = new System.Windows.Forms.Label();
			this.Info_RelPath = new System.Windows.Forms.Label();
			this.Info_IsExcluded = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(12, 42);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(211, 363);
			this.treeView1.TabIndex = 0;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(13, 13);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 408);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "label1";
			// 
			// Info_FileName
			// 
			this.Info_FileName.AutoSize = true;
			this.Info_FileName.Location = new System.Drawing.Point(260, 42);
			this.Info_FileName.Name = "Info_FileName";
			this.Info_FileName.Size = new System.Drawing.Size(54, 13);
			this.Info_FileName.TabIndex = 3;
			this.Info_FileName.Text = "File Name";
			// 
			// Info_IsFile
			// 
			this.Info_IsFile.AutoSize = true;
			this.Info_IsFile.Enabled = false;
			this.Info_IsFile.Location = new System.Drawing.Point(263, 103);
			this.Info_IsFile.Name = "Info_IsFile";
			this.Info_IsFile.Size = new System.Drawing.Size(53, 17);
			this.Info_IsFile.TabIndex = 4;
			this.Info_IsFile.Text = "Is File";
			this.Info_IsFile.UseVisualStyleBackColor = true;
			// 
			// Info_Path
			// 
			this.Info_Path.AutoSize = true;
			this.Info_Path.Location = new System.Drawing.Point(260, 55);
			this.Info_Path.Name = "Info_Path";
			this.Info_Path.Size = new System.Drawing.Size(29, 13);
			this.Info_Path.TabIndex = 5;
			this.Info_Path.Text = "Path";
			// 
			// Info_RelPath
			// 
			this.Info_RelPath.AutoSize = true;
			this.Info_RelPath.Location = new System.Drawing.Point(260, 68);
			this.Info_RelPath.Name = "Info_RelPath";
			this.Info_RelPath.Size = new System.Drawing.Size(48, 13);
			this.Info_RelPath.TabIndex = 6;
			this.Info_RelPath.Text = "Rel Path";
			// 
			// Info_IsExcluded
			// 
			this.Info_IsExcluded.AutoSize = true;
			this.Info_IsExcluded.Enabled = false;
			this.Info_IsExcluded.Location = new System.Drawing.Point(263, 126);
			this.Info_IsExcluded.Name = "Info_IsExcluded";
			this.Info_IsExcluded.Size = new System.Drawing.Size(81, 17);
			this.Info_IsExcluded.TabIndex = 7;
			this.Info_IsExcluded.Text = "Is Excluded";
			this.Info_IsExcluded.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(687, 430);
			this.Controls.Add(this.Info_IsExcluded);
			this.Controls.Add(this.Info_RelPath);
			this.Controls.Add(this.Info_Path);
			this.Controls.Add(this.Info_IsFile);
			this.Controls.Add(this.Info_FileName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.treeView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Info_FileName;
		private System.Windows.Forms.Label Info_Path;
		private System.Windows.Forms.Label Info_RelPath;
		private System.Windows.Forms.CheckBox Info_IsExcluded;
		private System.Windows.Forms.CheckBox Info_IsFile;
	}
}

