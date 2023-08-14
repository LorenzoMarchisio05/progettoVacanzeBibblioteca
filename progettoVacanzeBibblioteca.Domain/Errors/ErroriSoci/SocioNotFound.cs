namespace progettoVacanzeBibblioteca.Domain.Errors
{
    public sealed class SocioNotFound : BaseError
    {
        private SocioNotFound(long id) : base($"Socio {id} non trovato")
        {
        }

        public static SocioNotFound Create(long id) => new SocioNotFound(id);
        
    }
}