namespace KeyPassUserInterface
{
	partial class ClockControl
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
			this.clockLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// clockLabel
			// 
			this.clockLabel.AutoSize = true;
			this.clockLabel.BackColor = System.Drawing.SystemColors.Highlight;
			this.clockLabel.Dock = System.Windows.Forms.DockStyle.Left;
			this.clockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clockLabel.Location = new System.Drawing.Point(0, 0);
			this.clockLabel.Name = "clockLabel";
			this.clockLabel.Size = new System.Drawing.Size(97, 16);
			this.clockLabel.TabIndex = 0;
			this.clockLabel.Text = "Date and Time";
			this.clockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ClockControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.Controls.Add(this.clockLabel);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "ClockControl";
			this.Size = new System.Drawing.Size(153, 85);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label clockLabel;
	}
}
