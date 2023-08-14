using progettoVacanzeBibblioteca.Domain.Entities;

namespace progettoVacanzeBibblioteca.Domain.Errors
{
    public sealed class LibroNotUpdated : BaseError
    {
        private LibroNotUpdated(Libro libro) : base($"Errore modifica dati libro: {libro}")
        {
        }

        public static LibroNotUpdated Create(Libro libro) =>
            new LibroNotUpdated(libro);
    }
}