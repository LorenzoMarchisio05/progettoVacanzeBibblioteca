using progettoVacanzeBibblioteca.Domain.Entities;

namespace progettoVacanzeBibblioteca.Domain.Errors
{
    public sealed class SocioNotUpdated : BaseError
    {
        private SocioNotUpdated(Socio socio) : base($"Errore modifica dati socio: {socio}")
        {
        }

        public static SocioNotUpdated Create(Socio socio) =>
            new SocioNotUpdated(socio);
    }
}