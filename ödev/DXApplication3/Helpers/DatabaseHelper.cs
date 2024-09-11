using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json; // Install Newtonsoft.Json via NuGet
using DXApplication3.Models;
using System.Security.Policy;
using DevExpress.XtraPrinting.Native.Properties;

namespace DXApplication3.Helpers
{
    public class DatabaseHelper
    {

        private static readonly HttpClient client = new HttpClient();


        //private string connectionString = "Data Source=DESKTOP-USG4TN3;Initial Catalog=CPS_WEB;Integrated Security=True;";

        public async void AddRecord(int cust_id ,string cust_code, string cust_desc, string cust_adress, string cust_country, string cust_city, string cust_phone, bool cust_status)
        {

            // MessageBox.Show("here");

            try
            {

                var newRecord = new Customer
                {
                    cust_id = cust_id,
                    cust_code = cust_code,
                    cust_adress = cust_adress,
                    cust_city = cust_city,
                    cust_county = cust_country,
                    cust_desc = cust_desc,
                    cust_phone = cust_phone,
                    cust_status = cust_status

                };
                var json = JsonConvert.SerializeObject(newRecord);

                // MessageBox.Show(json);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("http://localhost:5002/api/Customer", content);

                // MessageBox.Show("response is:" + response);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Record added successfully!");
                }
                else
                {
                    MessageBox.Show("Error: " + response.ReasonPhrase);
                }
            }

            catch (Exception ex) {

                MessageBox.Show("An error occurred: " + ex.Message);

            }

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    try
            //    {
            //        connection.Open();
            //        MessageBox.Show("Connected to the database successfully");

            //        string sql = "INSERT INTO dbo.customer (cust_id ,cust_code, cust_desc, cust_adress, cust_country, cust_city, cust_phone, cust_status) VALUES (@cust_id, @cust_code, @cust_desc, @cust_adress, @cust_country, @cust_city, @cust_phone, @cust_status)";

            //        using (SqlCommand command = new SqlCommand(sql, connection))
            //        {
            //            command.Parameters.AddWithValue("@cust_id", cust_id);
            //            command.Parameters.AddWithValue("@cust_code", cust_code);
            //            command.Parameters.AddWithValue("@cust_desc", cust_desc);
            //            command.Parameters.AddWithValue("@cust_adress", cust_adress);
            //            command.Parameters.AddWithValue("@cust_country", cust_country);
            //            command.Parameters.AddWithValue("@cust_city", cust_city);
            //            command.Parameters.AddWithValue("@cust_phone", cust_phone);
            //            command.Parameters.AddWithValue("@cust_status", cust_status);

            //            int rowsAffected = command.ExecuteNonQuery();
            //            Console.WriteLine($"Rows affected: {rowsAffected}");
            //            MessageBox.Show("Data added successfully");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("An error occurred: " + ex.Message);
            //        Console.WriteLine("Error: " + ex.Message);
            //    }
            //}
        }

        public async void deleteCustomer(int del_cust_id)
        {

            string baseUrl = "http://localhost:5002/api/Customer/";

            string url = $"{baseUrl}{del_cust_id}";

            HttpResponseMessage response = await client.DeleteAsync(url);
        }

        public async void AddWarehouse(string ware_code, string ware_desc, bool ware_status)
        {
            try
            {
                var newRecord = new Warehouse
                {
                    ware_id = 1,
                    ware_code = ware_code,
                    ware_desc = ware_desc,
                    ware_status = ware_status
                };

                var json = JsonConvert.SerializeObject(newRecord);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("http://localhost:5002/api/Warehouse", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Record added successfully!");
                }
                else
                {
                    MessageBox.Show("Error: " + response.ReasonPhrase);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }
    }
}
