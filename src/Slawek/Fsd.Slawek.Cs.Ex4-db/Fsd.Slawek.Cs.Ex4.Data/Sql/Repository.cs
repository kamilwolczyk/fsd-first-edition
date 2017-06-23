using Fsd.Slawek.Cs.Ex4.Data.Enums;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Fsd.Slawek.Cs.Ex4.Data.Entities;

namespace Fsd.Slawek.Cs.Ex4.Data.Sql
{
    public class Repository<TEntity>
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["localDatabase"].ConnectionString;

        public IEnumerable<TEntity> SelectData(Func<SqlDataReader, TEntity> mappingFunction)
        {
            var x = typeof(TEntity).Name.ToString();

            List<TEntity> items = new List<TEntity>();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"Select * from {x}", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                    items.Add(mappingFunction(reader));
            }
            return items;
        }

        public TEntity SelectItem(int id, Func<SqlDataReader, TEntity> mappingFunction)
        {
            var x = typeof(TEntity).Name;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"Select * from {x} where Id = {id}", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                   return mappingFunction(reader);
            }
            return default(TEntity);
        }

        
    }
}
