using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyPassBusiness;
using System.Diagnostics;



namespace KeyPassUserInterface
{
	public partial class StatusStripControl : UserControl
	{
		public StatusStripControl()
		{
			InitializeComponent();
		}

		public void NumberOfGroups(int i)
		{
			string groupsinKeyChain = String.Format("Total Groups: {0}", i.ToString());
			groupsLbl.Text = groupsinKeyChain;
		}

		public void StatusBarSelectedKeys(int i, int j)
		{
			string keysPicked = String.Format("{0} of {1} Keys Selected", i.ToString(), j.ToString());
			XOfYSelectedLbl.Text = (keysPicked);
		}



		public void StatusBarComboboxUpdate(string action, string editedObject, int KorG)
		{
			String addToHistory = String.Empty;
			if (KorG == 1)
			{
				addToHistory = String.Format(" {0}: {1} Key in Group:{2} - {3}", DateTime.Now, action, ContextManager.SelectedGroup.Name, editedObject);
				//above line works except if Change group that Key is added to when editing
			}



			else
			{
				addToHistory = String.Format("{0}: {1} Group {2}", DateTime.Now, action, editedObject);
			}
			_historyComboBox.Items.Add(addToHistory);
			_historyComboBox.SelectedItem = addToHistory;

			EventLog.WriteEntry(EventLogManager.Source, addToHistory);
		}

		public void StatusBarComboboxClear()
		{
			_historyComboBox.Items.Clear();
		}


	}


	
	
	
}
