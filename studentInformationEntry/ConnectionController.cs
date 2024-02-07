using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using System.Data;

namespace studentInformationEntry
{
    public static class ConnectionController
    {
        public static string connectionString { get; set; }
        public static SqlConnection connection { get; set; }

        public static void NonQuery(string statement)
        {
            using (connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(statement, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static int GetLastID(string statement)
        {
            int rv = 0;
            using (connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(statement, connection);
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    if (reader.GetInt32(0) > rv)
                    {
                        rv = reader.GetInt32(0);
                    }
                }

                reader.Close();
            }
            return rv;
        }  // Ending bracket of method GetLastID
    }  // Ending bracket of class ConnectionController
}  // 
