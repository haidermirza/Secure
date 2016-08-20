namespace Secure {
	partial class entryForm {
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
			this.txtEntryName = new System.Windows.Forms.TextBox();
			this.txtEntryEmail = new System.Windows.Forms.TextBox();
			this.txtEntryUsername = new System.Windows.Forms.TextBox();
			this.txtEntryPassword = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtEntryName
			// 
			this.txtEntryName.Location = new System.Drawing.Point(6, 19);
			this.txtEntryName.Name = "txtEntryName";
			this.txtEntryName.Size = new System.Drawing.Size(138, 20);
			this.txtEntryName.TabIndex = 0;
			this.txtEntryName.Text = "ali";
			// 
			// txtEntryEmail
			// 
			this.txtEntryEmail.Location = new System.Drawing.Point(6, 19);
			this.txtEntryEmail.Name = "txtEntryEmail";
			this.txtEntryEmail.Size = new System.Drawing.Size(138, 20);
			this.txtEntryEmail.TabIndex = 1;
			this.txtEntryEmail.Text = "ali@yahoo.com";
			// 
			// txtEntryUsername
			// 
			this.txtEntryUsername.Location = new System.Drawing.Point(6, 19);
			this.txtEntryUsername.Name = "txtEntryUsername";
			this.txtEntryUsername.Size = new System.Drawing.Size(138, 20);
			this.txtEntryUsername.TabIndex = 2;
			this.txtEntryUsername.Text = "alimirza";
			// 
			// txtEntryPassword
			// 
			this.txtEntryPassword.Location = new System.Drawing.Point(7, 19);
			this.txtEntryPassword.Name = "txtEntryPassword";
			this.txtEntryPassword.Size = new System.Drawing.Size(138, 20);
			this.txtEntryPassword.TabIndex = 3;
			this.txtEntryPassword.Text = "password";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtEntryName);
			this.groupBox1.Location = new System.Drawing.Point(12, 26);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(150, 48);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Name";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtEntryEmail);
			this.groupBox2.Location = new System.Drawing.Point(12, 80);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(150, 48);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Email";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtEntryUsername);
			this.groupBox3.Location = new System.Drawing.Point(12, 134);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(150, 48);
			this.groupBox3.TabIndex = 10;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Username";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.txtEntryPassword);
			this.groupBox4.Location = new System.Drawing.Point(12, 188);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(150, 48);
			this.groupBox4.TabIndex = 11;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Password";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(187, 204);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(187, 175);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 13;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// entryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "entryForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add New";
			this.Load += new System.EventHandler(this.entryForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txtEntryName;
		private System.Windows.Forms.TextBox txtEntryEmail;
		private System.Windows.Forms.TextBox txtEntryUsername;
		private System.Windows.Forms.TextBox txtEntryPassword;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
	}
}