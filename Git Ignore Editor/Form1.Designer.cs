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
			System.Windows.Forms.Label label5;
			System.Windows.Forms.Label label6;
			System.Windows.Forms.Label label7;
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Info_FileName = new System.Windows.Forms.Label();
			this.Info_IsFile = new System.Windows.Forms.CheckBox();
			this.Info_Path = new System.Windows.Forms.Label();
			this.Info_RelPath = new System.Windows.Forms.Label();
			this.Info_IsExcluded = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.GitIgnore_Contents = new System.Windows.Forms.ListBox();
			this.Info_IgnoreList = new System.Windows.Forms.ListBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			label3 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			label6 = new System.Windows.Forms.Label();
			label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(230, 13);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(106, 13);
			label3.TabIndex = 10;
			label3.Text = "Selected File Details:\r\n";
			// 
			// treeView1
			// 
			this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.treeView1.Location = new System.Drawing.Point(12, 42);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(211, 444);
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
			this.label1.Location = new System.Drawing.Point(9, 489);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Current Location";
			// 
			// Info_FileName
			// 
			this.Info_FileName.AutoSize = true;
			this.Info_FileName.Location = new System.Drawing.Point(230, 60);
			this.Info_FileName.Name = "Info_FileName";
			this.Info_FileName.Size = new System.Drawing.Size(122, 13);
			this.Info_FileName.TabIndex = 3;
			this.Info_FileName.Text = "File Name Text Location";
			// 
			// Info_IsFile
			// 
			this.Info_IsFile.AutoSize = true;
			this.Info_IsFile.Enabled = false;
			this.Info_IsFile.Location = new System.Drawing.Point(233, 170);
			this.Info_IsFile.Name = "Info_IsFile";
			this.Info_IsFile.Size = new System.Drawing.Size(53, 17);
			this.Info_IsFile.TabIndex = 4;
			this.Info_IsFile.Text = "Is File";
			this.Info_IsFile.UseVisualStyleBackColor = true;
			// 
			// Info_Path
			// 
			this.Info_Path.AutoSize = true;
			this.Info_Path.Location = new System.Drawing.Point(230, 100);
			this.Info_Path.Name = "Info_Path";
			this.Info_Path.Size = new System.Drawing.Size(100, 13);
			this.Info_Path.TabIndex = 5;
			this.Info_Path.Text = "Path  Text Location";
			// 
			// Info_RelPath
			// 
			this.Info_RelPath.AutoSize = true;
			this.Info_RelPath.Location = new System.Drawing.Point(230, 140);
			this.Info_RelPath.Name = "Info_RelPath";
			this.Info_RelPath.Size = new System.Drawing.Size(119, 13);
			this.Info_RelPath.TabIndex = 6;
			this.Info_RelPath.Text = "Rel Path  Text Location";
			// 
			// Info_IsExcluded
			// 
			this.Info_IsExcluded.AutoSize = true;
			this.Info_IsExcluded.Enabled = false;
			this.Info_IsExcluded.Location = new System.Drawing.Point(233, 190);
			this.Info_IsExcluded.Name = "Info_IsExcluded";
			this.Info_IsExcluded.Size = new System.Drawing.Size(81, 17);
			this.Info_IsExcluded.TabIndex = 7;
			this.Info_IsExcluded.Text = "Is Excluded";
			this.Info_IsExcluded.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(230, 220);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(202, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "What happens to this file in the GitIgnore:";
			// 
			// GitIgnore_Contents
			// 
			this.GitIgnore_Contents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GitIgnore_Contents.FormattingEnabled = true;
			this.GitIgnore_Contents.HorizontalScrollbar = true;
			this.GitIgnore_Contents.Location = new System.Drawing.Point(556, 12);
			this.GitIgnore_Contents.Name = "GitIgnore_Contents";
			this.GitIgnore_Contents.Size = new System.Drawing.Size(316, 459);
			this.GitIgnore_Contents.TabIndex = 9;
			this.GitIgnore_Contents.SelectedIndexChanged += new System.EventHandler(this.GitIgnore_Contents_SelectedIndexChanged);
			// 
			// Info_IgnoreList
			// 
			this.Info_IgnoreList.FormattingEnabled = true;
			this.Info_IgnoreList.HorizontalScrollbar = true;
			this.Info_IgnoreList.Location = new System.Drawing.Point(230, 240);
			this.Info_IgnoreList.Name = "Info_IgnoreList";
			this.Info_IgnoreList.Size = new System.Drawing.Size(318, 134);
			this.Info_IgnoreList.TabIndex = 12;
			this.Info_IgnoreList.SelectedIndexChanged += new System.EventHandler(this.Info_IgnoreList_SelectedIndexChanged);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Location = new System.Drawing.Point(556, 479);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(198, 23);
			this.button2.TabIndex = 13;
			this.button2.Text = "Save";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(760, 484);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 13);
			this.label4.TabIndex = 14;
			this.label4.Text = "Made by James Owen";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(230, 120);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(51, 13);
			label5.TabIndex = 17;
			label5.Text = "Rel Path:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(230, 80);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(32, 13);
			label6.TabIndex = 16;
			label6.Text = "Path:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new System.Drawing.Point(230, 40);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(57, 13);
			label7.TabIndex = 15;
			label7.Text = "File Name:";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(230, 380);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(125, 23);
			this.button3.TabIndex = 18;
			this.button3.Text = "Ignore";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(230, 440);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(125, 23);
			this.button4.TabIndex = 19;
			this.button4.Text = "Allow";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(408, 380);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(140, 23);
			this.button5.TabIndex = 20;
			this.button5.Text = "Remove Line";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(230, 410);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(125, 23);
			this.button6.TabIndex = 21;
			this.button6.Text = "Ignore all under this";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(408, 410);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(140, 23);
			this.button7.TabIndex = 22;
			this.button7.Text = "Move Up";
			this.button7.UseVisualStyleBackColor = true;
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(408, 440);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(140, 23);
			this.button8.TabIndex = 23;
			this.button8.Text = "Move Down";
			this.button8.UseVisualStyleBackColor = true;
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(408, 479);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(140, 23);
			this.button9.TabIndex = 24;
			this.button9.Text = "Reload File";
			this.button9.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 511);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(label5);
			this.Controls.Add(label6);
			this.Controls.Add(label7);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.Info_IgnoreList);
			this.Controls.Add(label3);
			this.Controls.Add(this.GitIgnore_Contents);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Info_IsExcluded);
			this.Controls.Add(this.Info_RelPath);
			this.Controls.Add(this.Info_Path);
			this.Controls.Add(this.Info_IsFile);
			this.Controls.Add(this.Info_FileName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.treeView1);
			this.MinimumSize = new System.Drawing.Size(900, 550);
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
		private System.Windows.Forms.ListBox GitIgnore_Contents;
		private System.Windows.Forms.ListBox Info_IgnoreList;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
	}
}

