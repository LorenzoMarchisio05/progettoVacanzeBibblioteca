using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using progettoVacanzeBibblioteca.Domain.Entities;
using progettoVacanzeBibblioteca.Infrastructure.Interfaces;

namespace progettoVacanzeBibblioteca.Infrastructure.Repositories
{
    public sealed class PrestitiRepository : IPrestitiRepository
    {
        private readonly AdoNetDatabase _database;
        
        private const string TABLE_NAME = "prestiti";
        
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
        
        private PrestitiRepository()
        {
            _database = AdoNetDatabase.Create(connectionString: null);
        }

        public static PrestitiRepository Create() => new PrestitiRepository();
        
        public long Create(Prestito prestito)
        {
            return 0l;
        }

        public IEnumerable<Prestito> Read()
        {
            var command = new SqlCommand
            {
                CommandText = SELECT_All
            };
            var dataTable = _database.ExecuteQuery(command);
            
            return null;
        }

        public Prestito Read(long id)
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

        public bool Update(Prestito prestito)
        {
            var command = new SqlCommand
            {
                CommandText = DELETE_BY_ID,
                Parameters =
                {
                    new SqlParameter("id", SqlDbType.Int) { Value = prestito.Id },
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