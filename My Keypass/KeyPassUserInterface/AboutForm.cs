﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyPassUserInterface
{
	public partial class AboutForm : Form
	{
		
		
		public AboutForm()
		{
			InitializeComponent();
			aboutOKButton.Focus();

		}

		private void aboutOKButton_OnClick(object sender, EventArgs e)
		{
			Close();
		}
		
	}
	
}
