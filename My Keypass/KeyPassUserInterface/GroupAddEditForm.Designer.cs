namespace KeyPassUserInterface
{
	partial class GroupAddEditForm
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
			this.label1 = new System.Windows.Forms.Label();
			this._GroupNameText = new System.Windows.Forms.TextBox();
			this._OKButton = new System.Windows.Forms.Button();
			this._CancelButtonButton = new System.Windows.Forms.Button();
			this.Test = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.ColorComboBox = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(417, 43);
			this.label1.TabIndex = 0;
			this.label1.Text = "Group Name:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _GroupNameText
			// 
			this.tableLayoutPanel1.SetColumnSpan(this._GroupNameText, 3);
			this._GroupNameText.Dock = System.Windows.Forms.DockStyle.Fill;
			this._GroupNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._GroupNameText.Location = new System.Drawing.Point(3, 46);
			this._GroupNameText.Name = "_GroupNameText";
			this._GroupNameText.Size = new System.Drawing.Size(417, 22);
			this._GroupNameText.TabIndex = 0;
			// 
			// _OKButton
			// 
			this._OKButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this._OKButton.Location = new System.Drawing.Point(144, 102);
			this._OKButton.Name = "_OKButton";
			this._OKButton.Size = new System.Drawing.Size(135, 38);
			this._OKButton.TabIndex = 1;
			this._OKButton.Text = "OK";
			this._OKButton.UseVisualStyleBackColor = true;
			this._OKButton.Click += new System.EventHandler(this.OnOK);
			// 
			// _CancelButtonButton
			// 
			this._CancelButtonButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._CancelButtonButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this._CancelButtonButton.Location = new System.Drawing.Point(285, 102);
			this._CancelButtonButton.Name = "_CancelButtonButton";
			this._CancelButtonButton.Size = new System.Drawing.Size(135, 38);
			this._CancelButtonButton.TabIndex = 2;
			this._CancelButtonButton.Text = "Cancel";
			this._CancelButtonButton.UseVisualStyleBackColor = true;
			this._CancelButtonButton.Click += new System.EventHandler(this.OnCancel);
			// 
			// Test
			// 
			this.Test.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Test.Location = new System.Drawing.Point(3, 102);
			this.Test.Name = "Test";
			this.Test.Size = new System.Drawing.Size(135, 38);
			this.Test.TabIndex = 3;
			this.Test.Text = "Test";
			this.Test.UseVisualStyleBackColor = true;
			this.Test.Click += new System.EventHandler(this.OnTest);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this._GroupNameText, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this._CancelButtonButton, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.Test, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this._OKButton, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.ColorComboBox, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.30303F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.27972F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.88112F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.30303F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(423, 143);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// ColorComboBox
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.ColorComboBox, 2);
			this.ColorComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ColorComboBox.FormattingEnabled = true;
			this.ColorComboBox.Location = new System.Drawing.Point(144, 75);
			this.ColorComboBox.Name = "ColorComboBox";
			this.ColorComboBox.Size = new System.Drawing.Size(276, 21);
			this.ColorComboBox.TabIndex = 4;
			this.ColorComboBox.SelectionChangeCommitted += new System.EventHandler(this._ColorCombobox_OnSelected);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(135, 27);
			this.label2.TabIndex = 5;
			this.label2.Text = "Font Color:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// GroupAddEditForm
			// 
			this.AcceptButton = this._OKButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this._CancelButtonButton;
			this.ClientSize = new System.Drawing.Size(423, 143);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "GroupAddEditForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Group Properties";
			this.Load += new System.EventHandler(this._OnLoad);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox _GroupNameText;
		private System.Windows.Forms.Button _OKButton;
		private System.Windows.Forms.Button _CancelButtonButton;
		private System.Windows.Forms.Button Test;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ComboBox ColorComboBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ColorDialog colorDialog1;
	}
}