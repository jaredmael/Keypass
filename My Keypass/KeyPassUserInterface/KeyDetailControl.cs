using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyPassBusiness;
using KeyPassInfoObjects;

namespace KeyPassUserInterface
{
	public partial class KeyDetailControl : UserControl
	{
		public bool KeyCurrentlySelected = false;
		public Font pFont;
		public KeyDetailControl()
		{
			InitializeComponent();
		}


		private void OnIdle(object sender, EventArgs e)
		{

		}

		private void OnLoad(object sender, EventArgs e)
		{
			Application.Idle += OnIdle;
			ContextManager.KeySelected += OnKeySelected;
			ContextManager.GroupSelected += OnNewGroupSelected;
			KeyChainManager.SelectedFont += FontChange;
			
		}

		private void OnKeySelected(Key k)
		{

			_KeyDetailRichTextBox.Font = pFont;
			if (KeyCurrentlySelected == true)
			{
				if (ContextManager.SingularKey != null)
				{
					_KeyDetailRichTextBox.Clear();
					Key toWrite = KeyChainManager.FindKey
						(KeyChainManager.FindGroup(ContextManager.SelectedGroup), ContextManager.SingularKey);
					string groupName = KeyChainManager.FindGroup(ContextManager.SelectedGroup).Name;

					String WriteLine = String.Format("Title= {0}", toWrite.Title);
					_KeyDetailRichTextBox.AppendText(WriteLine);
					_KeyDetailRichTextBox.AppendText(Environment.NewLine);
					WriteLine = String.Format("Username= {0}", toWrite.Username);
					_KeyDetailRichTextBox.AppendText(WriteLine);
					_KeyDetailRichTextBox.AppendText(Environment.NewLine);
					WriteLine = String.Format("Password= {0}", toWrite.Password);
					_KeyDetailRichTextBox.AppendText(WriteLine);
					_KeyDetailRichTextBox.AppendText(Environment.NewLine);
					WriteLine = String.Format("Confirm Password= {0}", toWrite.ConfirmPassword);
					_KeyDetailRichTextBox.AppendText(WriteLine);
					_KeyDetailRichTextBox.AppendText(Environment.NewLine);
					WriteLine = String.Format("URL= {0}", toWrite.URL);
					_KeyDetailRichTextBox.AppendText(WriteLine);
					_KeyDetailRichTextBox.AppendText(Environment.NewLine);
					_KeyDetailRichTextBox.AppendText("Notes:");
					_KeyDetailRichTextBox.AppendText(Environment.NewLine);
					_KeyDetailRichTextBox.AppendText("___________________________________");
					_KeyDetailRichTextBox.AppendText(Environment.NewLine);
					_KeyDetailRichTextBox.AppendText(toWrite.Note);
				}
				else
				{
					_KeyDetailRichTextBox.Clear();
				}
			}
		}

		public void resetView()
		{
			_KeyDetailRichTextBox.Clear();
		}

		private void OnNewGroupSelected(Group g)
		{
			_KeyDetailRichTextBox.Clear();
		}

	

		private void _OnEnableChanged(object sender, EventArgs e)
		{
			if (this.Enabled == false)
			{
				ContextManager.KeySelected -= OnKeySelected;
				ContextManager.GroupSelected -= OnNewGroupSelected;
			}
			else
			{
				ContextManager.KeySelected += OnKeySelected;
				ContextManager.GroupSelected += OnNewGroupSelected;
			}
		}

		public void FontChange(String f, int s)
		{
			pFont = new Font(f, s);
			_KeyDetailRichTextBox.Font = pFont;
			this._KeyDetailRichTextBox.Clear();
			this._KeyDetailRichTextBox.Font = pFont;
			this.OnKeySelected(ContextManager.SingularKey);
		}


	}
}
