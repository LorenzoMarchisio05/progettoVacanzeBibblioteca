using System;
using System.Collections.Generic;
using System.Data;
using progettoVacanzeBibblioteca.Domain.Entities;

namespace progettoVacanzeBibblioteca.Infrastructure.Adapters
{
    public class PrestitoAdapter
    {
        public static IEnumerable<Prestito> Adapt(DataRowCollection rows)
        {
            var prestiti = new Prestito[rows.Count];
            var i = 0;
            
            foreach (DataRow row in rows)
            {
                prestiti[i] = Adapt(row);
                i++;
            }
            
            return prestiti;
        }

        public static Prestito Adapt(DataRow row)
        {
            var id = Convert.ToInt64(row[0]);
            var idLibro = Convert.ToInt64(row[1]);
            var idSocio = Convert.ToInt64(row[2]);
            var dataInizio = Convert.ToDateTime(row[3]);
            DateTime? dataFine = null;
            if (!(row[4] is null))
            {
                dataFine = Convert.ToDateTime(row[4]);
            }

            return new Prestito(id, idLibro, idSocio, dataInizio, dataFine);
        }
    }
}