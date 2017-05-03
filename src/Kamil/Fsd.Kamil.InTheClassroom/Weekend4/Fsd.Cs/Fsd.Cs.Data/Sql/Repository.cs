using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Fsd.Cs.Data.Sql
{
    public class Repository<TEntity>
    {
        private string _tableName;
        private Func<SqlDataReader, TEntity> _mappingFunction;
        private string _idColumnName;
        private string _connectionString;

        public Repository(string tableName, string idColumnName, Func<SqlDataReader, TEntity> mappingFunction)
        {
            _tableName = tableName;
            _idColumnName = idColumnName;
            _mappingFunction = mappingFunction;
            _connectionString = ConfigurationManager.ConnectionStrings["localDatabase"].ConnectionString;
        }

        public IEnumerable<TEntity> GetAllData()
        {
            List<TEntity> items = new List<TEntity>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand($"Select * from {_tableName}", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                    items.Add(_mappingFunction(reader));
            }

            return items;
        }

        public TEntity GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand($"Select * from {_tableName} where { _idColumnName }=@id", connection);
                command.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                    return _mappingFunction(reader);

                return default(TEntity);
            }
        }
    }
}
