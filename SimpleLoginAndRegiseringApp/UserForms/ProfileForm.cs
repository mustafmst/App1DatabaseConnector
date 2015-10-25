using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App1DatabaseConnector.LoginFunctionality;
using App1DatabaseConnector;

namespace SimpleLoginAndRegiseringApp.UserForms
{
    public partial class ProfileForm : Form
    {
        private readonly ConnectionBuilder conn;
        public ProfileForm(ConnectionBuilder connection)
        {
            InitializeComponent();
            conn = connection;
            this.Text = UserData.Login;
        }

        private void deleteProfileButton_Click(object sender, EventArgs e)
        {
            DeleteProfile();
            this.Dispose();
        }

        private void DeleteProfile()
        {
            UserData.UserDataInstance.DeleteProfile(conn);
        }

        private void Logout()
        {

        } 
    }
}
