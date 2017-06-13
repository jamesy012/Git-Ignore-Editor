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
			System.Windows.Forms.Label label3;
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Info_FileName = new System.Windows.Forms.Label();
			this.Info_IsFile = new System.Windows.Forms.CheckBox();
			this.Info_Path = new System.Windows.Forms.Label();
			this.Info_RelPath = new System.Windows.Forms.Label();
			this.Info_IsExcluded = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.treeView1.Location = new System.Drawing.Point(12, 42);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(211, 443);
			this.treeView1.TabIndex = 0;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(13, 13);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(210, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Load Git Ignore";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 488);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Current Location";
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(260, 166);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(179, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "What happens in gitIgnore to this file";
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.HorizontalScrollbar = true;
			this.listBox1.Location = new System.Drawing.Point(556, 13);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(387, 472);
			this.listBox1.TabIndex = 9;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(260, 13);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(106, 13);
			label3.TabIndex = 10;
			label3.Text = "Selected File Details:\r\n";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(955, 510);
			this.Controls.Add(label3);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Info_IsExcluded);
			this.Controls.Add(this.Info_RelPath);
			this.Controls.Add(this.Info_Path);
			this.Controls.Add(this.Info_IsFile);
			this.Controls.Add(this.Info_FileName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.treeView1);
			this.MinimumSize = new System.Drawing.Size(900, 500);
			this.Name = "Form1";
			this.Text = "Git Ignore Editor";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Info_FileName;
		private System.Windows.Forms.Label Info_Path;
		private System.Windows.Forms.Label Info_RelPath;
		private System.Windows.Forms.CheckBox Info_IsExcluded;
		private System.Windows.Forms.CheckBox Info_IsFile;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox listBox1;
	}
}

