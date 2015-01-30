using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyPassUserInterface
{
	public partial class ClockControl : UserControl
	{
		private Timer clock = new Timer();
		public ClockControl()
		{
			InitializeComponent();
			clock.Interval= 1000;
			clock.Tick += clock_Tick;
			clock.Start();

		}
		void clock_Tick(object sender, EventArgs e)
		{
			clockLabel.Text = DateTime.Now.ToString();
		}
	}
}
