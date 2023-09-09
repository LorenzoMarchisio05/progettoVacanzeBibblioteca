using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using progettoVacanzeBibblioteca.Domain.Entities;
using progettoVacanzeBibblioteca.Domain.Settings;
using progettoVacanzeBibblioteca.Infrastructure.Adapters;
using progettoVacanzeBibblioteca.Infrastructure.Interfaces;

namespace progettoVacanzeBibblioteca.Infrastructure.Repositories
{
    public sealed class SociRepository : ISociRepository
    {
        private readonly AdoNetDatabase _database;

        private const string TABLE_NAME = "soci";

        private readonly string SELECT_All = $@"SELECT * 
            FROM {TABLE_NAME};";

        private readonly string INSERT = $@"INSERT INTO {TABLE_NAME} 
            (cognome, nome, telefono, email) 
            VALUES 
            (@cognome, @nome, @telefono, @email); 
            SELECT SCOPE_IDENTITY();";
        
        private readonly string SELECT_BY_ID = $@"SELECT * 
            FROM {TABLE_NAME} 
            WHERE idSocio = @id;";
        
        private readonly string DELETE_BY_ID = $@"DELETE 
            FROM {TABLE_NAME} 
            WHERE idSocio = @id;";
        
        private readonly string UPDATE_BY_ID = $@"UPDATE {TABLE_NAME} 
            SET 
                cognome = @cognome,
                nome = @nome,
                telefono = @telefono,
                email = @email
            WHERE idSocio = @id;";
        
        private SociRepository()
        {
            _database = AdoNetDatabase.Create(connectionString: GlobalSettings.ConnectionString);
        }

        public static SociRepository Create() => new SociRepository();

        public long Create(Socio socio)
        {
            var command = new SqlCommand
            {
                CommandText = INSERT,
                Parameters =
                {
                    new SqlParameter("cognome", SqlDbType.VarChar) { Value = socio.Cognome },
                    new SqlParameter("nome", SqlDbType.VarChar) { Value = socio.Nome },
                    new SqlParameter("telefono", SqlDbType.VarChar) { Value = socio.Telefono.ToString() },
                    new SqlParameter("email", SqlDbType.VarChar) { Value = socio.Email.ToString() },
                },
            };

            return Convert.ToInt64(_database.ExecuteScalar(command) ?? -1);
        }

        public IEnumerable<Socio> Read()
        {
            var command = new SqlCommand
            {
                CommandText = SELECT_All
            };
            var dataTable = _database.ExecuteQuery(command);
            
            return SocioAdapter.Adapt(dataTable.Rows);
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
            
            return SocioAdapter.Adapt(dataTable.Rows[0]);
        }

        public bool Update(Socio socio)
        {
            var command = new SqlCommand
            {
                CommandText = UPDATE_BY_ID,
                Parameters =
                {
                    new SqlParameter("id", SqlDbType.Int) { Value = socio.Id },
                    new SqlParameter("cognome", SqlDbType.VarChar) { Value = socio.Cognome },
                    new SqlParameter("nome", SqlDbType.VarChar) { Value = socio.Nome },
                    new SqlParameter("telefono", SqlDbType.VarChar) { Value = socio.Telefono.ToString() },
                    new SqlParameter("email", SqlDbType.VarChar) { Value = socio.Email.ToString() },
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

            return _database.ExecuteNonQuery(command) != 1;
        }

    }
}