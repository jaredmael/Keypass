using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyPassInfoObjects;
using System.Xml;



namespace KeyPassBusiness
{
	public static class KeyChainManager
	{
		#region private Items
		private static KeyChain _keyChain = new KeyChain();
		#endregion

		#region public Interface
			#region Group Interface


		
		public static bool AddGroup(Group n)
		{
			_keyChain.Groups.Add(n);
			return true;

		}

		public static Group EditGroup(Group n, Group edit)
		{
			Group h = FindGroup(n);
			h.Name = edit.Name;
			h.TextColor = edit.TextColor;
			h.ColorName = edit.ColorName;
			return h;
			}
			
		public static bool DeleteGroup(Group n)
		{
			Group h=FindGroup(n);
			_keyChain.Groups.Remove(h);
			return true;
		}


		public static Group FindGroup(Group g)
		{
			Group found = _keyChain.Groups.Find(z => z == g);
			if (found!=null)
			{
				return found;
			}
			return null;
		}
	#endregion
		
			#region Key Interface

		public static bool AddKey(Group g, Key k)
		{
			Group target = FindGroup(g);
			g.Keys.Add(k);
			return true;
		}


		public static Group Find(Key key)
		{
			foreach (Group g in _keyChain.Groups)
			{
				Key k = g.Keys.Find(s => s == key);
				if (k != null)
					return g;
			}
			return null;
		}


		public static bool EditKey(Group g, Key k)
		{

			if (g != ContextManager.SelectedGroup)
			{
				KeyChainManager.DeleteKey(ContextManager.SelectedGroup,KeyChainManager.FindKey(ContextManager.SelectedGroup, ContextManager.SingularKey));
				g.Keys.Add(k);
				ContextManager.SingularKey=null;
			}

			if (ContextManager.SelectedGroup == g)
			{
					Key KeytoChange = FindKey(FindGroup(ContextManager.SelectedGroup), ContextManager.SingularKey);
					KeytoChange.Title = k.Title;
					KeytoChange.Username = k.Username;
					KeytoChange.Password = k.Password;
					KeytoChange.ConfirmPassword = k.ConfirmPassword;
					KeytoChange.URL = k.URL;
					KeytoChange.Note = k.Note;
				}
		 return true;
		}

	


		public static Key FindKey(Group g, Key k)
		{
			Key found = g.Keys.Find(l => l == k);
			if (found != null)
			{
				return found;
			}
			return null;
		}


		public static bool DeleteKey(Group group, Key key)
		{
			Group g = FindGroup(group);
			if (g == null)
				return false;

			g.Keys.Remove(key);

			return true;
		}

		#endregion

			#region Other User Interface

		public static KeyChain KeyChain
		{

			get { return _keyChain; }
			set { _keyChain = value; }
		}
		public static bool isModified
		{
			get { return _keyChain.IsModified; }
		}

		public static void newKeyChain()
		{
			_keyChain = new KeyChain();
		}

		public static string isNamed
		{
			get{ return _keyChain.Name;}
			set { _keyChain.Name = value; }
		}

			#endregion
		#endregion
        
      public static event FontSelectedEvent SelectedFont;

      public static void invokeSelectedFont(string f, int s)
      {
		  if (SelectedFont != null)
		  {
			  SelectedFont(f, s);
		  }
      }
	}
}
