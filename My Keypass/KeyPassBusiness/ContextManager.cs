using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyPassInfoObjects;

namespace KeyPassBusiness
{
	[Serializable]
	public static class ContextManager
	{

		#region Group interface
		public static event GroupSelectedEvent GroupSelected;
	   
		public static void invokeGroupSelected()
		{
				GroupSelected(ContextManager._selectedGroup);
		}

		private static Group _selectedGroup;

		public static Group SelectedGroup
		{
			get { return _selectedGroup; }
			set { _selectedGroup = value; }
		}

		#endregion

		#region Key interface


		public static event KeySelectedEvent KeySelected;

		public static void invokeKeySelected()
		{
			KeySelected(ContextManager._singularKey);
		}

		private static Key _singularKey;

		public static Key SingularKey
		{
			get { return _singularKey; }
			set { _singularKey = value; }
		}


		public static event KeysCurrentlySelectedEvent CheckKeys;

		public static void invokeKeysCurrentlySelected()
		{
			CheckKeys(ContextManager._currentKeySelection, ContextManager.SelectedGroup.Keys.Count);
		}

		private static int _currentKeySelection;

		public static int CurrentKeySelection
		{
			get { return _currentKeySelection; }
			set { _currentKeySelection = value; }
		}
		
	

		
	

		#endregion
	
	}
}

