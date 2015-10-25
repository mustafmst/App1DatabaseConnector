using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1DatabaseConnector.LoginFunctionality
{
    public class LoginDelegate
    {
        private ConnectionBuilder _conn;
        public LoginDelegate(ConnectionBuilder connectionBuilder)
        {
            _conn = connectionBuilder;
        }

        public string GetHashedPasswordForUser(string login)
        {
            string statment = string.Format("select password from users where login='{0}';", login);
            DataSet data = _conn.ExecuteSelectSQL(statment);
            string hashedPasswordInDatbase;
            try
            {
                hashedPasswordInDatbase = data.Tables[0].Rows[0]["password"].ToString();
                return hashedPasswordInDatbase;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string GetHashedPasswordFromString(string password)
        {
            try
            {
                var statment = string.Format("select * from MD5('{0}');", password);
                var data = _conn.ExecuteSelectSQL(statment);
                return data.Tables[0].Rows[0]["md5"].ToString();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public void RegisterNewUser(string login, string password)
        {
            try
            {
                string statment = string.Format("insert into users(login,password) values('{0}',MD5('{1}'))", login, password);
                _conn.ExecuteInsertSQL(statment);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
