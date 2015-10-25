using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App1DatabaseConnector;
using App1DatabaseConnector.LoginFunctionality;
using SimpleLoginAndRegiseringApp.UserForms;

namespace SimpleLoginAndRegiseringApp
{
    public partial class Form1 : Form
    {
        ConnectionBuilder conn;
        LoginDelegate userDelegate;
        
        public Form1()
        {
            InitializeComponent();
            conn = new ConnectionBuilder(true);
            conn.OpenConnection();
            userDelegate = new LoginDelegate(conn);

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            string hashedPasswordInDatbase;
            try
            {
                hashedPasswordInDatbase = userDelegate.GetHashedPasswordForUser(textBox1.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Login!");
                return;
            }
            if (VerifyPassword(hashedPasswordInDatbase))
            {
                UserData.UserDataInstance.SetUserLogin(textBox1.Text.Trim());
                Program.CreateNewProfileWindow(conn);
                this.Dispose();
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                userDelegate.RegisterNewUser(textBox1.Text.Trim(), textBox2.Text.Trim());
            }
            catch(Exception)
            {
                MessageBox.Show("Failed to regiter!");
            }
        }

        private bool VerifyPassword(string passwordFromDatabase)
        {
            string pass = userDelegate.GetHashedPasswordFromString(textBox2.Text.Trim());
            if (pass.Equals(passwordFromDatabase)) return true;
            return false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString() == "\r")
            {
                Login();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                Login();
            }

        }
    }
}
