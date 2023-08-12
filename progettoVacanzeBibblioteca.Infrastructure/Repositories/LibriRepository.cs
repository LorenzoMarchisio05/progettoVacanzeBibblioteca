using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using progettoVacanzeBibblioteca.Domain.Entities;

namespace progettoVacanzeBibblioteca.Infrastructure.Repositories
{
    public class LibriRepository
    {
        private readonly AdoNetDatabase _database;
        
        private const string TABLE_NAME = "libri";
        
        public long Id { get; } private readonly string SELECT_All = $@"SELECT * 
            FROM {TABLE_NAME};";
        
        private readonly string SELECT_BY_ID = $@"SELECT * 
            FROM {TABLE_NAME} 
            WHERE id = @id;";
        
        private readonly string DELETE_BY_ID = $@"DELETE 
            FROM {TABLE_NAME} 
            WHERE id = @id;";
        
        private readonly string UPDATE_BY_ID = $@"UPDATE {TABLE_NAME}
            SET ...
            WHERE id = @id;";
        
        public LibriRepository()
        {
            _database = new AdoNetDatabase(null);
        }

        public IEnumerable<Libro> Read()
        {
            var command = new SqlCommand
            {
                CommandText = SELECT_All
            };
            var dataTable = _database.ExecuteQuery(command);
            
            return null;
        }

        public Libro Read(long id)
        {
            var command = new SqlCommand
            {
                CommandText = SELECT_BY_ID,
                Parameters =
                {
                    new SqlParameter("id", SqlDbType.Int) { Value = id},
                },
            };
            
            var dataTable = _database.ExecuteQuery(command);
            
            return null;
        }

        public bool Update(Libro libro)
        {
            var command = new SqlCommand
            {
                CommandText = DELETE_BY_ID,
                Parameters =
                {
                    new SqlParameter("id", SqlDbType.Int) { Value = libro.Id },
                },
            };

            return _database.ExecuteNonQuery(command) != 0;
        }
        
        public bool Delete(long id)
        {
            var command = new SqlCommand
            {
                CommandText = DELETE_BY_ID,
                Parameters =
                {
                    new SqlParameter("id", SqlDbType.Int) { Value = id },
                },
            };

            return _database.ExecuteNonQuery(command) != 0;
        }
    }
}