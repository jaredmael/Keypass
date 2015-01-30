using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyPassUserInterface
{
    public partial class UserPreferencesForm : Form
    {
		public string selectedF;
		public int selectedS;
		public bool HideinTaskbar;
		
        public UserPreferencesForm()
        {
            InitializeComponent();
        }

        private void UserPreferencesForm_Load(object sender, EventArgs e)
        {
            Array Fonts = System.Drawing.FontFamily.Families;
            foreach (FontFamily f in Fonts)
            {
				if (f.Name != "Aharoni")
				{
					FontComboBox.Items.Add(f.Name);
				}
            }
            for(int i=8; i<40; i=i+2){
                FontSizeComboBox.Items.Add(i);
            }
			FontComboBox.SelectedItem= selectedF;
			FontSizeComboBox.SelectedItem = selectedS;
			if(HideinTaskbar==true)
			{
				HideTaskbarCheckBox.Checked = true;
			}
			else 
			{
				HideTaskbarCheckBox.Checked = false;	
			}
        }

        private void _OnOK(object sender, EventArgs e)
        {
			selectedF = FontComboBox.SelectedItem.ToString();
			selectedS = Convert.ToInt32(FontSizeComboBox.SelectedItem);
            DialogResult = DialogResult.OK;
            Close();
        }

		private void _Cancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void _OnCheckChanged(object sender, EventArgs e)
		{
			if (HideTaskbarCheckBox.Checked == true)
			{
				HideinTaskbar = true;
			}
			else
			{
				HideinTaskbar = false;
			}
		}
    }
}
