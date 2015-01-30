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
	public partial class MDIChildForm : Form
	{

		public KeyChain kc = new KeyChain();
		public Group gSelected = new Group();
		public Key kSelected = new Key();
        public string Ftype;
        public int Fsize;
		
		public MDIChildForm()
		{
			InitializeComponent();
		}
		

		private void _OnLoad(object sender, EventArgs e)
		{
			KeyChainManager.KeyChain = this.kc;
			groupTreeControl1.GroupModified += ((MainForm)this.MdiParent).StatusStripComboBoxEvent;
			keyListControl1.KeyModified += ((MainForm)this.MdiParent).StatusStripComboBoxEvent;
            this.SetFont(Ftype, Fsize);
			keyListControl1.preffont = new Font(Ftype, Fsize);
			keyDetailControl1.Font = new Font(Ftype, Fsize);
		}

		private void _OnActivate(object sender, EventArgs e)
		{
			keyListControl1.CurrentlyActive = true;
			keyDetailControl1.KeyCurrentlySelected = true;
			groupTreeControl1.GroupModified += UpdateLocalKeyChain;
			keyListControl1.KeyModified += UpdateLocalKeyChain;
			KeyChainManager.KeyChain = this.kc;
			ContextManager.SelectedGroup = gSelected;
			ContextManager.SingularKey = kSelected;
			//((MainForm)this.Parent).statusStripGroupTotal(ContextManager.SelectedGroup);
			//((MainForm)this.Parent).statusStripKeysSelected(ContextManager.CurrentKeySelection, ContextManager.SelectedGroup.Keys.Count);
		}

		private void UpdateLocalKeyChain(string a, string b, int c){
			this.kc=KeyChainManager.KeyChain;
			gSelected = ContextManager.SelectedGroup;
			kSelected = ContextManager.SingularKey;
		}

		private void _OnDeactivate(object sender, EventArgs e)
		{
			keyListControl1.CurrentlyActive = false;
			keyDetailControl1.KeyCurrentlySelected = false;
		}

		public void LoadFile()
		{
			if (KeyChainManager.KeyChain.Name!=String.Empty){
				this.Text = Path.GetFileName(KeyChainManager.KeyChain.Name); 
			}
			//this to show info loaded when load is run from main need to add groups to Grouptree and keys to keylist
			foreach (Group g in KeyChainManager.KeyChain.Groups)
			{
				groupTreeControl1.AddTreeNodefromFileLoad(g);
				gSelected = g;
				kSelected = ContextManager.SingularKey;
			}
			this.kc = KeyChainManager.KeyChain;
		}

        private void SetFont(string f, int s)
        {
            groupTreeControl1.Font = new Font(f, s);
            foreach (ListViewItem lvi in keyListControl1.KeyListView.Items)
            {
                lvi.Font = new Font(f, s);
            }
        }

		private void _OnClose(object sender, FormClosingEventArgs e)
		{
			if (KeyChainManager.isModified == true)
			{
				DialogResult dr = MessageBox.Show("Current document has unsaved changes. Save Changes? ", "My Keypass",
					MessageBoxButtons.YesNoCancel);
				if (dr == DialogResult.Cancel)
				{
					e.Cancel=true;
				}
				
				else if (dr == DialogResult.Yes)
				{
					((MainForm)this.MdiParent).Save();
				}
			}
		}
		public void Groupadd()
		{
			groupTreeControl1.NewGroup();
		}

		public void GroupEdit() 
		{
			groupTreeControl1.EditGroup();
		}

		public void GroupDelete()
		{
			groupTreeControl1.DeleteGroup();
		}

		public void KeyAdd()
		{
			keyListControl1.NewKey();
		}

		public void KeyEdit()
		{
			keyListControl1.EditKey();
		}

		public void KeyDelete()
		{
			keyListControl1.DeleteKey();
		}

		public void KeyDuplicate()
		{
			keyListControl1.DuplicateKey();
		}

	}
}