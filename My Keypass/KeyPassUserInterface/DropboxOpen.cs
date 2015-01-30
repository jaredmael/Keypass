using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DropNet;

namespace KeyPassUserInterface
{
	public partial class DropboxOpen : Form
	{
		public string Fchosen;
		public string pw;
		public DropboxOpen()
		{
			InitializeComponent();
		}

		private void DropboxOpen_Load(object sender, EventArgs e)
		{
            //dropbox disabled for demo
            //DropNetClient Dropbox;
            //Enter tokens and keys on next line to setup dropbox. Removed for demo
            //Dropbox = new DropNetClient();
            //Dropbox.UseSandbox = true;
            //try
            //{
            //    var metadata = Dropbox.GetMetaData("/");
            //    foreach (var f in metadata.Contents)
            //    {
            //        comboBox1.Items.Add(f.Name.ToString());
            //    }
            //}
            //catch (Exception) 
            //{
            //    MessageBox.Show("No connection to Dropbox available.  Will now load from local drive");
            //    DialogResult= DialogResult.Cancel;
            //}
		}

		private void _Load_Click(object sender, EventArgs e)
		{
			if (comboBox1.Text == "")
			{
				MessageBox.Show("You Must Select a File to load.  Press Cancel if you wish to return");
				return;
			}
			else
			{
				Fchosen = comboBox1.Text;
				PasswordForm p = new PasswordForm();
				p.Chosen = Fchosen;
				p.savethis = 1;
				p.ShowDialog();
				if (p.DialogResult == DialogResult.OK)
				{
					pw = p.Password;
					DialogResult = DialogResult.OK;
					Close();
				}
			}
		}

		private void _Cancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Abort;
			Close();
		}
	}
}
