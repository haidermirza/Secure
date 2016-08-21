using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secure {

	public partial class loginForm : Form {

		public loginForm() {
			InitializeComponent();
		}

		public void btnLogin_Click(object sender, EventArgs e) {

			String loginUsername = txtLoginPassword.Text;
			String loginPassword = txtLoginUsername.Text;

			if (loginUsername == "" || loginPassword == "") {
				MessageBox.Show("Fields cannot be left blank!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			else { 
				
				this.Hide();
				mainForm form = new mainForm();
				form.Show();
			}
		}

		private void loginForm_Load(object sender, EventArgs e)
		{

		}

	}
}
