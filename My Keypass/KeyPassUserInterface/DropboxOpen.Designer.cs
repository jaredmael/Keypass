namespace KeyPassUserInterface
{
	partial class DropboxOpen
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this._Load = new System.Windows.Forms.Button();
			this._Cancel = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.comboBox1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this._Load, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this._Cancel, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(514, 76);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// comboBox1
			// 
			this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(3, 3);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(251, 21);
			this.comboBox1.TabIndex = 0;
			// 
			// _Load
			// 
			this._Load.Dock = System.Windows.Forms.DockStyle.Fill;
			this._Load.Location = new System.Drawing.Point(3, 41);
			this._Load.Name = "_Load";
			this._Load.Size = new System.Drawing.Size(251, 32);
			this._Load.TabIndex = 1;
			this._Load.Text = "Load";
			this._Load.UseVisualStyleBackColor = true;
			this._Load.Click += new System.EventHandler(this._Load_Click);
			// 
			// _Cancel
			// 
			this._Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._Cancel.Location = new System.Drawing.Point(260, 41);
			this._Cancel.Name = "_Cancel";
			this._Cancel.Size = new System.Drawing.Size(251, 32);
			this._Cancel.TabIndex = 2;
			this._Cancel.Text = "Cancel";
			this._Cancel.UseVisualStyleBackColor = true;
			this._Cancel.Click += new System.EventHandler(this._Cancel_Click);
			// 
			// DropboxOpen
			// 
			this.AcceptButton = this._Load;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this._Cancel;
			this.ClientSize = new System.Drawing.Size(514, 76);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "DropboxOpen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "DropboxOpen";
			this.Load += new System.EventHandler(this.DropboxOpen_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button _Load;
		private System.Windows.Forms.Button _Cancel;
	}
}