using System;
using System.Collections.Generic;
using System.Data;
using OneOf;
using System.Data.SqlClient;
using System.Linq;
using progettoVacanzeBibblioteca.Domain.Entities;
using progettoVacanzeBibblioteca.Domain.Errors;
using progettoVacanzeBibblioteca.Domain.Settings;
using progettoVacanzeBibblioteca.Infrastructure.Repositories;
using progettoVacanzeBibblioteca.Infrastructure.Adapters;

namespace progettoVacanzeBibblioteca.Infrastructure.Controllers
{
    
    public class ChartController
    {
        #region QUERY
        /*
         * 1. Il titolo dei 5 libri più letti visualizzando anche il numero di prestiti con un istogramma usando l’oggetto msChart
         * 2. Tutti i dati del/i Libro/i mai letto/i
         * 3. Il/i socio/i che ha/hanno letto il numero maggiore di libri visualizzando anche il numero di prestiti con un istogramma usando l’oggetto msChart
         * 4. Tutti i dati dei soci in ritardo con la restituzione dei libri (oltre 30 giorni)
         * 5. Il numero di libri per autore
         * 6. I libri contenenti una determinata parola chiave
         * 7. I libri di una determinata lingua e/o genere
         * 8. Il numero medio di giorni di prestito per ogni libro
         * 9. I libri attualmente in prestito in ordine di data prestito e titolo
         * 10. Il numero di prestiti per mese e anno 
         */
        
        private static readonly string QUERY_01 = "...";
        
        private static readonly string QUERY_02 = "...";
        
        private static readonly string QUERY_03 = "...";
        
        private static readonly string QUERY_04 = "...";
        
        private static readonly string QUERY_05 = "...";
        
        private static readonly string QUERY_06 = "...";
        
        private static readonly string QUERY_07 = "...";
        
        private static readonly string QUERY_08 = "...";
        
        private static readonly string QUERY_09 = "...";
        
        private static readonly string QUERY_10 = "...";
        
        #endregion
        
        private readonly AdoNetDatabase _database;
        public ChartController()
        {
            _database = AdoNetDatabase.Create(connectionString: GlobalSettings.ConnectionString);
        }

        public OneOf<IReadOnlyList<(string titolo, int prestiti)>, InternalError> fetch5libriPiuLettiConNumeroPrestiti()
        {
            try
            {
                var command = new SqlCommand
                {
                    CommandText = QUERY_01
                };
                var rows = _database.ExecuteQuery(command).Rows;

                var lista = new List<(string titolo, int prestiti)>(rows.Count);

                try
                {
                    foreach (DataRow row in rows)
                    {
                        var titolo = row.ItemArray[0]?.ToString();
                        var prestiti = Convert.ToInt32(row.ItemArray[1]);
                        lista.Add((titolo, prestiti));
                    }
                }
                catch (Exception)
                {
                    return InternalError.Create("Errore conversione dati");
                }
                
                return lista;
            }
            catch (Exception)
            {
                return InternalError.Create("Errore database");
            }
        }
        public OneOf<IReadOnlyList<Libro>, InternalError> fetchLibriMaiLetti()
        {
            try
            {
                var command = new SqlCommand
                {
                    CommandText = QUERY_02
                };
                var dataTable = _database.ExecuteQuery(command);
            
                return LibroAdapter.Adapt(dataTable.Rows).ToList();
            }
            catch (Exception)
            {
                return InternalError.Create("Errore database");
            }
        }

        public OneOf<(Socio socio, int prestiti), InternalError> fetchSocioPiuLibriLettiCoNumeroPrestiti()
        {
            try
            {
                var command = new SqlCommand
                {
                    CommandText = QUERY_03
                };
                var rows = _database.ExecuteQuery(command).Rows;

                if (rows.Count != 1)
                {
                    return InternalError.Create("Errore nessun valore trovato");
                }

                try
                {
                    var socio = SocioAdapter.Adapt(rows[0]);
                    var prestiti = Convert.ToInt32(rows[rows.Count - 1]);

                    return (socio, prestiti);
                }
                catch (Exception)
                {
                    return InternalError.Create("Errore nella conversione dei dati");
                }
            }
            catch (Exception)
            {
                return InternalError.Create("Errore database");
            }
        }

        public OneOf<IReadOnlyList<Socio>, InternalError> fetchSociInRitardoRestituzioneLibri()
        {
            try
            {
                var command = new SqlCommand
                {
                    CommandText = QUERY_04
                };
                var dataTable = _database.ExecuteQuery(command);
            
                return SocioAdapter.Adapt(dataTable.Rows).ToList();
            }
            catch (Exception)
            {
                return InternalError.Create("Errore database");
            }
        }

