namespace Git_Ignore_Editor {
	partial class GitLineEditForm {
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
			this.Button_Cancel = new System.Windows.Forms.Button();
			this.Button_Accept = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// Button_Cancel
			// 
			this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button_Cancel.Location = new System.Drawing.Point(12, 39);
			this.Button_Cancel.Name = "Button_Cancel";
			this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
			this.Button_Cancel.TabIndex = 0;
			this.Button_Cancel.Text = "Cancel";
			this.Button_Cancel.UseVisualStyleBackColor = true;
			// 
			// Button_Accept
			// 
			this.Button_Accept.Location = new System.Drawing.Point(257, 39);
			this.Button_Accept.Name = "Button_Accept";
			this.Button_Accept.Size = new System.Drawing.Size(75, 23);
			this.Button_Accept.TabIndex = 1;
			this.Button_Accept.Text = "Accept";
			this.Button_Accept.UseVisualStyleBackColor = true;
			this.Button_Accept.Click += new System.EventHandler(this.Button_Accept_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(13, 13);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(319, 20);
			this.textBox1.TabIndex = 2;
			// 
			// GitLineEditForm
			// 
			this.AcceptButton = this.Button_Accept;
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Button_Cancel;
			this.ClientSize = new System.Drawing.Size(344, 72);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.Button_Accept);
			this.Controls.Add(this.Button_Cancel);
			this.Name = "GitLineEditForm";
			this.Text = "GitLineEditForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Button_Cancel;
		private System.Windows.Forms.Button Button_Accept;
		private System.Windows.Forms.TextBox textBox1;
	}
}