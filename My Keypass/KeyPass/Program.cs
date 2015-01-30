using KeyPassUserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace KeyPass
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			bool ok;
			System.Threading.Mutex m = new System.Threading.Mutex(true, "YourNameHere", out ok);

			if (!ok)
			{
				MessageBox.Show("Another instance is already running.");
				return;
			}

            if (EventLog.SourceExists("BU---CS503 Final") == false)
            {
                EventLog.CreateEventSource(EventLogManager.Source, "CS 503 Final");
            }
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
			GC.KeepAlive(m);
		}
	}
}
