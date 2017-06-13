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
			System.Windows.Forms.Label label4;
			this.TreeViewFolders = new System.Windows.Forms.TreeView();
			this.Button_LoadGitIgnore = new System.Windows.Forms.Button();
			this.Label_CurrPath = new System.Windows.Forms.Label();
			this.Info_FileName = new System.Windows.Forms.Label();
			this.Info_IsFile = new System.Windows.Forms.CheckBox();
			this.Info_Path = new System.Windows.Forms.Label();
			this.Info_RelPath = new System.Windows.Forms.Label();
			this.Info_IsExcluded = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.GitIgnore_Contents = new System.Windows.Forms.ListBox();
			this.Info_IgnoreList = new System.Windows.Forms.ListBox();
			this.ButtonSave = new System.Windows.Forms.Button();
			this.Button_Ignore = new System.Windows.Forms.Button();
			this.Button_Allow = new System.Windows.Forms.Button();
			this.Ignore_RemoveLine = new System.Windows.Forms.Button();
			this.Button_IgnoreAUT = new System.Windows.Forms.Button();
			this.Ignore_MoveUp = new System.Windows.Forms.Button();
			this.Ignore_MoveDown = new System.Windows.Forms.Button();
			this.ButtonReload = new System.Windows.Forms.Button();
			this.Button_AllowAUT = new System.Windows.Forms.Button();
			this.Ignore_EditLine = new System.Windows.Forms.Button();
			label3 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			label6 = new System.Windows.Forms.Label();
			label7 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
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
			// label4
			// 
			label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(760, 499);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(112, 13);
			label4.TabIndex = 14;
			label4.Text = "Made by James Owen";
			// 
			// TreeViewFolders
			// 
			this.TreeViewFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.TreeViewFolders.Location = new System.Drawing.Point(12, 42);
			this.TreeViewFolders.Name = "TreeViewFolders";
			this.TreeViewFolders.Size = new System.Drawing.Size(211, 459);
			this.TreeViewFolders.TabIndex = 0;
			this.TreeViewFolders.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewFolders_AfterSelect);
			// 
			// Button_LoadGitIgnore
			// 
			this.Button_LoadGitIgnore.Location = new System.Drawing.Point(13, 13);
			this.Button_LoadGitIgnore.Name = "Button_LoadGitIgnore";
			this.Button_LoadGitIgnore.Size = new System.Drawing.Size(210, 23);
			this.Button_LoadGitIgnore.TabIndex = 1;
			this.Button_LoadGitIgnore.Text = "Load Git Ignore";
			this.Button_LoadGitIgnore.UseVisualStyleBackColor = true;
			this.Button_LoadGitIgnore.Click += new System.EventHandler(this.Button_LoadGitIgnore_Click);
			// 
			// Label_CurrPath
			// 
			this.Label_CurrPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Label_CurrPath.AutoSize = true;
			this.Label_CurrPath.Location = new System.Drawing.Point(9, 504);
			this.Label_CurrPath.Name = "Label_CurrPath";
			this.Label_CurrPath.Size = new System.Drawing.Size(69, 13);
			this.Label_CurrPath.TabIndex = 2;
			this.Label_CurrPath.Text = "Current Path:";
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
			this.Info_IsFile.Location = new System.Drawing.Point(230, 165);
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
			this.Info_IsExcluded.Location = new System.Drawing.Point(375, 165);
			this.Info_IsExcluded.Name = "Info_IsExcluded";
			this.Info_IsExcluded.Size = new System.Drawing.Size(81, 17);
			this.Info_IsExcluded.TabIndex = 7;
			this.Info_IsExcluded.Text = "Is Excluded";
			this.Info_IsExcluded.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(230, 195);
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
			this.GitIgnore_Contents.Size = new System.Drawing.Size(316, 472);
			this.GitIgnore_Contents.TabIndex = 9;
			this.GitIgnore_Contents.SelectedIndexChanged += new System.EventHandler(this.GitIgnore_Contents_SelectedIndexChanged);
			// 
			// Info_IgnoreList
			// 
			this.Info_IgnoreList.FormattingEnabled = true;
			this.Info_IgnoreList.HorizontalScrollbar = true;
			this.Info_IgnoreList.Location = new System.Drawing.Point(230, 215);
			this.Info_IgnoreList.Name = "Info_IgnoreList";
			this.Info_IgnoreList.Size = new System.Drawing.Size(318, 134);
			this.Info_IgnoreList.TabIndex = 12;
			this.Info_IgnoreList.SelectedIndexChanged += new System.EventHandler(this.Info_IgnoreList_SelectedIndexChanged);
			// 
			// ButtonSave
			// 
			this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonSave.Location = new System.Drawing.Point(556, 494);
			this.ButtonSave.Name = "ButtonSave";
			this.ButtonSave.Size = new System.Drawing.Size(198, 23);
			this.ButtonSave.TabIndex = 13;
			this.ButtonSave.Text = "Save";
			this.ButtonSave.UseVisualStyleBackColor = true;
			// 
			// Button_Ignore
			// 
			this.Button_Ignore.Location = new System.Drawing.Point(230, 355);
			this.Button_Ignore.Name = "Button_Ignore";
			this.Button_Ignore.Size = new System.Drawing.Size(125, 23);
			this.Button_Ignore.TabIndex = 18;
			this.Button_Ignore.Text = "Ignore";
			this.Button_Ignore.UseVisualStyleBackColor = true;
			// 
			// Button_Allow
			// 
			this.Button_Allow.Location = new System.Drawing.Point(230, 415);
			this.Button_Allow.Name = "Button_Allow";
			this.Button_Allow.Size = new System.Drawing.Size(125, 23);
			this.Button_Allow.TabIndex = 19;
			this.Button_Allow.Text = "Allow";
			this.Button_Allow.UseVisualStyleBackColor = true;
			// 
			// Ignore_RemoveLine
			// 
			this.Ignore_RemoveLine.Location = new System.Drawing.Point(408, 355);
			this.Ignore_RemoveLine.Name = "Ignore_RemoveLine";
			this.Ignore_RemoveLine.Size = new System.Drawing.Size(140, 23);
			this.Ignore_RemoveLine.TabIndex = 20;
			this.Ignore_RemoveLine.Text = "Remove Line";
			this.Ignore_RemoveLine.UseVisualStyleBackColor = true;
			this.Ignore_RemoveLine.Click += new System.EventHandler(this.Ignore_RemoveLine_Click);
			// 
			// Button_IgnoreAUT
			// 
			this.Button_IgnoreAUT.Location = new System.Drawing.Point(230, 385);
			this.Button_IgnoreAUT.Name = "Button_IgnoreAUT";
			this.Button_IgnoreAUT.Size = new System.Drawing.Size(125, 23);
			this.Button_IgnoreAUT.TabIndex = 21;
			this.Button_IgnoreAUT.Text = "Ignore all under this";
			this.Button_IgnoreAUT.UseVisualStyleBackColor = true;
			// 
			// Ignore_MoveUp
			// 
			this.Ignore_MoveUp.Location = new System.Drawing.Point(408, 385);
			this.Ignore_MoveUp.Name = "Ignore_MoveUp";
			this.Ignore_MoveUp.Size = new System.Drawing.Size(140, 23);
			this.Ignore_MoveUp.TabIndex = 22;
			this.Ignore_MoveUp.Text = "Move Up";
			this.Ignore_MoveUp.UseVisualStyleBackColor = true;
			this.Ignore_MoveUp.Click += new System.EventHandler(this.Ignore_MoveUp_Click);
			// 
			// Ignore_MoveDown
			// 
			this.Ignore_MoveDown.Location = new System.Drawing.Point(408, 415);
			this.Ignore_MoveDown.Name = "Ignore_MoveDown";
			this.Ignore_MoveDown.Size = new System.Drawing.Size(140, 23);
			this.Ignore_MoveDown.TabIndex = 23;
			this.Ignore_MoveDown.Text = "Move Down";
			this.Ignore_MoveDown.UseVisualStyleBackColor = true;
			this.Ignore_MoveDown.Click += new System.EventHandler(this.Ignore_MoveDown_Click);
			// 
			// ButtonReload
			// 
			this.ButtonReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ButtonReload.Location = new System.Drawing.Point(408, 494);
			this.ButtonReload.Name = "ButtonReload";
			this.ButtonReload.Size = new System.Drawing.Size(140, 23);
			this.ButtonReload.TabIndex = 24;
			this.ButtonReload.Text = "Reload File";
			this.ButtonReload.UseVisualStyleBackColor = true;
			this.ButtonReload.Click += new System.EventHandler(this.ButtonReload_Click);
			// 
			// Button_AllowAUT
			// 
			this.Button_AllowAUT.Location = new System.Drawing.Point(230, 445);
			this.Button_AllowAUT.Name = "Button_AllowAUT";
			this.Button_AllowAUT.Size = new System.Drawing.Size(125, 23);
			this.Button_AllowAUT.TabIndex = 25;
			this.Button_AllowAUT.Text = "Allow all under this";
			this.Button_AllowAUT.UseVisualStyleBackColor = true;
			// 
			// Ignore_EditLine
			// 
			this.Ignore_EditLine.Location = new System.Drawing.Point(408, 445);
			this.Ignore_EditLine.Name = "Ignore_EditLine";
			this.Ignore_EditLine.Size = new System.Drawing.Size(140, 23);
			this.Ignore_EditLine.TabIndex = 26;
			this.Ignore_EditLine.Text = "Edit Line";
			this.Ignore_EditLine.UseVisualStyleBackColor = true;
			this.Ignore_EditLine.Click += new System.EventHandler(this.Ignore_EditLine_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 526);
			this.Controls.Add(this.Ignore_EditLine);
			this.Controls.Add(this.Button_AllowAUT);
			this.Controls.Add(this.ButtonReload);
			this.Controls.Add(this.Ignore_MoveDown);
			this.Controls.Add(this.Ignore_MoveUp);
			this.Controls.Add(this.Button_IgnoreAUT);
			this.Controls.Add(this.Ignore_RemoveLine);
			this.Controls.Add(this.Button_Allow);
			this.Controls.Add(this.Button_Ignore);
			this.Controls.Add(label5);
			this.Controls.Add(label6);
			this.Controls.Add(label7);
			this.Controls.Add(label4);
			this.Controls.Add(this.ButtonSave);
			this.Controls.Add(this.Info_IgnoreList);
			this.Controls.Add(label3);
			this.Controls.Add(this.GitIgnore_Contents);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Info_IsExcluded);
			this.Controls.Add(this.Info_RelPath);
			this.Controls.Add(this.Info_Path);
			this.Controls.Add(this.Info_IsFile);
			this.Controls.Add(this.Info_FileName);
			this.Controls.Add(this.Label_CurrPath);
			this.Controls.Add(this.Button_LoadGitIgnore);
			this.Controls.Add(this.TreeViewFolders);
			this.MinimumSize = new System.Drawing.Size(900, 550);
			this.Name = "Form1";
			this.Text = "Git Ignore Editor";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView TreeViewFolders;
		private System.Windows.Forms.Button Button_LoadGitIgnore;
		private System.Windows.Forms.Label Label_CurrPath;
		private System.Windows.Forms.Label Info_FileName;
		private System.Windows.Forms.Label Info_Path;
		private System.Windows.Forms.Label Info_RelPath;
		private System.Windows.Forms.CheckBox Info_IsExcluded;
		private System.Windows.Forms.CheckBox Info_IsFile;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox GitIgnore_Contents;
		private System.Windows.Forms.ListBox Info_IgnoreList;
		private System.Windows.Forms.Button ButtonSave;
		private System.Windows.Forms.Button Button_Ignore;
		private System.Windows.Forms.Button Button_Allow;
		private System.Windows.Forms.Button Ignore_RemoveLine;
		private System.Windows.Forms.Button Button_IgnoreAUT;
		private System.Windows.Forms.Button Ignore_MoveUp;
		private System.Windows.Forms.Button Ignore_MoveDown;
		private System.Windows.Forms.Button ButtonReload;
		private System.Windows.Forms.Button Button_AllowAUT;
		private System.Windows.Forms.Button Ignore_EditLine;
	}
}

