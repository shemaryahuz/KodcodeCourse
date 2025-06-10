using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Database
{
    internal class BasicConnection
    {
        private string connStr = "server=localhost;username=root;password=;database=classicmodels";
        private MySqlConnection connection;
        public void GetOrdersData()
        {
            try
            {
                connection = new MySqlConnection(connStr);
                connection.Open();
                Console.WriteLine("Connection to MySql Database 'cllasicmodels' succseeded");
                string query = "SELECT * FROM orders";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string status = reader.GetString("status");
                    Console.WriteLine($"Status: {status}");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
