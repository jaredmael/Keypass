namespace KeyPassUserInterface
{
	partial class StatusStripControl
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this._historyComboBox = new System.Windows.Forms.ComboBox();
			this.XOfYSelectedLbl = new System.Windows.Forms.Label();
			this.groupsLbl = new System.Windows.Forms.Label();
			this.clockControl1 = new KeyPassUserInterface.ClockControl();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.Controls.Add(this._historyComboBox, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.XOfYSelectedLbl, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupsLbl, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.clockControl1, 3, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(948, 31);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// _historyComboBox
			// 
			this._historyComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._historyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._historyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._historyComboBox.FormattingEnabled = true;
			this._historyComboBox.Location = new System.Drawing.Point(3, 3);
			this._historyComboBox.Name = "_historyComboBox";
			this._historyComboBox.Size = new System.Drawing.Size(373, 24);
			this._historyComboBox.TabIndex = 0;
			// 
			// XOfYSelectedLbl
			// 
			this.XOfYSelectedLbl.AutoSize = true;
			this.XOfYSelectedLbl.Dock = System.Windows.Forms.DockStyle.Left;
			this.XOfYSelectedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.XOfYSelectedLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.XOfYSelectedLbl.Location = new System.Drawing.Point(571, 0);
			this.XOfYSelectedLbl.Name = "XOfYSelectedLbl";
			this.XOfYSelectedLbl.Size = new System.Drawing.Size(108, 31);
			this.XOfYSelectedLbl.TabIndex = 1;
			this.XOfYSelectedLbl.Text = "0 of 0 Keys Selected ";
			this.XOfYSelectedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupsLbl
			// 
			this.groupsLbl.AutoSize = true;
			this.groupsLbl.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupsLbl.Location = new System.Drawing.Point(382, 0);
			this.groupsLbl.Name = "groupsLbl";
			this.groupsLbl.Size = new System.Drawing.Size(80, 31);
			this.groupsLbl.TabIndex = 2;
			this.groupsLbl.Text = "Total Groups: 0";
			this.groupsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// clockControl1
			// 
			this.clockControl1.BackColor = System.Drawing.SystemColors.Highlight;
			this.clockControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.clockControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clockControl1.Location = new System.Drawing.Point(760, 8);
			this.clockControl1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
			this.clockControl1.Name = "clockControl1";
			this.clockControl1.Size = new System.Drawing.Size(185, 23);
			this.clockControl1.TabIndex = 3;
			// 
			// StatusStripControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "StatusStripControl";
			this.Size = new System.Drawing.Size(948, 31);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ComboBox _historyComboBox;
		private System.Windows.Forms.Label XOfYSelectedLbl;
		private System.Windows.Forms.Label groupsLbl;
		private ClockControl clockControl1;
	}
}
