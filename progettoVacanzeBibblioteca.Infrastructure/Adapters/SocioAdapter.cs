using System;
using System.Collections.Generic;
using System.Data;
using progettoVacanzeBibblioteca.Domain.Entities;

namespace progettoVacanzeBibblioteca.Infrastructure.Adapters
{
    public static class SocioAdapter
    {
        public static IEnumerable<Socio> Adapt(DataRowCollection rows)
        {
            var soci = new Socio[rows.Count];
            var i = 0;
            
            foreach (DataRow row in rows)
            {
                soci[i] = Adapt(row);
                i++;
            }
            
            return soci;
        }

        public static Socio Adapt(DataRow row)
        {
            var id = Convert.ToInt64(row[0]);
            var nome = row[1].ToString();
            var cognome = row[2].ToString();
            var numeroTelefono = PhoneNumber.From(row[3].ToString());
            var email = Email.From(row[4].ToString());

            return new Socio(id, nome, cognome, numeroTelefono, email);
        }
    }
}