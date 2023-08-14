namespace progettoVacanzeBibblioteca.Domain.Errors
{
    public sealed class LibroNotDeleted : BaseError
    {
        internal LibroNotDeleted(long id) : base($"Errore eliminazione libro {id}")
        {
        }

        public static LibroNotDeleted Create(long id) => new LibroNotDeleted(id);
    }
}