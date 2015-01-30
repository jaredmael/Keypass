namespace KeyPassUserInterface
{
	partial class KeyDetailControl
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
			this._KeyDetailRichTextBox = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// _KeyDetailRichTextBox
			// 
			this._KeyDetailRichTextBox.BackColor = System.Drawing.SystemColors.Info;
			this._KeyDetailRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._KeyDetailRichTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._KeyDetailRichTextBox.Location = new System.Drawing.Point(0, 0);
			this._KeyDetailRichTextBox.Name = "_KeyDetailRichTextBox";
			this._KeyDetailRichTextBox.ReadOnly = true;
			this._KeyDetailRichTextBox.Size = new System.Drawing.Size(507, 301);
			this._KeyDetailRichTextBox.TabIndex = 0;
			this._KeyDetailRichTextBox.Text = "";
			this._KeyDetailRichTextBox.EnabledChanged += new System.EventHandler(this._OnEnableChanged);
			// 
			// KeyDetailControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._KeyDetailRichTextBox);
			this.Name = "KeyDetailControl";
			this.Size = new System.Drawing.Size(507, 301);
			this.Load += new System.EventHandler(this.OnLoad);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox _KeyDetailRichTextBox;
	}
}
