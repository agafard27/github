using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication3.Helpers
{
    public class DatabaseHelper
    //Data Source=DESKTOP-NQM32OG;Initial Catalog=CPS_WEB;User ID=sa;Integrated Security=True;

    {
        private string connectionString = "Data Source=DESKTOP-NQM32OG;Initial Catalog=CPS_WEB;User Id=sa;Integrated Security=True;";

        public void AddRecord(int cust_id ,string cust_code, string cust_desc, string cust_adress, string cust_country, string cust_city, string cust_phone, bool cust_status)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Connected to the database successfully");

                    string sql = "INSERT INTO dbo.customer (cust_id ,cust_code, cust_desc, cust_adress, cust_country, cust_city, cust_phone, cust_status) VALUES (@cust_id, @cust_code, @cust_desc, @cust_adress, @cust_country, @cust_city, @cust_phone, @cust_status)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@cust_id", cust_id);
                        command.Parameters.AddWithValue("@cust_code", cust_code);
                        command.Parameters.AddWithValue("@cust_desc", cust_desc);
                        command.Parameters.AddWithValue("@cust_adress", cust_adress);
                        command.Parameters.AddWithValue("@cust_country", cust_country);
                        command.Parameters.AddWithValue("@cust_city", cust_city);
                        command.Parameters.AddWithValue("@cust_phone", cust_phone);
                        command.Parameters.AddWithValue("@cust_status", cust_status);

                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"Rows affected: {rowsAffected}");
                        MessageBox.Show("Data added successfully");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

    }
}
