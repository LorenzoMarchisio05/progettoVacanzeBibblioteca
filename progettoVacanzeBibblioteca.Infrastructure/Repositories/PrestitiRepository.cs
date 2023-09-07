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

        private const string SELECT_LIBRI_AUTORE = @"SELECT Libri.* 
            FROM Libri, Scrivono 
            WHERE Libri.idLibro = Scrivono.idLibro 
                AND Scrivono.idAutore = (SELECT idAutore 
                                         FROM Autori 
                                         WHERE nome = @nome 
                                            AND cognome = @cognome)";
        
        private readonly string SELECT_All = $@"SELECT * 
            FROM {TABLE_NAME};";
        
        private readonly string SELECT_BY_ID = $@"SELECT Libri.* 
            FROM {TABLE_NAME}, Libri
            WHERE Libri.idLibro = {TABLE_NAME}.idPrestito 
                AND idPrestito = @id;";
        
        private readonly string SELECT_BY_ID_SOCIO = $@"SELECT Libri.* 
            FROM {TABLE_NAME}, Libri
            WHERE libri.idLibro = {TABLE_NAME}.idLibro,
                idSocio = @id;";

        private readonly string SELECT_BY_NOMINATIVO_SOCIO = $@"SELECT Libri.* 
            FROM {TABLE_NAME}, Libri
            WHERE libri.idLibro = {TABLE_NAME}.idLibro 
                    AND idSocio = (SELECT idSocio 
                                   FROM Soci
                                    WHERE nome = @nome
                                        AND cognome = @cognome)";

        private readonly string DELETE_BY_ID = $@"DELETE 
            FROM {TABLE_NAME} 
            WHERE idPrestito = @id;";
        
        private readonly string UPDATE_BY_ID = $@"UPDATE {TABLE_NAME}
            SET
                idLibro = @idLibro,
                idSocio = @idSocio,
                dataInizio = @dataInizio,
                dataFine = @dataFine
            WHERE idPrestito = @id;";
        
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
            
            return PrestitiAdapter.Adapt(dataTable.Rows);
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
            
            return PrestitiAdapter.Adapt(dataTable.Rows[0]);
        }

        public IEnumerable<Libro> ReadLibriByParolaChiave(string parolaChiave)
        {
            var command = new SqlCommand
            {
                CommandText = SELECT_LIBRI_AUTORE,
                Parameters =
                {
                    new SqlParameter("parolaChiave", SqlDbType.VarChar) { Value = parolaChiave},
                },
            };

            var dataTable = _database.ExecuteQuery(command);

            return LibroAdapter.Adapt(dataTable.Rows);
        }

        public IEnumerable<Libro> ReadLibriByAutore(string nome, string cognome)
        {
            var command = new SqlCommand
            {
                CommandText = SELECT_LIBRI_AUTORE,
                Parameters =
                {
                    new SqlParameter("nome", SqlDbType.VarChar) { Value = nome},
                    new SqlParameter("cognome", SqlDbType.VarChar) { Value = cognome},
                },
            };

            var dataTable = _database.ExecuteQuery(command);

            return LibroAdapter.Adapt(dataTable.Rows);
        }
        public IEnumerable<Libro> ReadByIdSocio(long id)
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
            
            return LibroAdapter.Adapt(dataTable.Rows);
        }
        public IEnumerable<Libro> ReadByNominativo(string nome, string cognome)
        {
            var command = new SqlCommand
            {
                CommandText = SELECT_BY_NOMINATIVO_SOCIO,
                Parameters =
                {
                    new SqlParameter("nome", SqlDbType.VarChar) { Value = nome},
                    new SqlParameter("cognome", SqlDbType.VarChar) { Value = cognome},
                },
            };

            var dataTable = _database.ExecuteQuery(command);

            return LibroAdapter.Adapt(dataTable.Rows);
        }


        public bool Update(Prestito prestito)
        {
            var command = new SqlCommand
            {
                CommandText = UPDATE_BY_ID,
                Parameters =
                {
                    new SqlParameter("id", SqlDbType.Int) { Value = prestito.Id },
                    new SqlParameter("idLibro", SqlDbType.Int) { Value = prestito.IdLibro },
                    new SqlParameter("idSocio", SqlDbType.Int) { Value = prestito.IdSocio },
                    new SqlParameter("dataInizio", SqlDbType.Date) { Value = prestito.DataInizio },
                    new SqlParameter("dataFine", SqlDbType.Date) { Value = prestito.DataFine },
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