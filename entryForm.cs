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

	public partial class entryForm : Form {

		string plain = "";
		string cipher = "";

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

		public entryForm() {
			InitializeComponent();
		}

		private void entryForm_Load(object sender, EventArgs e) {

		}

		private void btnSave_Click(object sender, EventArgs e) {

			string name = txtEntryName.Text;
			string email = txtEntryEmail.Text;
			string username = txtEntryUsername.Text;
			string password = txtEntryPassword.Text;
			string encKey = "123";



			string line = name + "," + email + "," + username + "," + password;


			cipher = Scramble(line, encKey);


			using (System.IO.StreamWriter file = new System.IO.StreamWriter("text.secure", true)) {
				file.WriteLine(cipher);
			}



			plain = Scramble(cipher, encKey);
			MessageBox.Show("Your info was saved successfully!");

			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			this.Close();
		}
	}
}
