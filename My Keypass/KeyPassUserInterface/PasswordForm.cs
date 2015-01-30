using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DropNet;
using KeyPassBusiness;

namespace KeyPassUserInterface
{
	public partial class PasswordForm : Form
	{
		public string Password;
		public string Chosen;
		public int savethis=0;
		public byte[] local;

		public PasswordForm()
		{
			InitializeComponent();
		}

		private void OnCheckedChanged(object sender, EventArgs e)
		{
			if (ShowCharactersCheckBox.Checked == true)
			{
				PasswordTextBox.PasswordChar = '\0';
			}
			else
			{
				PasswordTextBox.PasswordChar = '*';
			}
		}

		private void OKButton_Click(object sender, EventArgs e)
		{
			Password = PasswordTextBox.Text;
			while (Password.Length < 8)
			{
				Password = Password + "1";
			}

			if (Password.Length > 8)
			{
				StringBuilder sb = new StringBuilder();
				int i = 0;
				while (i < 8)
				{
					sb.Append(Password[i].ToString());
					i++;
				}
				Password = sb.ToString();
			}

			if (savethis == 1)
			{
                //Dropbox removed for demo.
				//DropNetClient Dropbox;
                //Enter tokens and keys on next line to setup dropbox. Removed for demo
                //Dropbox = new DropNetClient();
                //Dropbox.UseSandbox = true;
                //string dropboxpath = "/" + Path.GetFileName(Chosen);
                //var downloaded = Dropbox.GetFile(dropboxpath);
                //byte[] encryptedbytes = downloaded.ToArray();
                //byte[] decryptedArray = CryptoHelper.Decrypt(encryptedbytes, Password);
                //if (decryptedArray != null)
                //{
                //    DialogResult = DialogResult.OK;
                //    Close();
                //}
                //else
                //{
                //    MessageBox.Show("Wrong Password.  Try again or press Cancel to return");
                //}
			}

			if (savethis == 2)
			{
				
				byte[] encryptedbytes = local.ToArray();
				byte[] decryptedArray = CryptoHelper.Decrypt(encryptedbytes, Password);
				if (decryptedArray != null)
				{
					DialogResult = DialogResult.OK;
					Close();
				}
				else
				{
					MessageBox.Show("Wrong Password.  Try again or press Cancel to return");
				}
			}

			else if(savethis==0)
			{
				DialogResult = DialogResult.OK;
				Close();
			}
		}

			

		private void CancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}
			 

		private void KeyPassLaunchForm_Load(object sender, EventArgs e)
		{

		}


	}
}
