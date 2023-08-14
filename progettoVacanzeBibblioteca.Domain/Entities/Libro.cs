namespace progettoVacanzeBibblioteca.Domain.Entities
{
    public sealed class Libro
    {
        public long Id { get; }
        
        public string Titolo { get; }
        
        public uint AnnoPubblicazione { get; }
        
        public string Lingua { get; }
        
        public bool Disponibile { get; }
        
        public long IdGenere { get; }

        public Libro(long id, string titolo, uint annoPubblicazione, string lingua, bool disponibile, long idGenere)
        {
            Id = id;
            Titolo = titolo;
            AnnoPubblicazione = annoPubblicazione;
            Lingua = lingua;
            Disponibile = disponibile;
            IdGenere = idGenere;
        }

        public override string ToString() => 
            $"{nameof(Id)}:{Id} " +
            $"{nameof(Titolo)}:{Titolo} " +
            $"{nameof(AnnoPubblicazione)}:{AnnoPubblicazione} " +
            $"{nameof(Lingua)}:{Lingua} " +
            $"{nameof(Disponibile)}:{Disponibile} " +
            $"{nameof(IdGenere)}:{IdGenere}";
    }
}