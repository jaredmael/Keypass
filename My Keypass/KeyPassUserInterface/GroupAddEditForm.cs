using KeyPassInfoObjects;
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
using KeyPassBusiness;





namespace KeyPassUserInterface
{
	public partial class GroupAddEditForm : Form
	{
		Color SelectedColor;
		
		private Group _group = null;

		public Group Group
		{
			get { return _group; }
			set { _group = value; }
		}

		public GroupAddEditForm()
		{
			InitializeComponent();
		}
		public GroupAddEditForm(Group group)
			: this()
		{
			_group = group;
		}


		private bool ValidateUserInput()
		{
			if(string.IsNullOrEmpty(_GroupNameText.Text)){
				return false;
			}
			return true;
		}
		private void OnOK(object sender, EventArgs e)
		{
			if (!ValidateUserInput())
			{
				MessageBox.Show("Group Name is Empty!");
				return;
			}
			else
			{
				_group = new Group();
                _group.Name = _GroupNameText.Text;
                if (ColorComboBox.SelectedItem != null)
                {
					Color f= Color.FromName(ColorComboBox.SelectedItem.ToString());
					_group.ColorName = f.Name;
					_group.TextColor[0]= f.R;
					_group.TextColor[1] = f.G;
					_group.TextColor[2] = f.B;
                }
                else {
					_group.TextColor[0] = 0;
					_group.TextColor[1] = 0;
					_group.TextColor[2]= 0; 
                }
				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void OnCancel(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			return;
		}

		private void _OnLoad(object sender, EventArgs e)
		{
            Array colorOptions = Enum.GetNames(typeof(KnownColor));
            foreach (string c in colorOptions)
            {
                ColorComboBox.Items.Add(c);
            }
			if (ContextManager.SelectedGroup != null)
			{
				foreach (String c in colorOptions)
				{
					if (ContextManager.SelectedGroup.ColorName == c)
					{
						ColorComboBox.SelectedItem = c;
					}
				}
				_GroupNameText.Text = ContextManager.SelectedGroup.Name;
				SelectedColor = (Color.FromArgb(ContextManager.SelectedGroup.TextColor[0], ContextManager.SelectedGroup.TextColor[1], ContextManager.SelectedGroup.TextColor[2]));
				_GroupNameText.ForeColor = (Color.FromArgb(ContextManager.SelectedGroup.TextColor[0], ContextManager.SelectedGroup.TextColor[1], ContextManager.SelectedGroup.TextColor[2]));
			}

			
			
              
		}



		private void OnTest(object sender, EventArgs e)
		{
			_GroupNameText.Text = Path.GetRandomFileName();
		}

        private void _ColorCombobox_OnSelected(object sender, EventArgs e)
        {
            _GroupNameText.ForeColor = (Color.FromName(ColorComboBox.SelectedItem.ToString()));
        }


		

	

		

	

		
	}
}
