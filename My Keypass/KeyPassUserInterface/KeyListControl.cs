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
	public partial class KeyListControl : UserControl
	{

		public bool CurrentlyActive = false;
		public event KeyAddedorChangedEvent KeyModified;
		public Font preffont;
		private string userSearch;


		public void invokeKeyModified(string action,Key k )
		{
			string KeyValues = 
				String.Format("Title= {0}, Username= {1}, Password= {2}, ConfirmPassword= {3}, Url= {4}, Note= {5}",k.Title,k.Username,k.Password,k.ConfirmPassword,k.URL,k.Note);
			KeyModified(action, KeyValues,1);
		}
		

		#region Private Interface

		private void KeyListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ContextManager.SelectedGroup == null)
			{
				KeyListView.Clear();
			}
			ContextManager.CurrentKeySelection = 0;
			foreach (ListViewItem Selected in KeyListView.SelectedItems)
			{

				ContextManager.CurrentKeySelection = ContextManager.CurrentKeySelection + 1;
				string KeyName = Selected.Text;
				foreach (Key k in ContextManager.SelectedGroup.Keys)
				{
					if (KeyName == k.Title)
					{
						ContextManager.SingularKey = k;
						
					}
				}
			}
			ContextManager.invokeKeySelected();
			ContextManager.invokeKeysCurrentlySelected();
		}

		private void OnIdle(object sender, EventArgs e)
		{

		}

		private void OnLoad(object sender, EventArgs e)
		{
			Application.Idle += OnIdle;
			ContextManager.GroupSelected += OnGroupSelected;
			KeyChainManager.SelectedFont += FontChange;
		}

		private void OnGroupSelected(Group g)
		{
			if (this.CurrentlyActive == true)
			{
				if (g == null)
				{
					KeyListView.Clear();
				}
				else
				{
					KeyListView.Items.Clear();
					foreach (Key k in g.Keys)
					{
						ListViewItem l = KeyListView.Items.Add(k.Title);
						l.Font = preffont;
						l.SubItems.Add(k.Username);
						l.SubItems.Add(k.Password);
						l.SubItems.Add(k.URL);
						l.Tag = k;
					}
				}
			}
		}
		#endregion


		#region Toolbar Controls
		private void DeleteKeyButton_Click(object sender, EventArgs e)
		{
			DeleteKey();
		}

		private void EditKeyButton_Click(object sender, EventArgs e)
		{
			EditKey();
		}

		private void _onNewKeyTool(object sender, EventArgs e)
		{
				NewKey();
		}

		
		

		#endregion




		#region Public Interface

		public void DeleteKey()
		{
			if (ContextManager.SingularKey == null)
			{
				MessageBox.Show("No Keys Selected");
			}
			else
			{
				foreach (ListViewItem Selected in KeyListView.SelectedItems)
				{
					ContextManager.CurrentKeySelection = ContextManager.CurrentKeySelection + 1;
					Key KeySelect = (Key)KeyListView.SelectedItems[0].Tag;
					Key delKey = KeyChainManager.FindKey(ContextManager.SelectedGroup, KeySelect);
					KeyChainManager.DeleteKey(KeyChainManager.FindGroup(ContextManager.SelectedGroup), delKey);
					invokeKeyModified("Deleted", KeySelect);
					KeyListView.BeginUpdate();
					ContextManager.SingularKey = null;
					KeyListView.SelectedItems[0].Remove();
					KeyListView.EndUpdate();
				}
				KeyChainManager.KeyChain.IsModified = true;
				ContextManager.invokeKeySelected();
				ContextManager.invokeKeysCurrentlySelected();

			}
		}

		public void EditKey()
		{
			if (ContextManager.SingularKey == null)
			{
				MessageBox.Show("You must Select a Key!");
			}
			else
			{
				KeyAddEditForm x = new KeyAddEditForm();
				if (x.ShowDialog() != DialogResult.OK)
				{
					return;
				}
				else
				{

					KeyChainManager.EditKey(x.Group, x.Key);
					KeyListView.Items.Clear();
					foreach (Key k in ContextManager.SelectedGroup.Keys)
					{
						ListViewItem l = KeyListView.Items.Add(k.Title);
						l.Font = preffont;
						l.SubItems.Add(k.Username);
						l.SubItems.Add(k.Password);
						l.SubItems.Add(k.URL);
						l.Tag = k;
					}
					KeyChainManager.KeyChain.IsModified = true;
					invokeKeyModified("Edit", x.Key);
				}
				ContextManager.invokeKeySelected();

			}
		}

		public void NewKey()
		{
			ContextManager.SingularKey = null;
			if (ContextManager.SelectedGroup.Name == "")
			{
				MessageBox.Show("You must Select a Group!");
			}
			else
			{
				KeyAddEditForm x = new KeyAddEditForm();

				if (x.ShowDialog() != DialogResult.OK)
				{
					return;
				}
				KeyChainManager.AddKey(ContextManager.SelectedGroup, x.Key);
				ListViewItem l = KeyListView.Items.Add(x.Key.Title);
				l.Font = preffont;
				l.SubItems.Add(x.Key.Username);
				l.SubItems.Add(x.Key.Password);
				l.SubItems.Add(x.Key.URL);
				l.Tag = x.Key;
				KeyChainManager.KeyChain.IsModified = true;
				invokeKeyModified("New", x.Key);
				ContextManager.invokeKeysCurrentlySelected();
			}
		}

		public void DuplicateKey()
		{
			List<Key> listtoCopy = new List<Key>();

			foreach (ListViewItem Selected in KeyListView.SelectedItems)
			{
				listtoCopy.Add((Key)Selected.Tag);
			}
			foreach (Key k in listtoCopy)
			{
				KeyChainManager.AddKey(ContextManager.SelectedGroup, k);
				ListViewItem l = KeyListView.Items.Add(k.Title);
				l.Font = preffont;
				l.SubItems.Add(k.Username);
				l.SubItems.Add(k.Password);
				l.SubItems.Add(k.URL);
				l.Tag = k;
			}
			KeyChainManager.KeyChain.IsModified = true;
			invokeKeyModified("Duplicated", ContextManager.SingularKey);
		

		}
		
				
		public KeyListControl()
		{
			InitializeComponent();
		}

	

		public void resetView()
		{
			KeyListView.Items.Clear();
		}
		#endregion


		#region Context Menu
		private void KeyContextMenu_Opening(object sender, CancelEventArgs e)
		{
			editEntryContextMenuItem.Enabled = duplicateEntryContextMenuItem.Enabled = deleteEntryContextMenuItem.Enabled = ContextManager.SingularKey != null;
		}

		private void addEntryContextMenuItem_Click(object sender, EventArgs e)
		{
			NewKey();
		}

		private void editEntryContextMenuItem_Click(object sender, EventArgs e)
		{
			EditKey();
		}

		private void deleteEntryContextMenuItem_Click(object sender, EventArgs e)
		{
			DeleteKey();
		}

		private void duplicateEntryContextMenuItem_Click(object sender, EventArgs e)
		{
			List<Key> listtoCopy = new List<Key>();

			foreach (ListViewItem Selected in KeyListView.SelectedItems)
			{
				listtoCopy.Add((Key)Selected.Tag);
			}
			foreach (Key k in listtoCopy)
			{
				KeyChainManager.AddKey(ContextManager.SelectedGroup, k);
				ListViewItem l = KeyListView.Items.Add(k.Title);
				l.SubItems.Add(k.Username);
				l.SubItems.Add(k.Password);
				l.SubItems.Add(k.URL);
				l.Tag = k;
			}
			KeyChainManager.KeyChain.IsModified = true;
			invokeKeyModified("Duplicated", ContextManager.SingularKey);
		}

		#endregion


		private void _OnColumnClick(object sender, ColumnClickEventArgs e)
		{
			if (this.KeyListView.Sorting != SortOrder.Ascending)
			{
				this.KeyListView.Sorting = SortOrder.Ascending;
			}
			else
			{
				this.KeyListView.Sorting = SortOrder.Descending;
			}
			KeyListView.Sort();
		}

		private void FontChange(String f, int s)
		{
			preffont = new Font(f, s);
			KeyListView.Items.Clear();
			if (ContextManager.SelectedGroup != null)
			{
				foreach (Key k in ContextManager.SelectedGroup.Keys)
				{
					ListViewItem l = KeyListView.Items.Add(k.Title);
					l.Font = preffont;
					l.SubItems.Add(k.Username);
					l.SubItems.Add(k.Password);
					l.SubItems.Add(k.URL);
					l.Tag = k;
				}
			}
		}

		private void FindButton_Click(object sender, EventArgs e)
		{
			userSearch = _toolStripKeySeachCombobox.Text;
			KeyListView.Items.Clear();
			foreach (Group g in KeyChainManager.KeyChain.Groups)
			{
				foreach (Key k in g.Keys)
				{
					if (k.Title.Contains(userSearch))
					{
						ListViewItem l = KeyListView.Items.Add(k.Title);
						l.Font = preffont;
						l.SubItems.Add(k.Username);
						l.SubItems.Add(k.Password);
						l.SubItems.Add(k.URL);
						l.Tag = k;
					}
				}

			}
		}

	}
	
}
