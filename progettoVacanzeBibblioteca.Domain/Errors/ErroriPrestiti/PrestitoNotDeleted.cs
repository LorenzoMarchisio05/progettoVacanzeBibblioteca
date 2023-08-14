namespace progettoVacanzeBibblioteca.Domain.Errors
{
    public sealed class PrestitoNotDeleted : BaseError
    {
        private PrestitoNotDeleted(long id) : base($"Errore eliminazione prestito {id}")
        {
        }

        public static PrestitoNotDeleted Create(long id) => new PrestitoNotDeleted(id);
    }
}