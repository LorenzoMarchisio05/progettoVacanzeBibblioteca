using progettoVacanzeBibblioteca.Domain.Entities;

namespace progettoVacanzeBibblioteca.Domain.Errors
{
    public sealed class LibroNotFound : BaseError
    {
        private LibroNotFound(long id) : base($"Libro {id} non trovato")
        {
        }

        public static LibroNotFound Create(long id) => new LibroNotFound(id);
    }
}