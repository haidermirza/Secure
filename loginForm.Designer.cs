namespace Secure {
	partial class loginForm {
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
			this.btnLogin = new System.Windows.Forms.Button();
			this.txtLoginUsername = new System.Windows.Forms.TextBox();
			this.txtLoginPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(122, 81);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(75, 23);
			this.btnLogin.TabIndex = 0;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// txtLoginUsername
			// 
			this.txtLoginUsername.Location = new System.Drawing.Point(97, 29);
			this.txtLoginUsername.Name = "txtLoginUsername";
			this.txtLoginUsername.Size = new System.Drawing.Size(100, 20);
			this.txtLoginUsername.TabIndex = 1;
			this.txtLoginUsername.Text = "haider";
			// 
			// txtLoginPassword
			// 
			this.txtLoginPassword.Location = new System.Drawing.Point(97, 55);
			this.txtLoginPassword.Name = "txtLoginPassword";
			this.txtLoginPassword.PasswordChar = '+';
			this.txtLoginPassword.Size = new System.Drawing.Size(100, 20);
			this.txtLoginPassword.TabIndex = 2;
			this.txtLoginPassword.Text = "abc";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Username:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(31, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Password:";
			// 
			// loginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(274, 131);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtLoginPassword);
			this.Controls.Add(this.txtLoginUsername);
			this.Controls.Add(this.btnLogin);
			this.MaximumSize = new System.Drawing.Size(290, 170);
			this.MinimumSize = new System.Drawing.Size(290, 170);
			this.Name = "loginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Secure - Login Page";
			this.Load += new System.EventHandler(this.loginForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.TextBox txtLoginUsername;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
    public System.Windows.Forms.TextBox txtLoginPassword;
  }
}

