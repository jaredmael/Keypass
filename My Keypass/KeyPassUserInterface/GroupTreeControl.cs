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
using KeyPassUserInterface;
using System.IO;
using System.Xml;
using System.Reflection;



namespace KeyPassUserInterface
{
	public partial class GroupTreeControl : UserControl
	{
		public GroupTreeControl()
		{
			InitializeComponent();
		}

		public event GroupAddedOrEditedEvent GroupModified;


		public void invokeGroupModified(string action, Group g)
		{
			GroupModified(action, g.Name, 0);
		}

		
		private void OnLoad(object sender, EventArgs e)
		{
			Application.Idle += OnIdle;
            KeyChainManager.SelectedFont += FontChange;
		}

		void OnIdle(object sender, EventArgs e)
		{
			EditGroupButton.Enabled = DeleteGroupButton.Enabled = GroupTreeView.SelectedNode != null;
		}

	

		private void GroupTreeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			ContextManager.SingularKey = null;
			if (KeyChainManager.KeyChain.Groups != null)
			{
				ContextManager.SelectedGroup = (Group)GroupTreeView.SelectedNode.Tag;
				if (ContextManager.SelectedGroup!= null)
				{
					ContextManager.CurrentKeySelection = 0;
					ContextManager.invokeGroupSelected();
					ContextManager.invokeKeySelected();
					ContextManager.invokeKeysCurrentlySelected();
				}
			}
		}

		#region ToolStrip Buttons


		private void DeleteGroupTool_Click(object sender, EventArgs e)
		{
			DeleteGroup();
		}

		private void EditGroupTool_Click(object sender, EventArgs e)
		{
			EditGroup();
		}

		private void NewGroupTool_Click(object sender, EventArgs e)
		{
			NewGroup();
		}

		#endregion

	

		



		#region GroupContextMenu
		private void GroupContextMenu_Opening(object sender, CancelEventArgs e)
		{
			editGroupContextMenuItem.Enabled = deleteGroupContextMenuItem.Enabled = ContextManager.SelectedGroup != null;
		}

		private void newGroupContextMenuItem_Click(object sender, EventArgs e)
		{
			NewGroup();
		}

		private void EditGroupContextMenuItem_Click(object sender, EventArgs e)
		{
			EditGroup();
		}

		private void DeleteGroupContextMenuItem_Click(object sender, EventArgs e)
		{
			DeleteGroup();
		}

		private void copyContextMenuItem_Click(object sender, EventArgs e)
		{
			Clipboard.SetData("CopiedGroup", ContextManager.SelectedGroup);
			invokeGroupModified("Copied", ContextManager.SelectedGroup);
		}

		private void pasteContextMenuItem_Click(object sender, EventArgs e)
		{
			IDataObject GrouptoPaste = Clipboard.GetDataObject();
			Group g = (Group)GrouptoPaste.GetData("CopiedGroup");
			KeyChainManager.AddGroup(g);
			TreeNode _Node = new TreeNode();
			_Node.Text = g.Name;
			_Node.Tag = g;
			GroupTreeView.Nodes.Add(_Node);
			GroupTreeView.SelectedNode = _Node;
			KeyChainManager.KeyChain.IsModified = true;
			invokeGroupModified("Pasted", g);

		}


		#endregion

		#region Public Methods

		public void NewGroup()
		{
			ContextManager.SelectedGroup = null;
			GroupAddEditForm g = new GroupAddEditForm(ContextManager.SelectedGroup);
			if (g.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			bool success = KeyChainManager.AddGroup(g.Group);
			TreeNode _Node = new TreeNode();
			_Node.Text = g.Group.Name;
			_Node.Tag = g.Group;
			_Node.ForeColor = (Color.FromArgb(g.Group.TextColor[0], g.Group.TextColor[1],g.Group.TextColor[2]));
			//take the next 1 line out if professor says to tonight
			GroupTreeView.ForeColor = (Color.FromArgb(g.Group.TextColor[0], g.Group.TextColor[1], g.Group.TextColor[2]));
			GroupTreeView.Nodes.Add(_Node);
			GroupTreeView.SelectedNode = _Node;
			KeyChainManager.KeyChain.IsModified = true;

			invokeGroupModified("Added", g.Group);
		}

		public void EditGroup()
		{
			GroupAddEditForm g = new GroupAddEditForm(ContextManager.SelectedGroup);
			ContextManager.SelectedGroup = (KeyChainManager.FindGroup((Group)GroupTreeView.SelectedNode.Tag));
			if (g.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			ContextManager.SelectedGroup = KeyChainManager.EditGroup(ContextManager.SelectedGroup, g.Group);
			ContextManager.SelectedGroup = KeyChainManager.FindGroup(ContextManager.SelectedGroup);
			TreeNode _Node = new TreeNode();
			_Node.Text = ContextManager.SelectedGroup.Name;
			_Node.Tag = ContextManager.SelectedGroup;
			_Node.ForeColor = (Color.FromArgb(ContextManager.SelectedGroup.TextColor[0], ContextManager.SelectedGroup.TextColor[1], ContextManager.SelectedGroup.TextColor[2]));
			GroupTreeView.SelectedNode.Text = ContextManager.SelectedGroup.Name;
			GroupTreeView.SelectedNode.ForeColor = (Color.FromArgb(g.Group.TextColor[0], g.Group.TextColor[1], g.Group.TextColor[2]));
			//take the next 1 line out if professor says to tonight
			GroupTreeView.ForeColor = (Color.FromArgb(g.Group.TextColor[0], g.Group.TextColor[1], g.Group.TextColor[2]));
			invokeGroupModified("Edited", g.Group);
			KeyChainManager.KeyChain.IsModified = true;
		}

		public void DeleteGroup()
		{
			Group delGroup = ContextManager.SelectedGroup;
			KeyChainManager.DeleteGroup(delGroup);
			invokeGroupModified("Deleted", ContextManager.SelectedGroup);
			if (KeyChainManager.KeyChain.Groups.Count == 0)
			{
				ContextManager.SelectedGroup.Keys.RemoveRange(0, ContextManager.SelectedGroup.Keys.Count);
				ContextManager.invokeGroupSelected();
				ContextManager.SelectedGroup = null;
			}
			TreeNode _Node = GroupTreeView.SelectedNode;
			GroupTreeView.Nodes.Remove(_Node);
			KeyChainManager.KeyChain.IsModified = true;
		}

		public void resetView()
		{
			GroupTreeView.Nodes.Clear();
		}

		public void AddTreeNodefromFileLoad(Group g)
		{
			TreeNode _Node = new TreeNode();
			_Node.Text = g.Name;
			_Node.Tag = g;
			_Node.ForeColor = (Color.FromArgb(g.TextColor[0], g.TextColor[1], g.TextColor[2]));
			GroupTreeView.Nodes.Add(_Node);
			GroupTreeView.SelectedNode = _Node;
		}

		#endregion

        public void FontChange(String f, int s){
            GroupTreeView.Font = new Font(f, s);
        }

		private void _OnChangeColor_Click(object sender, EventArgs e)
		{
			ColorDialog c = new ColorDialog();
			c.ShowDialog();
			ContextManager.SelectedGroup.TextColor[0] = c.Color.R;
			ContextManager.SelectedGroup.TextColor[1] = c.Color.G;
			ContextManager.SelectedGroup.TextColor[2] = c.Color.B;
			ContextManager.SelectedGroup.ColorName = c.Color.Name;
			GroupTreeView.SelectedNode.ForeColor = c.Color;
		
			//needs to somehow update selected color from c to context mgr (find colorname
		}

		

	}

		
}
		
	

	

		
		

