using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Fsd.Maciek.Cs.Ex4.Data.SQL
{
    public class Repository<TEntity>
    {
        string _connectionString;

        public Repository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["localDatabase"].ConnectionString;
        }

        public IEnumerable<TEntity> SelectData<TEntity>(string tableName, Func<SqlDataReader, TEntity> mappingFunction)
        {
            List<TEntity> items = new List<TEntity>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand($"Select * from {tableName}", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    items.Add(mappingFunction(reader));
                }
            }

            return items;
        }
    }
}
