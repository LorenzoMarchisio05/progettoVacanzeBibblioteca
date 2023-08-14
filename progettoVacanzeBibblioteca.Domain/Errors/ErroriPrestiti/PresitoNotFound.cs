namespace progettoVacanzeBibblioteca.Domain.Errors
{
    public sealed class PresitoNotFound : BaseError
    {
        private PresitoNotFound(long id) : base($"Prestito {id} non trovato")
        {
        }

        public static PresitoNotFound Create(long id) => new PresitoNotFound(id);
    }
}