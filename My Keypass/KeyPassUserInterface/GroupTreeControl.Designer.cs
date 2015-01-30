namespace KeyPassUserInterface
{
	partial class GroupTreeControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupTreeControl));
			this.GroupToolStrip = new System.Windows.Forms.ToolStrip();
			this.NewGroupButton = new System.Windows.Forms.ToolStripButton();
			this.EditGroupButton = new System.Windows.Forms.ToolStripButton();
			this.DeleteGroupButton = new System.Windows.Forms.ToolStripButton();
			this.GroupTreeView = new System.Windows.Forms.TreeView();
			this.GroupContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.newGroupContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.editGroupContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeGroupColorContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteGroupContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.copyContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TreeViewImageList = new System.Windows.Forms.ImageList(this.components);
			this.GroupToolStrip.SuspendLayout();
			this.GroupContextMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// GroupToolStrip
			// 
			this.GroupToolStrip.BackColor = System.Drawing.SystemColors.Control;
			this.GroupToolStrip.Dock = System.Windows.Forms.DockStyle.Left;
			this.GroupToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.GroupToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGroupButton,
            this.EditGroupButton,
            this.DeleteGroupButton});
			this.GroupToolStrip.Location = new System.Drawing.Point(0, 0);
			this.GroupToolStrip.Name = "GroupToolStrip";
			this.GroupToolStrip.Size = new System.Drawing.Size(25, 277);
			this.GroupToolStrip.TabIndex = 0;
			this.GroupToolStrip.Text = "toolStrip1";
			// 
			// NewGroupButton
			// 
			this.NewGroupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.NewGroupButton.Image = ((System.Drawing.Image)(resources.GetObject("NewGroupButton.Image")));
			this.NewGroupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NewGroupButton.Name = "NewGroupButton";
			this.NewGroupButton.Size = new System.Drawing.Size(22, 24);
			this.NewGroupButton.Text = "New Group";
			this.NewGroupButton.Click += new System.EventHandler(this.NewGroupTool_Click);
			// 
			// EditGroupButton
			// 
			this.EditGroupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.EditGroupButton.Image = ((System.Drawing.Image)(resources.GetObject("EditGroupButton.Image")));
			this.EditGroupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.EditGroupButton.Name = "EditGroupButton";
			this.EditGroupButton.Size = new System.Drawing.Size(22, 24);
			this.EditGroupButton.Text = "Edit Group";
			this.EditGroupButton.Click += new System.EventHandler(this.EditGroupTool_Click);
			// 
			// DeleteGroupButton
			// 
			this.DeleteGroupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.DeleteGroupButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteGroupButton.Image")));
			this.DeleteGroupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.DeleteGroupButton.Name = "DeleteGroupButton";
			this.DeleteGroupButton.Size = new System.Drawing.Size(22, 24);
			this.DeleteGroupButton.Text = "Delete Group";
			this.DeleteGroupButton.Click += new System.EventHandler(this.DeleteGroupTool_Click);
			// 
			// GroupTreeView
			// 
			this.GroupTreeView.ContextMenuStrip = this.GroupContextMenu;
			this.GroupTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GroupTreeView.HideSelection = false;
			this.GroupTreeView.ImageIndex = 0;
			this.GroupTreeView.ImageList = this.TreeViewImageList;
			this.GroupTreeView.Location = new System.Drawing.Point(25, 0);
			this.GroupTreeView.Name = "GroupTreeView";
			this.GroupTreeView.SelectedImageIndex = 0;
			this.GroupTreeView.Size = new System.Drawing.Size(388, 277);
			this.GroupTreeView.TabIndex = 1;
			this.GroupTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.GroupTreeView_AfterSelect);
			this.GroupTreeView.DoubleClick += new System.EventHandler(this.EditGroupTool_Click);
			// 
			// GroupContextMenu
			// 
			this.GroupContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGroupContextMenuItem,
            this.toolStripSeparator1,
            this.editGroupContextMenuItem,
            this.changeGroupColorContextMenuItem,
            this.deleteGroupContextMenuItem,
            this.toolStripMenuItem1,
            this.copyContextMenuItem,
            this.pasteContextMenuItem});
			this.GroupContextMenu.Name = "GroupContextMenu";
			this.GroupContextMenu.Size = new System.Drawing.Size(184, 170);
			this.GroupContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.GroupContextMenu_Opening);
			// 
			// newGroupContextMenuItem
			// 
			this.newGroupContextMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newGroupContextMenuItem.Image")));
			this.newGroupContextMenuItem.Name = "newGroupContextMenuItem";
			this.newGroupContextMenuItem.Size = new System.Drawing.Size(183, 22);
			this.newGroupContextMenuItem.Text = "New Group";
			this.newGroupContextMenuItem.Click += new System.EventHandler(this.newGroupContextMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(180, 6);
			// 
			// editGroupContextMenuItem
			// 
			this.editGroupContextMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editGroupContextMenuItem.Image")));
			this.editGroupContextMenuItem.Name = "editGroupContextMenuItem";
			this.editGroupContextMenuItem.Size = new System.Drawing.Size(183, 22);
			this.editGroupContextMenuItem.Text = "Edit Group...";
			this.editGroupContextMenuItem.Click += new System.EventHandler(this.EditGroupContextMenuItem_Click);
			// 
			// changeGroupColorContextMenuItem
			// 
			this.changeGroupColorContextMenuItem.Name = "changeGroupColorContextMenuItem";
			this.changeGroupColorContextMenuItem.Size = new System.Drawing.Size(183, 22);
			this.changeGroupColorContextMenuItem.Text = "Change Group Color";
			this.changeGroupColorContextMenuItem.Click += new System.EventHandler(this._OnChangeColor_Click);
			// 
			// deleteGroupContextMenuItem
			// 
			this.deleteGroupContextMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteGroupContextMenuItem.Image")));
			this.deleteGroupContextMenuItem.Name = "deleteGroupContextMenuItem";
			this.deleteGroupContextMenuItem.Size = new System.Drawing.Size(183, 22);
			this.deleteGroupContextMenuItem.Text = "Delete Group...";
			this.deleteGroupContextMenuItem.Click += new System.EventHandler(this.DeleteGroupContextMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 6);
			// 
			// copyContextMenuItem
			// 
			this.copyContextMenuItem.Name = "copyContextMenuItem";
			this.copyContextMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.copyContextMenuItem.Size = new System.Drawing.Size(183, 22);
			this.copyContextMenuItem.Text = "Copy";
			this.copyContextMenuItem.Click += new System.EventHandler(this.copyContextMenuItem_Click);
			// 
			// pasteContextMenuItem
			// 
			this.pasteContextMenuItem.Name = "pasteContextMenuItem";
			this.pasteContextMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.pasteContextMenuItem.Size = new System.Drawing.Size(183, 22);
			this.pasteContextMenuItem.Text = "Paste";
			this.pasteContextMenuItem.Click += new System.EventHandler(this.pasteContextMenuItem_Click);
			// 
			// TreeViewImageList
			// 
			this.TreeViewImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TreeViewImageList.ImageStream")));
			this.TreeViewImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.TreeViewImageList.Images.SetKeyName(0, "85.gif");
			// 
			// GroupTreeControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.GroupTreeView);
			this.Controls.Add(this.GroupToolStrip);
			this.Name = "GroupTreeControl";
			this.Size = new System.Drawing.Size(413, 277);
			this.Load += new System.EventHandler(this.OnLoad);
			this.GroupToolStrip.ResumeLayout(false);
			this.GroupToolStrip.PerformLayout();
			this.GroupContextMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip GroupToolStrip;
		private System.Windows.Forms.ToolStripButton NewGroupButton;
		private System.Windows.Forms.ToolStripButton EditGroupButton;
		private System.Windows.Forms.ToolStripButton DeleteGroupButton;
		private System.Windows.Forms.TreeView GroupTreeView;
		private System.Windows.Forms.ImageList TreeViewImageList;
		private System.Windows.Forms.ContextMenuStrip GroupContextMenu;
		private System.Windows.Forms.ToolStripMenuItem newGroupContextMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem editGroupContextMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteGroupContextMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem copyContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteContextMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changeGroupColorContextMenuItem;
	}
}
