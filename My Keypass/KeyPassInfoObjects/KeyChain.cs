using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyPassInfoObjects
{
	[Serializable]
	public class KeyChain
	{
		#region private variables
		private bool _isModified=false;
		private string _Name=String.Empty;
		private List<Group> _groups = new List<Group>();
		#endregion

		#region public calls
		public List<Group> Groups 
		{
			get { return _groups;}
			set { _groups = value; }
		}

		public bool IsModified
		{
			get { return _isModified; }
			set { _isModified = value; }
		}

		public string Name
		{
			get { return _Name; }
			set { _Name = value; }
		}

		#endregion

	}
}
