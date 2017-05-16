using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARMS
{
    public class User
    {
        private string _Username;
        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }
        private string _Password;
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        public User(string username, string password)
        {
            _Username = username;
            _Password = password;
        }
    }
}
