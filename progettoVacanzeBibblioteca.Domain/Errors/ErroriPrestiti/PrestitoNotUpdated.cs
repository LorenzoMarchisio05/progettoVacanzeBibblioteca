using progettoVacanzeBibblioteca.Domain.Entities;

namespace progettoVacanzeBibblioteca.Domain.Errors
{
    public sealed class PrestitoNotUpdated : BaseError
    {
        private PrestitoNotUpdated(Prestito prestito) : base($"Errore modifica dati prestito: {prestito}")
        {
        }

        public static PrestitoNotUpdated Create(Prestito prestito) =>
            new PrestitoNotUpdated(prestito);
    }
}