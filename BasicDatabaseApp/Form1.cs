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

namespace BasicDatabaseApp
{
    public partial class Form1 : Form
    {
        private ConnectionBuilder conn;

        public Form1()
        {
            InitializeComponent();
            closeConnButton.Enabled = false;
            conn = new ConnectionBuilder(false);
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if(!conn.Server(serverBox.Text)
                .Port(portBox.Text)
                .Database(databaseBox.Text)
                .User(userBox.Text)
                .Password(passwordBox.Text)
                .OpenConnection())
            {
                MessageBox.Show("Could not connect to database!");
                return;
            }
            ChangeEnableState(true);
        }

        private void executeButton_Click(object sender, EventArgs e)
        {

            if (statmentBox.Text.ToLower().Contains("select"))
            {
                DataSet data = conn.ExecuteSelectSQL(statmentBox.Text);
                ShowDataFromDataSet(data);
            }
            else if (statmentBox.Text.ToLower().Contains("insert"))
            {
                conn.ExecuteInsertSQL(statmentBox.Text);
            }
        }

        private void ShowDataFromDataSet(DataSet data)
        {
            DataTable table = data.Tables[0];
            dataGridView.DataSource = table;
        }

        private void closeConnButton_Click(object sender, EventArgs e)
        {
            conn.CloseConnection();
            ChangeEnableState(false);
        }

        private void ChangeEnableState(bool connectionState)
        {
            executeButton.Enabled = connectionState;
            closeConnButton.Enabled = connectionState;
            connectButton.Enabled = !connectionState;
            serverBox.Enabled = !connectionState;
            portBox.Enabled = !connectionState;
            userBox.Enabled = !connectionState;
            passwordBox.Enabled = !connectionState;
            databaseBox.Enabled = !connectionState;
        }
    }
}
