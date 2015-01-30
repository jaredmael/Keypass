using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KeyPassInfoObjects
{
	[Serializable]
	public class Group
	{
		private string _GroupName = string.Empty;
		private List<Key> _keys = new List<Key>();
		private int[] _textColor = {0,255,255,255};
		private string _colorname;





		public string ColorName
		{
			get { return _colorname; }
			set { _colorname = value; }
		}
		


		public int[] TextColor
		{
			get { return _textColor; }
			set { _textColor = value; }
		}
		
		public string Name
		{
			get { return _GroupName; }
			set { _GroupName = value; }
		}


		public List<Key> Keys
		{
			get { return _keys; }
			set { _keys = value; }
		}


		public  bool EditKey(Key k, Key edit)
		{
			foreach (Key g in Keys)
			{
				if (g == k)

				{
					Key select = g;
					select.Title = edit.Title;
					select.Username = edit.Username;
					select.Password = edit.Password;
					select.ConfirmPassword = edit.ConfirmPassword;
					select.URL= edit.URL;
					select.Note = edit.Note;
				}
			}
			return true;
		}

	}

}
