using System;
using System.Collections.Generic;
using System.Data;
using progettoVacanzeBibblioteca.Domain.Entities;

namespace progettoVacanzeBibblioteca.Infrastructure.Adapters
{
    public class LibroAdapter
    {
        public static IEnumerable<Libro> Adapt(DataRowCollection rows)
        {
            var libri = new Libro[rows.Count];
            var i = 0;
            
            foreach (DataRow row in rows)
            {
                libri[i] = Adapt(row);
                i++;
            }
            
            return libri;
        }

        public static Libro Adapt(DataRow row)
        {
            var id = Convert.ToInt64(row[0]);
            var titolo = row[1].ToString();
            var annoPubblicazione = Convert.ToUInt32(row[2]);
            var lingua = row[3].ToString();
            var disponibile = Convert.ToBoolean(row[4]);
            var idGenere = Convert.ToInt64(row[5]);

            return new Libro(id, titolo, annoPubblicazione, lingua, disponibile, idGenere);
        }
    }
}