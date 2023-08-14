namespace progettoVacanzeBibblioteca.Domain.Errors
{
    public sealed class SocioNotDeleted : BaseError
    {
        private SocioNotDeleted(long id) : base($"Errore eliminazione socio {id}")
        {
        }

        public static SocioNotDeleted Create(long id) => new SocioNotDeleted(id);
    }
}