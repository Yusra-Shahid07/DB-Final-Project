using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace DBFinalProject
{
    public class SQL_Helper
    {
        private static string connectionString = "Server = localhost; Database = pp; User ID = root; Password = aliza_Jaan5;";

        public static void ExecuteQuery(string insertQuery)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public static int ExecuteNonQuery(string query)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                int rows = cmd.ExecuteNonQuery();
                return rows;
            }
        }

        public static DataTable view(string selectQuery)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand selectCmd = new MySqlCommand(selectQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectCmd);
            DataTable resultTable = new DataTable();
            adapter.Fill(resultTable);
            connection.Close();
            return resultTable;
        }
        public static object ExecuteScalor(string scalarQuery)
        {
            object result = null;
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(scalarQuery, connection);
                result = cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            connection.Close();
            return result;
        }
    }
}
