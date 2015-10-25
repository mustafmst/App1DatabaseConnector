using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleLoginAndRegiseringApp.UserForms;
using App1DatabaseConnector;

namespace SimpleLoginAndRegiseringApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void CreateNewProfileWindow(ConnectionBuilder connection)
        {
            new ProfileForm(connection).Show();
        }
    }
}
