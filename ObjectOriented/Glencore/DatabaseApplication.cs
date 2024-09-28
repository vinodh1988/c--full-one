using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented.Glencore
{
    internal class DatabaseApplication
    {

        private static string
              connectionString =
              "Server=localhost\\SQLEXPRESS;Database=glencore;User Id=sa;Password=sqlserver;";

        public static void PrintPersonTable()
        {
            // 1. Establishing the Connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection to SQL Server established successfully.");

                    CreatePerson(connection,5, "Manish", "Mumbai");
                    string query = "select * from People";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"ID: {reader["Sno"]}, Name: {reader["Name"]}, City: {reader["City"]}");
                        }
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            static void CreatePerson(SqlConnection connection, int Sno,string Name,String City)
            {
                string query = "INSERT INTO People (Sno, Name, City) VALUES (@Sno, @Name, @City)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Sno", Sno);
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@City", City);

                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} row(s) inserted.");
                }
            }
        }
    }
}
