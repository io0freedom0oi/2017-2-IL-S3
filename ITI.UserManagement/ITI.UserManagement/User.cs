using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.UserManagement
{
    public class User
    {
        string _userName;
        string _password;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public void SetPassword(string password)
        {
            _password = password;
        }

        public bool PasswordMatch(string candidate)
        {
            return candidate == _password;
        }
    }
}
