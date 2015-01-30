namespace KeyPassUserInterface
{
    partial class KeyListControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyListControl));
			this.KeyListToolStrip = new System.Windows.Forms.ToolStrip();
			this.NewKeyButton = new System.Windows.Forms.ToolStripButton();
			this.EditKeyButton = new System.Windows.Forms.ToolStripButton();
			this.DeleteKeyButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.FindButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this._toolStripKeySeachCombobox = new System.Windows.Forms.ToolStripComboBox();
			this.KeyListView = new System.Windows.Forms.ListView();
			this._KeyListTitleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this._keyListUsernameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this._keyListPasswordColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this._keyListUrlColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.KeyContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addEntryContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editEntryContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.duplicateEntryContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteEntryContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.KeyListToolStrip.SuspendLayout();
			this.KeyContextMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// KeyListToolStrip
			// 
			this.KeyListToolStrip.ImageScalingSize = new System.Drawing.Size(18, 18);
			this.KeyListToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewKeyButton,
            this.EditKeyButton,
            this.DeleteKeyButton,
            this.toolStripSeparator1,
            this.FindButton,
            this.toolStripSeparator2,
            this._toolStripKeySeachCombobox});
			this.KeyListToolStrip.Location = new System.Drawing.Point(0, 0);
			this.KeyListToolStrip.Name = "KeyListToolStrip";
			this.KeyListToolStrip.Size = new System.Drawing.Size(320, 25);
			this.KeyListToolStrip.TabIndex = 0;
			this.KeyListToolStrip.Text = "toolStrip1";
			// 
			// NewKeyButton
			// 
			this.NewKeyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.NewKeyButton.Image = ((System.Drawing.Image)(resources.GetObject("NewKeyButton.Image")));
			this.NewKeyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NewKeyButton.Name = "NewKeyButton";
			this.NewKeyButton.Size = new System.Drawing.Size(23, 22);
			this.NewKeyButton.Text = "New Entry";
			this.NewKeyButton.Click += new System.EventHandler(this._onNewKeyTool);
			// 
			// EditKeyButton
			// 
			this.EditKeyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.EditKeyButton.Image = ((System.Drawing.Image)(resources.GetObject("EditKeyButton.Image")));
			this.EditKeyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.EditKeyButton.Name = "EditKeyButton";
			this.EditKeyButton.Size = new System.Drawing.Size(23, 22);
			this.EditKeyButton.Text = "Edit Entry";
			this.EditKeyButton.Click += new System.EventHandler(this.EditKeyButton_Click);
			// 
			// DeleteKeyButton
			// 
			this.DeleteKeyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.DeleteKeyButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteKeyButton.Image")));
			this.DeleteKeyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.DeleteKeyButton.Name = "DeleteKeyButton";
			this.DeleteKeyButton.Size = new System.Drawing.Size(23, 22);
			this.DeleteKeyButton.Text = "Delete Entry";
			this.DeleteKeyButton.Click += new System.EventHandler(this.DeleteKeyButton_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// FindButton
			// 
			this.FindButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.FindButton.Image = ((System.Drawing.Image)(resources.GetObject("FindButton.Image")));
			this.FindButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.FindButton.Name = "FindButton";
			this.FindButton.Size = new System.Drawing.Size(23, 22);
			this.FindButton.Text = "Find";
			this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// _toolStripKeySeachCombobox
			// 
			this._toolStripKeySeachCombobox.Name = "_toolStripKeySeachCombobox";
			this._toolStripKeySeachCombobox.Size = new System.Drawing.Size(121, 25);
			// 
			// KeyListView
			// 
			this.KeyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._KeyListTitleColumn,
            this._keyListUsernameColumn,
            this._keyListPasswordColumn,
            this._keyListUrlColumn});
			this.KeyListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.KeyListView.FullRowSelect = true;
			this.KeyListView.GridLines = true;
			this.KeyListView.HideSelection = false;
			this.KeyListView.Location = new System.Drawing.Point(0, 25);
			this.KeyListView.Name = "KeyListView";
			this.KeyListView.Size = new System.Drawing.Size(320, 253);
			this.KeyListView.TabIndex = 1;
			this.KeyListView.UseCompatibleStateImageBehavior = false;
			this.KeyListView.View = System.Windows.Forms.View.Details;
			this.KeyListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this._OnColumnClick);
			this.KeyListView.SelectedIndexChanged += new System.EventHandler(this.KeyListView_SelectedIndexChanged);
			this.KeyListView.DoubleClick += new System.EventHandler(this.EditKeyButton_Click);
			// 
			// _KeyListTitleColumn
			// 
			this._KeyListTitleColumn.Text = "Title";
			// 
			// _keyListPasswordColumn
			// 
			this._keyListPasswordColumn.Text = "Password";
			// 
			// _keyListUrlColumn
			// 
			this._keyListUrlColumn.Text = "Url";
			// 
			// KeyContextMenu
			// 
			this.KeyContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEntryContextMenuItem,
            this.editEntryContextMenuItem,
            this.duplicateEntryContextMenuItem,
            this.deleteEntryContextMenuItem});
			this.KeyContextMenu.Name = "KeyContextMenu";
			this.KeyContextMenu.Size = new System.Drawing.Size(155, 92);
			this.KeyContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.KeyContextMenu_Opening);
			// 
			// addEntryContextMenuItem
			// 
			this.addEntryContextMenuItem.Name = "addEntryContextMenuItem";
			this.addEntryContextMenuItem.Size = new System.Drawing.Size(154, 22);
			this.addEntryContextMenuItem.Text = "Add Entry";
			this.addEntryContextMenuItem.Click += new System.EventHandler(this.addEntryContextMenuItem_Click);
			// 
			// editEntryContextMenuItem
			// 
			this.editEntryContextMenuItem.Name = "editEntryContextMenuItem";
			this.editEntryContextMenuItem.Size = new System.Drawing.Size(154, 22);
			this.editEntryContextMenuItem.Text = "Edit Entry";
			this.editEntryContextMenuItem.Click += new System.EventHandler(this.editEntryContextMenuItem_Click);
			// 
			// duplicateEntryContextMenuItem
			// 
			this.duplicateEntryContextMenuItem.Name = "duplicateEntryContextMenuItem";
			this.duplicateEntryContextMenuItem.Size = new System.Drawing.Size(154, 22);
			this.duplicateEntryContextMenuItem.Text = "Duplicate Entry";
			this.duplicateEntryContextMenuItem.Click += new System.EventHandler(this.duplicateEntryContextMenuItem_Click);
			// 
			// deleteEntryContextMenuItem
			// 
			this.deleteEntryContextMenuItem.Name = "deleteEntryContextMenuItem";
			this.deleteEntryContextMenuItem.Size = new System.Drawing.Size(154, 22);
			this.deleteEntryContextMenuItem.Text = "Delete Entry";
			this.deleteEntryContextMenuItem.Click += new System.EventHandler(this.deleteEntryContextMenuItem_Click);
			// 
			// KeyListControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ContextMenuStrip = this.KeyContextMenu;
			this.Controls.Add(this.KeyListView);
			this.Controls.Add(this.KeyListToolStrip);
			this.Name = "KeyListControl";
			this.Size = new System.Drawing.Size(320, 278);
			this.Load += new System.EventHandler(this.OnLoad);
			this.KeyListToolStrip.ResumeLayout(false);
			this.KeyListToolStrip.PerformLayout();
			this.KeyContextMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip KeyListToolStrip;
        private System.Windows.Forms.ToolStripButton NewKeyButton;
        private System.Windows.Forms.ToolStripButton EditKeyButton;
        private System.Windows.Forms.ToolStripButton DeleteKeyButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton FindButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox _toolStripKeySeachCombobox;
        private System.Windows.Forms.ColumnHeader _KeyListTitleColumn;
        private System.Windows.Forms.ColumnHeader _keyListUsernameColumn;
        private System.Windows.Forms.ColumnHeader _keyListPasswordColumn;
        private System.Windows.Forms.ColumnHeader _keyListUrlColumn;
        public System.Windows.Forms.ListView KeyListView;
		private System.Windows.Forms.ContextMenuStrip KeyContextMenu;
		private System.Windows.Forms.ToolStripMenuItem addEntryContextMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editEntryContextMenuItem;
		private System.Windows.Forms.ToolStripMenuItem duplicateEntryContextMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteEntryContextMenuItem;
    }
}
