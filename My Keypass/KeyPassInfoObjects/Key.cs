using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyPassInfoObjects
{
	[Serializable]
    public class Key
    {
        private string _title = String.Empty;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }


        private string _username = String.Empty;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        private string _password=String.Empty;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        private string _confirmPassword=String.Empty;

        public string ConfirmPassword
        {
            get { return _confirmPassword; }
            set { _confirmPassword = value; }
        }


        private string _url=String.Empty;

        public string URL
        {
            get { return _url; }
            set { _url = value; }
        }

        private string _note=String.Empty;

        public string Note
        {
            get { return _note; }
            set { _note = value; }
        }

    }
    

}
