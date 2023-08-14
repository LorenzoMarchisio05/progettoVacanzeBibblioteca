using System;

namespace progettoVacanzeBibblioteca.Domain.Entities
{
    public sealed class Prestito
    {
        public long Id { get; }
        
        public long IdLibro { get; }

        public long IdSocio { get; }

        public DateTime DataInizio { get; }
        
        public DateTime? DataFine { get; }

        public Prestito(long id, long idLibro, long idSocio, DateTime dataInizio, DateTime? dataFine)
        {
            Id = id;
            IdLibro = idLibro;
            IdSocio = idSocio;
            DataInizio = dataInizio;
            DataFine = dataFine;
        }

        public override string ToString() => 
            $"{nameof(Id)}:{Id} " +
            $"{nameof(IdLibro)}:{IdLibro} " +
            $"{nameof(IdSocio)}:{IdSocio} " +
            $"{nameof(DataInizio)}:{DataInizio} " +
            $"{nameof(DataFine)}:{DataFine}";
    }
}