using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using progettoVacanzeBibblioteca.Domain.Entities;
using progettoVacanzeBibblioteca.Domain.Settings;
using progettoVacanzeBibblioteca.Infrastructure.Adapters;
using progettoVacanzeBibblioteca.Infrastructure.Interfaces;

namespace progettoVacanzeBibblioteca.Infrastructure.Repositories
{
    public sealed class LibriRepository : ILibriRepository
    {
        private readonly AdoNetDatabase _database;
        
        private const string TABLE_NAME = "libri";
        
        private readonly string SELECT_All = $@"SELECT * 
            FROM {TABLE_NAME};";

        private readonly string INSERT = $@"INSERT INTO {TABLE_NAME}
            (titolo, annoPubblicazione, lingua, disponibile, idGenere)
            VALUES 
            (@titolo, @annoPubblicazione, @lingua, @disponibile, @idGenere);
            SELECT SCOPE_IDENTITY();";
        
        private readonly string SELECT_BY_ID = $@"SELECT * 
            FROM {TABLE_NAME} 
            WHERE id = @id;";
        
        private readonly string DELETE_BY_ID = $@"DELETE 
            FROM {TABLE_NAME} 
            WHERE idLibro = @id;";
        
        private readonly string UPDATE_BY_ID = $@"UPDATE {TABLE_NAME}
            SET 
                titolo = @titolo,
                annoPubblicazione = @annoPubblicazione,
                lingua = @lingua,
                disponibile = @disponibile,
                idGenere = @idGenere
            WHERE idLibro = @id;";
        
        private LibriRepository()
        {
            _database = AdoNetDatabase.Create(connectionString: GlobalSettings.ConnectionString);
        }

        public static LibriRepository Create() => new LibriRepository();

        public long Create(Libro libro)
        {
            var command = new SqlCommand
            {
                CommandText = INSERT,
                Parameters =
                {
                    new SqlParameter("titolo", SqlDbType.VarChar) { Value = libro.Titolo },
                    new SqlParameter("annoPubblicazione", SqlDbType.Int) { Value = libro.AnnoPubblicazione },
                    new SqlParameter("lingua", SqlDbType.VarChar) { Value = libro.Lingua },
                    new SqlParameter("disponibile", SqlDbType.Bit) { Value = libro.Disponibile ? 1 : 0 },
                    new SqlParameter("idGenere", SqlDbType.Int) { Value = libro.IdGenere },
                },
            };

            return (long)(_database.ExecuteScalar(command) ?? -1);
        }

        public IEnumerable<Libro> Read()
        {
            var command = new SqlCommand
            {
                CommandText = SELECT_All
            };
            var dataTable = _database.ExecuteQuery(command);
            
            return LibroAdapter.Adapt(dataTable.Rows);
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
            
            return LibroAdapter.Adapt(dataTable.Rows[0]);
        }

        public bool Update(Libro libro)
        {
            var command = new SqlCommand
            {
                CommandText = UPDATE_BY_ID,
                Parameters =
                {
                    new SqlParameter("id", SqlDbType.Int) { Value = libro.Id },
                    new SqlParameter("titolo", SqlDbType.VarChar) { Value = libro.Titolo },
                    new SqlParameter("annoPubblicazione", SqlDbType.VarChar) { Value = libro.AnnoPubblicazione },
                    new SqlParameter("lingua", SqlDbType.VarChar) { Value = libro.Lingua },
                    new SqlParameter("disponibile", SqlDbType.Bit) { Value = libro.Disponibile ? 1 : 0 },
                    new SqlParameter("idGenere", SqlDbType.Int) { Value = libro.IdGenere },
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