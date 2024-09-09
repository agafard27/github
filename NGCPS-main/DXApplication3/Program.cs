using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DXApplication3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Optional: Set up skin settings for DevExpress
            UserLookAndFeel.Default.SetSkinStyle("The Bezier");

            // Check database connection
            if (TestDatabaseConnection())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show("Failed to connect to the database. The application will exit.");
            }
        }

        private static bool TestDatabaseConnection()
        {
            string connectionString = "Data Source=DESKTOP-USG4TN3;Initial Catalog=CPS_WEB;Integrated Security=True;";

            string database = "CPS_WEB";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Optionally, perform a simple query to test the connection
                    // using (SqlCommand command = new SqlCommand("SELECT 1", connection))
                    // {
                    //     command.ExecuteScalar();
                    // }
                    MessageBox.Show("Connected to the Database " + database + " securely.");
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database connection error: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
