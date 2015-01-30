namespace KeyPassUserInterface
{
	partial class MainForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.MenuFlie = new System.Windows.Forms.ToolStripMenuItem();
			this.FileNew = new System.Windows.Forms.ToolStripMenuItem();
			this.FileOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.FileClose = new System.Windows.Forms.ToolStripMenuItem();
			this.FileCloseAll = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.FileSave = new System.Windows.Forms.ToolStripMenuItem();
			this.FileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.FilePrint = new System.Windows.Forms.ToolStripMenuItem();
			this.FilePrintPreview = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.FileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.EditAddGroup = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.EditEditGroup = new System.Windows.Forms.ToolStripMenuItem();
			this.EditDeleteGroup = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			this.EditAddEntry = new System.Windows.Forms.ToolStripMenuItem();
			this.EditEditEntry = new System.Windows.Forms.ToolStripMenuItem();
			this.EditDeleteEntry = new System.Windows.Forms.ToolStripMenuItem();
			this.EditDuplicateEntry = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
			this.EditFind = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuView = new System.Windows.Forms.ToolStripMenuItem();
			this.ViewToolbar = new System.Windows.Forms.ToolStripMenuItem();
			this.ViewStatusBar = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuTools = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolsOptions = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
			this.tileHorizontallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.WindowArrangeTileHorizontally = new System.Windows.Forms.ToolStripMenuItem();
			this.WindowArrangeTilesVertically = new System.Windows.Forms.ToolStripMenuItem();
			this.WindowArrangeTilesCascade = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpContents = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
			this.HelpAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.ToolStripNew = new System.Windows.Forms.ToolStripButton();
			this.ToolStripOpen = new System.Windows.Forms.ToolStripButton();
			this.ToolStripSave = new System.Windows.Forms.ToolStripButton();
			this.ToolStripPrint = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripAbout = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.KeyPassTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.TrayIconMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStripControl1 = new KeyPassUserInterface.StatusStripControl();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.TrayIconMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFlie,
            this.MenuEdit,
            this.MenuView,
            this.MenuTools,
            this.toolStripMenuItem6,
            this.MenuHelp});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(852, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// MenuFlie
			// 
			this.MenuFlie.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileNew,
            this.FileOpen,
            this.FileClose,
            this.FileCloseAll,
            this.toolStripMenuItem1,
            this.FileSave,
            this.FileSaveAs,
            this.toolStripMenuItem2,
            this.FilePrint,
            this.FilePrintPreview,
            this.toolStripMenuItem3,
            this.FileExit});
			this.MenuFlie.Name = "MenuFlie";
			this.MenuFlie.Size = new System.Drawing.Size(37, 20);
			this.MenuFlie.Text = "File";
			this.MenuFlie.DropDownOpened += new System.EventHandler(this.FileMenuOpening);
			// 
			// FileNew
			// 
			this.FileNew.Image = ((System.Drawing.Image)(resources.GetObject("FileNew.Image")));
			this.FileNew.Name = "FileNew";
			this.FileNew.Size = new System.Drawing.Size(152, 22);
			this.FileNew.Text = "New";
			this.FileNew.Click += new System.EventHandler(this.FileNew_Click);
			// 
			// FileOpen
			// 
			this.FileOpen.Image = ((System.Drawing.Image)(resources.GetObject("FileOpen.Image")));
			this.FileOpen.Name = "FileOpen";
			this.FileOpen.Size = new System.Drawing.Size(152, 22);
			this.FileOpen.Text = "Open...";
			this.FileOpen.Click += new System.EventHandler(this.FileOpen_Click);
			// 
			// FileClose
			// 
			this.FileClose.Name = "FileClose";
			this.FileClose.Size = new System.Drawing.Size(152, 22);
			this.FileClose.Text = "Close";
			this.FileClose.Click += new System.EventHandler(this.FileClose_Click);
			// 
			// FileCloseAll
			// 
			this.FileCloseAll.Name = "FileCloseAll";
			this.FileCloseAll.Size = new System.Drawing.Size(152, 22);
			this.FileCloseAll.Text = "Close All";
			this.FileCloseAll.Click += new System.EventHandler(this.FileCloseAll_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
			// 
			// FileSave
			// 
			this.FileSave.Image = ((System.Drawing.Image)(resources.GetObject("FileSave.Image")));
			this.FileSave.Name = "FileSave";
			this.FileSave.Size = new System.Drawing.Size(152, 22);
			this.FileSave.Text = "Save";
			this.FileSave.Click += new System.EventHandler(this.FileSave_Click);
			// 
			// FileSaveAs
			// 
			this.FileSaveAs.Name = "FileSaveAs";
			this.FileSaveAs.Size = new System.Drawing.Size(152, 22);
			this.FileSaveAs.Text = "Save As...";
			this.FileSaveAs.Click += new System.EventHandler(this.FileSaveAs_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
			// 
			// FilePrint
			// 
			this.FilePrint.Image = ((System.Drawing.Image)(resources.GetObject("FilePrint.Image")));
			this.FilePrint.Name = "FilePrint";
			this.FilePrint.Size = new System.Drawing.Size(152, 22);
			this.FilePrint.Text = "Print...";
			this.FilePrint.Click += new System.EventHandler(this.FilePrint_Click);
			// 
			// FilePrintPreview
			// 
			this.FilePrintPreview.Image = ((System.Drawing.Image)(resources.GetObject("FilePrintPreview.Image")));
			this.FilePrintPreview.Name = "FilePrintPreview";
			this.FilePrintPreview.Size = new System.Drawing.Size(152, 22);
			this.FilePrintPreview.Text = "Print Preview";
			this.FilePrintPreview.Click += new System.EventHandler(this.FilePrintPreview_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(149, 6);
			// 
			// FileExit
			// 
			this.FileExit.Name = "FileExit";
			this.FileExit.Size = new System.Drawing.Size(152, 22);
			this.FileExit.Text = "Exit";
			this.FileExit.Click += new System.EventHandler(this.FileExit_onClick);
			// 
			// MenuEdit
			// 
			this.MenuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditAddGroup,
            this.toolStripMenuItem4,
            this.EditEditGroup,
            this.EditDeleteGroup,
            this.toolStripMenuItem5,
            this.EditAddEntry,
            this.EditEditEntry,
            this.EditDeleteEntry,
            this.EditDuplicateEntry,
            this.toolStripMenuItem10,
            this.EditFind});
			this.MenuEdit.Name = "MenuEdit";
			this.MenuEdit.Size = new System.Drawing.Size(39, 20);
			this.MenuEdit.Text = "Edit";
			this.MenuEdit.DropDownOpening += new System.EventHandler(this.MenuEditOpening);
			// 
			// EditAddGroup
			// 
			this.EditAddGroup.Image = ((System.Drawing.Image)(resources.GetObject("EditAddGroup.Image")));
			this.EditAddGroup.Name = "EditAddGroup";
			this.EditAddGroup.Size = new System.Drawing.Size(163, 22);
			this.EditAddGroup.Text = "Add Group...";
			this.EditAddGroup.Click += new System.EventHandler(this.EditAddGroup_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(160, 6);
			// 
			// EditEditGroup
			// 
			this.EditEditGroup.Name = "EditEditGroup";
			this.EditEditGroup.Size = new System.Drawing.Size(163, 22);
			this.EditEditGroup.Text = "Edit Group...";
			this.EditEditGroup.Click += new System.EventHandler(this.EditEditGroup_Click);
			// 
			// EditDeleteGroup
			// 
			this.EditDeleteGroup.Image = ((System.Drawing.Image)(resources.GetObject("EditDeleteGroup.Image")));
			this.EditDeleteGroup.Name = "EditDeleteGroup";
			this.EditDeleteGroup.Size = new System.Drawing.Size(163, 22);
			this.EditDeleteGroup.Text = "Delete Group...";
			this.EditDeleteGroup.Click += new System.EventHandler(this.EditDeleteGroup_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(160, 6);
			// 
			// EditAddEntry
			// 
			this.EditAddEntry.Image = ((System.Drawing.Image)(resources.GetObject("EditAddEntry.Image")));
			this.EditAddEntry.Name = "EditAddEntry";
			this.EditAddEntry.Size = new System.Drawing.Size(163, 22);
			this.EditAddEntry.Text = "Add Entry...";
			this.EditAddEntry.Click += new System.EventHandler(this.EditAddEntry_Click);
			// 
			// EditEditEntry
			// 
			this.EditEditEntry.Image = ((System.Drawing.Image)(resources.GetObject("EditEditEntry.Image")));
			this.EditEditEntry.Name = "EditEditEntry";
			this.EditEditEntry.Size = new System.Drawing.Size(163, 22);
			this.EditEditEntry.Text = "Edit Entry...";
			this.EditEditEntry.Click += new System.EventHandler(this.EditEditEntry_Click);
			// 
			// EditDeleteEntry
			// 
			this.EditDeleteEntry.Image = ((System.Drawing.Image)(resources.GetObject("EditDeleteEntry.Image")));
			this.EditDeleteEntry.Name = "EditDeleteEntry";
			this.EditDeleteEntry.Size = new System.Drawing.Size(163, 22);
			this.EditDeleteEntry.Text = "Delete Entry...";
			this.EditDeleteEntry.Click += new System.EventHandler(this.EditDeleteEntry_Click);
			// 
			// EditDuplicateEntry
			// 
			this.EditDuplicateEntry.Image = ((System.Drawing.Image)(resources.GetObject("EditDuplicateEntry.Image")));
			this.EditDuplicateEntry.Name = "EditDuplicateEntry";
			this.EditDuplicateEntry.Size = new System.Drawing.Size(163, 22);
			this.EditDuplicateEntry.Text = "Duplicate Entry...";
			this.EditDuplicateEntry.Click += new System.EventHandler(this.EditDuplicateEntry_Click);
			// 
			// toolStripMenuItem10
			// 
			this.toolStripMenuItem10.Name = "toolStripMenuItem10";
			this.toolStripMenuItem10.Size = new System.Drawing.Size(160, 6);
			// 
			// EditFind
			// 
			this.EditFind.Image = ((System.Drawing.Image)(resources.GetObject("EditFind.Image")));
			this.EditFind.Name = "EditFind";
			this.EditFind.Size = new System.Drawing.Size(163, 22);
			this.EditFind.Text = "Find...";
			// 
			// MenuView
			// 
			this.MenuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewToolbar,
            this.ViewStatusBar});
			this.MenuView.Name = "MenuView";
			this.MenuView.Size = new System.Drawing.Size(44, 20);
			this.MenuView.Text = "View";
			// 
			// ViewToolbar
			// 
			this.ViewToolbar.Checked = true;
			this.ViewToolbar.CheckOnClick = true;
			this.ViewToolbar.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ViewToolbar.Name = "ViewToolbar";
			this.ViewToolbar.Size = new System.Drawing.Size(126, 22);
			this.ViewToolbar.Text = "Toolbar";
			this.ViewToolbar.CheckStateChanged += new System.EventHandler(this.ViewToolbar_onCheck);
			// 
			// ViewStatusBar
			// 
			this.ViewStatusBar.Checked = true;
			this.ViewStatusBar.CheckOnClick = true;
			this.ViewStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ViewStatusBar.Name = "ViewStatusBar";
			this.ViewStatusBar.Size = new System.Drawing.Size(126, 22);
			this.ViewStatusBar.Text = "Status Bar";
			this.ViewStatusBar.CheckStateChanged += new System.EventHandler(this.ViewStatusBar_onCheck);
			// 
			// MenuTools
			// 
			this.MenuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolsOptions});
			this.MenuTools.Name = "MenuTools";
			this.MenuTools.Size = new System.Drawing.Size(48, 20);
			this.MenuTools.Text = "Tools";
			// 
			// ToolsOptions
			// 
			this.ToolsOptions.Image = ((System.Drawing.Image)(resources.GetObject("ToolsOptions.Image")));
			this.ToolsOptions.Name = "ToolsOptions";
			this.ToolsOptions.Size = new System.Drawing.Size(125, 22);
			this.ToolsOptions.Text = "Options...";
			this.ToolsOptions.Click += new System.EventHandler(this.ToolsOptions_Click);
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tileHorizontallyToolStripMenuItem});
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(63, 20);
			this.toolStripMenuItem6.Text = "Window";
			// 
			// tileHorizontallyToolStripMenuItem
			// 
			this.tileHorizontallyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WindowArrangeTileHorizontally,
            this.WindowArrangeTilesVertically,
            this.WindowArrangeTilesCascade});
			this.tileHorizontallyToolStripMenuItem.Name = "tileHorizontallyToolStripMenuItem";
			this.tileHorizontallyToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.tileHorizontallyToolStripMenuItem.Text = "Arrange Tiles ";
			// 
			// WindowArrangeTileHorizontally
			// 
			this.WindowArrangeTileHorizontally.Name = "WindowArrangeTileHorizontally";
			this.WindowArrangeTileHorizontally.Size = new System.Drawing.Size(138, 22);
			this.WindowArrangeTileHorizontally.Text = "Horizontally";
			this.WindowArrangeTileHorizontally.Click += new System.EventHandler(this.WindowArrangeTileHorizontally_OnClick);
			// 
			// WindowArrangeTilesVertically
			// 
			this.WindowArrangeTilesVertically.Name = "WindowArrangeTilesVertically";
			this.WindowArrangeTilesVertically.Size = new System.Drawing.Size(138, 22);
			this.WindowArrangeTilesVertically.Text = "Vertically";
			this.WindowArrangeTilesVertically.Click += new System.EventHandler(this.WindowArrangeTileVertically_OnClick);
			// 
			// WindowArrangeTilesCascade
			// 
			this.WindowArrangeTilesCascade.Name = "WindowArrangeTilesCascade";
			this.WindowArrangeTilesCascade.Size = new System.Drawing.Size(138, 22);
			this.WindowArrangeTilesCascade.Text = "Cascade";
			this.WindowArrangeTilesCascade.Click += new System.EventHandler(this.WindowArrangeTileCascade_OnClick);
			// 
			// MenuHelp
			// 
			this.MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpContents,
            this.toolStripMenuItem7,
            this.HelpAbout});
			this.MenuHelp.Name = "MenuHelp";
			this.MenuHelp.Size = new System.Drawing.Size(44, 20);
			this.MenuHelp.Text = "Help";
			// 
			// HelpContents
			// 
			this.HelpContents.Image = ((System.Drawing.Image)(resources.GetObject("HelpContents.Image")));
			this.HelpContents.Name = "HelpContents";
			this.HelpContents.Size = new System.Drawing.Size(131, 22);
			this.HelpContents.Text = "Contents...";
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new System.Drawing.Size(128, 6);
			// 
			// HelpAbout
			// 
			this.HelpAbout.Image = ((System.Drawing.Image)(resources.GetObject("HelpAbout.Image")));
			this.HelpAbout.Name = "HelpAbout";
			this.HelpAbout.Size = new System.Drawing.Size(131, 22);
			this.HelpAbout.Text = "About...";
			this.HelpAbout.Click += new System.EventHandler(this.HelpAbout_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripNew,
            this.ToolStripOpen,
            this.ToolStripSave,
            this.ToolStripPrint,
            this.toolStripSeparator1,
            this.ToolStripAbout,
            this.toolStripSeparator2});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(852, 31);
			this.toolStrip1.Stretch = true;
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "New";
			// 
			// ToolStripNew
			// 
			this.ToolStripNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolStripNew.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripNew.Image")));
			this.ToolStripNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripNew.Name = "ToolStripNew";
			this.ToolStripNew.Size = new System.Drawing.Size(28, 28);
			this.ToolStripNew.Text = "New";
			this.ToolStripNew.Click += new System.EventHandler(this.ToolStripNew_Click);
			// 
			// ToolStripOpen
			// 
			this.ToolStripOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolStripOpen.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripOpen.Image")));
			this.ToolStripOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripOpen.Name = "ToolStripOpen";
			this.ToolStripOpen.Size = new System.Drawing.Size(28, 28);
			this.ToolStripOpen.Text = "Open";
			this.ToolStripOpen.Click += new System.EventHandler(this.ToolStripOpen_Click);
			// 
			// ToolStripSave
			// 
			this.ToolStripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolStripSave.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripSave.Image")));
			this.ToolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripSave.Name = "ToolStripSave";
			this.ToolStripSave.Size = new System.Drawing.Size(28, 28);
			this.ToolStripSave.Text = "Save";
			this.ToolStripSave.Click += new System.EventHandler(this.ToolStripSave_Click);
			// 
			// ToolStripPrint
			// 
			this.ToolStripPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolStripPrint.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripPrint.Image")));
			this.ToolStripPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripPrint.Name = "ToolStripPrint";
			this.ToolStripPrint.Size = new System.Drawing.Size(28, 28);
			this.ToolStripPrint.Text = "Print";
			this.ToolStripPrint.Click += new System.EventHandler(this.ToolStripPrint_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
			// 
			// ToolStripAbout
			// 
			this.ToolStripAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolStripAbout.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripAbout.Image")));
			this.ToolStripAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripAbout.Name = "ToolStripAbout";
			this.ToolStripAbout.Size = new System.Drawing.Size(28, 28);
			this.ToolStripAbout.Text = "About";
			this.ToolStripAbout.Click += new System.EventHandler(this.ToolStripAboutButton_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
			// 
			// KeyPassTrayIcon
			// 
			this.KeyPassTrayIcon.BalloonTipText = "My Key Pass launched";
			this.KeyPassTrayIcon.BalloonTipTitle = "My Key Pass";
			this.KeyPassTrayIcon.ContextMenuStrip = this.TrayIconMenuStrip;
			this.KeyPassTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("KeyPassTrayIcon.Icon")));
			this.KeyPassTrayIcon.Text = "My Key Pass";
			this.KeyPassTrayIcon.Visible = true;
			this.KeyPassTrayIcon.DoubleClick += new System.EventHandler(this._TrayIcon_DoubleClick);
			// 
			// TrayIconMenuStrip
			// 
			this.TrayIconMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.TrayIconMenuStrip.Name = "TrayIconMenuStrip";
			this.TrayIconMenuStrip.Size = new System.Drawing.Size(114, 48);
			// 
			// restoreToolStripMenuItem
			// 
			this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
			this.restoreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.restoreToolStripMenuItem.Text = "Restore";
			this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// statusStripControl1
			// 
			this.statusStripControl1.BackColor = System.Drawing.SystemColors.Highlight;
			this.statusStripControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.statusStripControl1.Location = new System.Drawing.Point(0, 453);
			this.statusStripControl1.Name = "statusStripControl1";
			this.statusStripControl1.Size = new System.Drawing.Size(852, 31);
			this.statusStripControl1.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(852, 484);
			this.Controls.Add(this.statusStripControl1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "My Key Pass";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._OnExit);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDropped);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.TrayIconMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem MenuFlie;
		private System.Windows.Forms.ToolStripMenuItem FileNew;
		private System.Windows.Forms.ToolStripMenuItem FileOpen;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem FileSave;
		private System.Windows.Forms.ToolStripMenuItem FileSaveAs;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem FilePrint;
		private System.Windows.Forms.ToolStripMenuItem FilePrintPreview;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem FileExit;
		private System.Windows.Forms.ToolStripMenuItem MenuEdit;
		private System.Windows.Forms.ToolStripMenuItem EditAddGroup;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem EditEditGroup;
		private System.Windows.Forms.ToolStripMenuItem EditDeleteGroup;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem EditAddEntry;
		private System.Windows.Forms.ToolStripMenuItem EditEditEntry;
		private System.Windows.Forms.ToolStripMenuItem EditDeleteEntry;
		private System.Windows.Forms.ToolStripMenuItem EditDuplicateEntry;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
		private System.Windows.Forms.ToolStripMenuItem EditFind;
		private System.Windows.Forms.ToolStripMenuItem MenuView;
		private System.Windows.Forms.ToolStripMenuItem MenuTools;
		private System.Windows.Forms.ToolStripMenuItem ToolsOptions;
		private System.Windows.Forms.ToolStripMenuItem MenuHelp;
		private System.Windows.Forms.ToolStripMenuItem HelpContents;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
		private System.Windows.Forms.ToolStripMenuItem HelpAbout;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton ToolStripNew;
		private System.Windows.Forms.ToolStripButton ToolStripOpen;
		private System.Windows.Forms.ToolStripButton ToolStripSave;
		private System.Windows.Forms.ToolStripButton ToolStripPrint;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton ToolStripAbout;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem ViewToolbar;
		private System.Windows.Forms.ToolStripMenuItem ViewStatusBar;
		private StatusStripControl statusStripControl1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem tileHorizontallyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem WindowArrangeTileHorizontally;
		private System.Windows.Forms.ToolStripMenuItem WindowArrangeTilesVertically;
		private System.Windows.Forms.ToolStripMenuItem WindowArrangeTilesCascade;
		private System.Windows.Forms.NotifyIcon KeyPassTrayIcon;
		private System.Windows.Forms.ContextMenuStrip TrayIconMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem FileClose;
		private System.Windows.Forms.ToolStripMenuItem FileCloseAll;
	}
}