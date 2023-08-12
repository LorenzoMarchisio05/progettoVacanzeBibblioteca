using System;
using System.Data.SqlClient;
using System.Data;

namespace progettoVacanzeBibblioteca.Infrastructure.Repositories
{
    internal class AdoNetDatabase
    {
        private string connectionString;

        public AdoNetDatabase(string connectionString)
        {
            this.connectionString = connectionString;
        }
        
        public DataTable ExecuteQuery(SqlCommand command)
        {
            using (var connection = new SqlConnection(connectionString))
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
            using (var connection = new SqlConnection(connectionString))
            {
                command.Connection = connection;
                
                return command.ExecuteNonQuery();
            }
        }
        
        public int ExecuteScalar(SqlCommand command)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                command.Connection = connection;
                return (int)(command.ExecuteScalar() ?? 0);
            }
        }
        
    }
}