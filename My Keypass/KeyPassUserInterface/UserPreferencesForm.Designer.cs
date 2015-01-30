namespace KeyPassUserInterface
{
    partial class UserPreferencesForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.FontComboBox = new System.Windows.Forms.ComboBox();
			this.FontSizeComboBox = new System.Windows.Forms.ComboBox();
			this._OK = new System.Windows.Forms.Button();
			this._Cancel = new System.Windows.Forms.Button();
			this.HideTaskbarCheckBox = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.FontComboBox, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.FontSizeComboBox, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this._OK, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this._Cancel, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.HideTaskbarCheckBox, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.66667F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(385, 121);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(186, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Font";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(186, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "Font Size";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// FontComboBox
			// 
			this.FontComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FontComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.FontComboBox.FormattingEnabled = true;
			this.FontComboBox.Location = new System.Drawing.Point(195, 3);
			this.FontComboBox.Name = "FontComboBox";
			this.FontComboBox.Size = new System.Drawing.Size(187, 21);
			this.FontComboBox.TabIndex = 2;
			// 
			// FontSizeComboBox
			// 
			this.FontSizeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FontSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.FontSizeComboBox.FormattingEnabled = true;
			this.FontSizeComboBox.Location = new System.Drawing.Point(195, 35);
			this.FontSizeComboBox.Name = "FontSizeComboBox";
			this.FontSizeComboBox.Size = new System.Drawing.Size(187, 21);
			this.FontSizeComboBox.TabIndex = 3;
			// 
			// _OK
			// 
			this._OK.Dock = System.Windows.Forms.DockStyle.Fill;
			this._OK.Location = new System.Drawing.Point(3, 91);
			this._OK.Name = "_OK";
			this._OK.Size = new System.Drawing.Size(186, 27);
			this._OK.TabIndex = 4;
			this._OK.Text = "OK";
			this._OK.UseVisualStyleBackColor = true;
			this._OK.Click += new System.EventHandler(this._OnOK);
			// 
			// _Cancel
			// 
			this._Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._Cancel.Location = new System.Drawing.Point(195, 91);
			this._Cancel.Name = "_Cancel";
			this._Cancel.Size = new System.Drawing.Size(187, 27);
			this._Cancel.TabIndex = 5;
			this._Cancel.Text = "Cancel";
			this._Cancel.UseVisualStyleBackColor = true;
			this._Cancel.Click += new System.EventHandler(this._Cancel_Click);
			// 
			// HideTaskbarCheckBox
			// 
			this.HideTaskbarCheckBox.AutoSize = true;
			this.HideTaskbarCheckBox.Location = new System.Drawing.Point(3, 67);
			this.HideTaskbarCheckBox.Name = "HideTaskbarCheckBox";
			this.HideTaskbarCheckBox.Size = new System.Drawing.Size(143, 17);
			this.HideTaskbarCheckBox.TabIndex = 6;
			this.HideTaskbarCheckBox.Text = "Hide Program in Taskbar";
			this.HideTaskbarCheckBox.UseVisualStyleBackColor = true;
			this.HideTaskbarCheckBox.CheckedChanged += new System.EventHandler(this._OnCheckChanged);
			// 
			// UserPreferencesForm
			// 
			this.AcceptButton = this._OK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this._Cancel;
			this.ClientSize = new System.Drawing.Size(385, 121);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UserPreferencesForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "UserPreferencesForm";
			this.Load += new System.EventHandler(this.UserPreferencesForm_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FontComboBox;
        private System.Windows.Forms.ComboBox FontSizeComboBox;
        private System.Windows.Forms.Button _OK;
        private System.Windows.Forms.Button _Cancel;
		private System.Windows.Forms.CheckBox HideTaskbarCheckBox;
    }
}