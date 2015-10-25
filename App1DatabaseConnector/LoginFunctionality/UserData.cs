using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1DatabaseConnector.LoginFunctionality
{
    public class UserData
    {
        private static UserData _userDataInstance;
        private string _login;
        private UserData(){}

        public static UserData UserDataInstance
        {
            get
            {
                if (_userDataInstance == null)
                {
                    _userDataInstance = new UserData();
                }
                return _userDataInstance;
            }
        }

        public static string Login
        {
            get
            {
                return UserDataInstance._login;
            }
        }

        public void SetUserLogin(string login)
        {
            UserDataInstance._login = login;
        }

        public void ClearUserData()
        {
            _userDataInstance = new UserData();
        }

        public void DeleteProfile(ConnectionBuilder connection)
        {
            string statment = string.Format("delete from users where login = '{0}';", Login);
            try
            {
                connection.ExecuteDeleteSQL(statment);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
