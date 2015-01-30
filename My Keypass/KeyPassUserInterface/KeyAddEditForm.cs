using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyPassInfoObjects;
using KeyPassBusiness;
using System.IO;

namespace KeyPassUserInterface
{
	public partial class KeyAddEditForm : Form
	{
	#region Private Data
		private Key _key=null;
		private Group _group = null;

	#endregion

	


	#region Private Interface
		private bool Validate()
		{
			if (string.IsNullOrEmpty(_titleTextbox.Text)
				|| string.IsNullOrEmpty(_usernameTextBox.Text)
				|| string.IsNullOrEmpty(_passwordTextBox.Text)
				|| string.IsNullOrEmpty(_confirmPasswordTextBox.Text)
				|| string.IsNullOrEmpty(_urlTextBox.Text)
				|| string.IsNullOrEmpty(_noteTextBox.Text))
			{
				return false;
			}
			else
				return true;
		}
		private void _OnOK(object sender, EventArgs e)
		{
			if (!Validate())
			{
				MessageBox.Show("Please complete the form!");
			}
			else
			{
				_key = new Key();
				Key.Title = _titleTextbox.Text;
				Key.Username = _usernameTextBox.Text;
				Key.Password = _passwordTextBox.Text;
				Key.ConfirmPassword = _confirmPasswordTextBox.Text;
				Key.URL = _urlTextBox.Text;
				Key.Note = _noteTextBox.Text;
				DialogResult = DialogResult.OK;

				foreach (Group g in KeyChainManager.KeyChain.Groups)
				{
					if (g.Name == (string)_GroupNameComboBox.SelectedItem)
					{
						_group = g;
					}
				}
			}

		}



		private void _onRandom(object sender, EventArgs e)
		{
			_titleTextbox.Text = Path.GetRandomFileName();
			_usernameTextBox.Text = Path.GetRandomFileName();
			_passwordTextBox.Text = Path.GetRandomFileName();
			_confirmPasswordTextBox.Text = _passwordTextBox.Text;
			_urlTextBox.Text = Path.GetRandomFileName();
			_noteTextBox.Text = Path.GetRandomFileName();
		}

		private void _OnCancel(object sender, EventArgs e)
		{
			return;
		}

		private void KeyAddEditForm_Load(object sender, EventArgs e)
		{
			foreach (Group g in KeyChainManager.KeyChain.Groups)
			{
				_GroupNameComboBox.Items.Add(g.Name);
				_GroupNameComboBox.SelectedItem = ContextManager.SelectedGroup.Name;
				if (ContextManager.SingularKey != null)
				{
					_titleTextbox.Text = ContextManager.SingularKey.Title;
					_usernameTextBox.Text = ContextManager.SingularKey.Username;
					_passwordTextBox.Text = ContextManager.SingularKey.Password;
					_confirmPasswordTextBox.Text = ContextManager.SingularKey.ConfirmPassword;
					_urlTextBox.Text = ContextManager.SingularKey.URL;
					_noteTextBox.Text = ContextManager.SingularKey.Note;
				}


			}
		}

	#endregion

	#region Public

		public Key Key
		{
			get { return _key; }
			set { _key = value; }
		}

		public Group Group
		{
			get { return _group; }
			set { _group = value; }
		}

		
		public KeyAddEditForm()
		{
			InitializeComponent();
		}
	#endregion

		

	





	}
}
