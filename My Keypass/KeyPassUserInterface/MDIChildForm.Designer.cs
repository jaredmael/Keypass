namespace KeyPassUserInterface
{
	partial class MDIChildForm
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.groupTreeControl1 = new KeyPassUserInterface.GroupTreeControl();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.keyListControl1 = new KeyPassUserInterface.KeyListControl();
			this.keyDetailControl1 = new KeyPassUserInterface.KeyDetailControl();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.groupTreeControl1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(782, 507);
			this.splitContainer1.SplitterDistance = 241;
			this.splitContainer1.TabIndex = 4;
			// 
			// groupTreeControl1
			// 
			this.groupTreeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupTreeControl1.Location = new System.Drawing.Point(0, 0);
			this.groupTreeControl1.Name = "groupTreeControl1";
			this.groupTreeControl1.Size = new System.Drawing.Size(237, 503);
			this.groupTreeControl1.TabIndex = 0;
			// 
			// splitContainer2
			// 
			this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.keyListControl1);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.keyDetailControl1);
			this.splitContainer2.Size = new System.Drawing.Size(537, 507);
			this.splitContainer2.SplitterDistance = 253;
			this.splitContainer2.TabIndex = 0;
			// 
			// keyListControl1
			// 
			this.keyListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.keyListControl1.Location = new System.Drawing.Point(0, 0);
			this.keyListControl1.Name = "keyListControl1";
			this.keyListControl1.Size = new System.Drawing.Size(533, 249);
			this.keyListControl1.TabIndex = 0;
			// 
			// keyDetailControl1
			// 
			this.keyDetailControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.keyDetailControl1.Location = new System.Drawing.Point(0, 0);
			this.keyDetailControl1.Name = "keyDetailControl1";
			this.keyDetailControl1.Size = new System.Drawing.Size(533, 246);
			this.keyDetailControl1.TabIndex = 0;
			// 
			// MDIChildForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(782, 507);
			this.Controls.Add(this.splitContainer1);
			this.Name = "MDIChildForm";
			this.Text = "MDIChildForm";
			this.Activated += new System.EventHandler(this._OnActivate);
			this.Deactivate += new System.EventHandler(this._OnDeactivate);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._OnClose);
			this.Load += new System.EventHandler(this._OnLoad);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private GroupTreeControl groupTreeControl1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private KeyListControl keyListControl1;
		private KeyDetailControl keyDetailControl1;
	}
}