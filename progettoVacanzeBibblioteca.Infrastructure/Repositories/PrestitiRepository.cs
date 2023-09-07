using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using progettoVacanzeBibblioteca.Domain.Entities;
using progettoVacanzeBibblioteca.Domain.Settings;
using progettoVacanzeBibblioteca.Infrastructure.Adapters;
using progettoVacanzeBibblioteca.Infrastructure.Interfaces;

namespace progettoVacanzeBibblioteca.Infrastructure.Repositories
{
    public sealed class PrestitiRepository : IPrestitiRepository
    {
        private readonly AdoNetDatabase _database;
        
        private const string TABLE_NAME = "prestiti";

        private readonly string CONTA_LIBRI_IN_PRESTITO = $@"SELECT idSocio, COUNT(*) 
            FROM {TABLE_NAME}
            WHERE idSocio = @idSocio
            GROUP BY idSocio";

        private readonly string INSERT = $@"INSERT INTO {TABLE_NAME}
            (idLibro, IdSocio)
            VALUES
            (@idLibro, @idSocio);
            SELECT SCOPE_IDENTITY();";

        private const string UPDATE_DISPONIBILE_LIBRO = @"UPDATE Libri 
            SET Disponibile = 0 
            WHERE  idLibro = @idLibro";
        
        private readonly string SELECT_All = $@"SELECT * 
            FROM {TABLE_NAME};";
        
        private readonly string SELECT_BY_ID = $@"SELECT * 
            FROM {TABLE_NAME} 
            WHERE id = @id;";
        
        private readonly string SELECT_BY_ID_SOCIO = $@"SELECT * 
            FROM {TABLE_NAME} 
            WHERE idSocio = @id;";
        
        private readonly string DELETE_BY_ID = $@"DELETE 
            FROM {TABLE_NAME} 
            WHERE id = @id;";
        
        private readonly string UPDATE_BY_ID = $@"UPDATE {TABLE_NAME}
            SET ...
            WHERE id = @id;";
        
        private PrestitiRepository()
        {
            _database = AdoNetDatabase.Create(connectionString: GlobalSettings.ConnectionString);
        }

        public static PrestitiRepository Create() => new PrestitiRepository();

        public int CountBooksBorrowed(long id)
        {
            var command = new SqlCommand
            {
                CommandText = CONTA_LIBRI_IN_PRESTITO,
                Parameters =
                {
                    new SqlParameter("idSocio", SqlDbType.Int) { Value = id },
                },
            };

            var dataTable = _database.ExecuteQuery(command);

            var row = dataTable.Rows[0];

            return (int)(row?.ItemArray.GetValue(1) ?? 0);
        }
        public long Create(Prestito prestito)
        {
            var command = new SqlCommand
            {
                CommandText = INSERT,
                Parameters =
                {
                    new SqlParameter("idLibro", SqlDbType.Int) { Value = prestito.IdLibro },
                    new SqlParameter("idSocio", SqlDbType.Int) { Value = prestito.IdSocio },
                }
            };

            var id = Convert.ToInt64(_database.ExecuteScalar(command) ?? -1);

            command = new SqlCommand()
            {
                CommandText = UPDATE_DISPONIBILE_LIBRO,
                Parameters =
                {
                    new SqlParameter("idLibro", SqlDbType.Int) { Value = prestito.IdLibro }
                }
            };
            
            _database.ExecuteNonQuery(command);
            
            return id;
        }

        public IEnumerable<Prestito> Read()
        {
            var command = new SqlCommand
            {
                CommandText = SELECT_All
            };
            var dataTable = _database.ExecuteQuery(command);
            
            return PrestitoAdapter.Adapt(dataTable.Rows);
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
            
            return PrestitoAdapter.Adapt(dataTable.Rows[0]);
        }
        
        public Prestito ReadByIdSocio(long id)
        {
            var command = new SqlCommand
            {
                CommandText = SELECT_BY_ID_SOCIO,
                Parameters =
                {
                    new SqlParameter("id", SqlDbType.Int) { Value = id},
                },
            };
            
            var dataTable = _database.ExecuteQuery(command);
            
            return PrestitoAdapter.Adapt(dataTable.Rows[0]);
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