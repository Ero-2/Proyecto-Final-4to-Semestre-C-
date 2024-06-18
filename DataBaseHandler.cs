using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PROYECTO_RIOJAS
{
    internal class DataBaseHandler
    {
        private readonly string connectionString;

        public DataBaseHandler(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<YourDataClass> GetAllData()
        {
            List<YourDataClass> data = new List<YourDataClass>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM YourTable";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Fill the YourDataClass object with data from the reader
                    YourDataClass item = new YourDataClass
                    {
                        // Property1 = reader["Column1"].ToString(),
                        // Property2 = Convert.ToInt32(reader["Column2"]),
                        // etc.
                    };
                    data.Add(item);
                }
            }
            return data;
        }

        public void InsertData(YourDataClass data)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO YourTable (Column1, Column2, etc) VALUES (@value1, @value2, etc)";
                SqlCommand command = new SqlCommand(query, connection);
                // command.Parameters.AddWithValue("@value1", data.Property1);
                // command.Parameters.AddWithValue("@value2", data.Property2);
                // etc.
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Similarly, create methods for UpdateData and DeleteData

    }
}
