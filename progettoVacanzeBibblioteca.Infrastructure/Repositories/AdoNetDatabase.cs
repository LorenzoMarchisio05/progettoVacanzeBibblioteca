using System;
using System.Data.SqlClient;
using System.Data;

namespace progettoVacanzeBibblioteca.Infrastructure.Repositories
{
    internal sealed class AdoNetDatabase
    {
        private string _connectionString;

        private AdoNetDatabase(string connectionString)
        {
            _connectionString = connectionString;
        }

        public static AdoNetDatabase Create(string connectionString) => 
            new AdoNetDatabase(connectionString);
        
        public DataTable ExecuteQuery(SqlCommand command)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                command.Connection = connection;
                
                var dataTable = new DataTable();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
        
        public int ExecuteNonQuery(SqlCommand command)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                command.Connection = connection;
                return command.ExecuteNonQuery();
            }
        }
        
        public object ExecuteScalar(SqlCommand command)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                command.Connection = connection;
                return command.ExecuteScalar();
            }
        }
        
    }
}