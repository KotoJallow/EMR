using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Login
    {

        private string username;
        private string password;
        private int loginID;

        public Login()
        {

        }

        public Login(string username, string password)
        {
            this.loginID = AutoIncrementValue.authID("loginID", "login");
            this.username = username;
            this.password = password;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int LoginID { get => loginID; }
    }
}
