using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secure {

	public partial class mainForm : Form {

		#region Global Variables

		string Scramble(string data, string key) {

			string encrypted = "";
			char temp;

			data.ToList().ForEach(c => {

				temp = (char)255;

				for (int i = 0; i < key.Length; i++) {

					if (temp == 255) {
						temp = (char)(c ^ key[i]);
					}

					else {
						temp = (char)(temp ^ key[i]);
					}
				}

				encrypted += temp;
			});

			return encrypted;
		}

		#endregion

		public mainForm() {

			InitializeComponent();
		}

		private void mainForm_Load(object sender, EventArgs e) {

			//System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["loginForm"];
			//string key = ((loginForm)f).txtLoginPassword.Text;

			//MessageBox.Show(key);

			//var data = Scramble(textBox1.Text, txtDecryptionKey.Text);
			//MessageBox.Show(data);

			//Scramble(data, key);

		}


		private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
			MessageBox.Show("Author: Haider Ali Mirza\nVersion: 0.0.0", "About Secure", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}


		private void btnRefresh_Click(object sender, EventArgs e) {

			string dir = System.IO.Directory.GetCurrentDirectory();

			string[] lines = System.IO.File.ReadAllLines(dir + "/text.secure");

			string key = "123";

			int a = lines.Length;
			txtOutput.Text = "";

			for (int n = 0; n < a; n++) {

				txtOutput.Text += "___________________________________" + Environment.NewLine + Environment.NewLine;

				string[] plainText = Scramble(lines[n], key).Split(',');

				string name = plainText[0];
				string email = plainText[1];
				string username = plainText[2];
				string password = plainText[3];

				txtOutput.Text += "Name:	" + name + Environment.NewLine;
				txtOutput.Text += "Email:	" + email + Environment.NewLine;
				txtOutput.Text += "User:	" + username + Environment.NewLine;
				txtOutput.Text += "Pass:	" + password + Environment.NewLine;

				txtOutput.Text += Environment.NewLine;
			}
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e) {
			entryForm formEntry;
			formEntry = new entryForm();
			formEntry.ShowDialog();

		}
	}
}
