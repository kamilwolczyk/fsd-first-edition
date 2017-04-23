using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Fsd.Cs.Web.Infractructure
{
    public class Database
    {
        class Store
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public const string ConnectionStringName = "localhost-fsd.kamil";

        public static void ConnectByReader()
        {
            var connectionString = ConfigurationManager.ConnectionStrings[ConnectionStringName].ConnectionString;
            var items = new List<Store>();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select * from stores", connection);
                //command.Parameters.AddWithValue("@name", "e");
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                    items.Add(new Store
                    {
                        Id = int.Parse((string)reader["stor_id"]),
                        Name = (string)reader["stor_name"],
                    });
                
            }
        }
    }
}