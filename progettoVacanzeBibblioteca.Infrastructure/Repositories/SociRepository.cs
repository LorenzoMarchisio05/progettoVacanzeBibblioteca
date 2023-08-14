using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using progettoVacanzeBibblioteca.Domain.Entities;
using progettoVacanzeBibblioteca.Infrastructure.Interfaces;

namespace progettoVacanzeBibblioteca.Infrastructure.Repositories
{
    public sealed class SociRepository : ISociRepository
    {
        private readonly AdoNetDatabase _database;

        private const string TABLE_NAME = "soci";

        private readonly string SELECT_All = $@"SELECT * 
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
        
        private SociRepository()
        {
            _database = AdoNetDatabase.Create(connectionString: null);
        }

        public static SociRepository Create() => new SociRepository();

        public long Create(Socio socio)
        {
            return 0l;
        }

        public IEnumerable<Socio> Read()
        {
            var command = new SqlCommand
            {
                CommandText = SELECT_All
            };
            var dataTable = _database.ExecuteQuery(command);
            
            return null;
        }

        public Socio Read(long id)
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

        public bool Update(Socio socio)
        {
            var command = new SqlCommand
            {
                CommandText = DELETE_BY_ID,
                Parameters =
                {
                    new SqlParameter("id", SqlDbType.Int) { Value = socio.Id },
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