        public OneOf<IReadOnlyList<(string autore, int libri)>, InternalError> fetchNumeroLibriPerAutore()
        {
            try
            {
                var command = new SqlCommand
                {
                    CommandText = QUERY_05
                };
                var rows = _database.ExecuteQuery(command).Rows;

                var lista = new List<(string autore, int libri)>(rows.Count);

                try
                {
                    foreach (DataRow row in rows)
                    {
                        var autore = row.ItemArray[0]?.ToString();
                        var libri = Convert.ToInt32(row.ItemArray[1]);
                        lista.Add((autore, libri));
                    }
                }
                catch (Exception)
                {
                    return InternalError.Create("Errore conversione dati");
                }
                
                return lista;
            }
            catch (Exception)
            {
                return InternalError.Create("Errore database");
            }
        }

        public OneOf<IReadOnlyList<Libro>, InternalError> fetchLibriPerParolaChiave(string parolaChiave)
        {
            try
            {
                var command = new SqlCommand
                {
                    CommandText = QUERY_06,
                    Parameters = { new SqlParameter("parolaChiave", SqlDbType.VarChar) { Value = parolaChiave} }
                };
                var dataTable = _database.ExecuteQuery(command);
            
                return LibroAdapter.Adapt(dataTable.Rows).ToList();
            }
            catch (Exception)
            {
                return InternalError.Create("Errore database");
            }
        }

        public OneOf<IReadOnlyList<Libro>, InternalError> fetchLibriPerLinguaGenere(string lingua, string genere)
        {
            if (lingua is null && genere is null)
            {
                return InternalError.Create("Nessun parametro per la ricerca (lingua o genere)");
            }
            
            var command = new SqlCommand
            {
                CommandText = QUERY_07
            };

            if (genere is null)
            {
                // ricerca per lingua
                command.CommandText += "WHERE lingua = @lingua";
                command.Parameters.AddWithValue("lingua", lingua);
            }
            else
            {
                // ricerca per genere
                command.CommandText += "WHERE genere = @genere";
                command.Parameters.AddWithValue("genere", genere);
            }
            
            try
            {
                var dataTable = _database.ExecuteQuery(command);
            
                return LibroAdapter.Adapt(dataTable.Rows).ToList();
            }
            catch (Exception)
            {
                return InternalError.Create("Errore database");
            }
        }

        public OneOf<IReadOnlyList<(string titolo, int numeroGiorniMedioPrestito)>, InternalError> fetchNumeroGiorniMedioPrestitoPerLibro()
        {
            try
            {
                var command = new SqlCommand
                {
                    CommandText = QUERY_08
                };
                var rows = _database.ExecuteQuery(command).Rows;

                var lista = new List<(string titolo, int numeroGiorniMedioPrestito)>(rows.Count);

                try
                {
                    foreach (DataRow row in rows)
                    {
                        var titolo = row.ItemArray[0]?.ToString();
                        var numeroGiorniMedioPrestito = Convert.ToInt32(row.ItemArray[1]);
                        lista.Add((titolo, numeroGiorniMedioPrestito));
                    }
                }
                catch (Exception)
                {
                    return InternalError.Create("Errore conversione dati");
                }
                
                return lista;
            }
            catch (Exception)
            {
                return InternalError.Create("Errore database");
            }
        }

        public OneOf<IReadOnlyList<Libro>, InternalError> fetchLibriAttualmenteInPrestitoInOrdineDataPrestitoTitolo()
        {
            try
            {
                var command = new SqlCommand
                {
                    CommandText = QUERY_09
                };
                var dataTable = _database.ExecuteQuery(command);
            
                return LibroAdapter.Adapt(dataTable.Rows).ToList();
            }
            catch (Exception)
            {
                return InternalError.Create("Errore database");
            }
        }

        public OneOf<IReadOnlyList<(string meseAnno, int numeroPrestiti)>, InternalError> fetchNumeroPrestitiPerMeseAnno()
        {
            try
            {
                var command = new SqlCommand
                {
                    CommandText = QUERY_10
                };
                var rows = _database.ExecuteQuery(command).Rows;

                var lista = new List<(string autore, int libri)>(rows.Count);

                try
                {
                    foreach (DataRow row in rows)
                    {
                        var meseAnno = row.ItemArray[0]?.ToString();
                        var numeroPrestiti = Convert.ToInt32(row.ItemArray[1]);
                        lista.Add((meseAnno, numeroPrestiti));
                    }
                }
                catch (Exception)
                {
                    return InternalError.Create("Errore conversione dati");
                }
                
                return lista;
            }
            catch (Exception)
            {
                return InternalError.Create("Errore database");
            }
        }

    }
}