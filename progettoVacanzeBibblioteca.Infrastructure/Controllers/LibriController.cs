using System;
using System.Collections.Generic;
using System.Linq;
using OneOf;
using progettoVacanzeBibblioteca.Domain.Entities;
using progettoVacanzeBibblioteca.Domain.Errors;
using progettoVacanzeBibblioteca.Infrastructure.Interfaces;
using progettoVacanzeBibblioteca.Infrastructure.Repositories;

namespace progettoVacanzeBibblioteca.Infrastructure.Controllers
{
    public sealed class LibriController
    {
        private readonly ILibriRepository _libriRepository;

        public LibriController()
        {
            _libriRepository = LibriRepository.Create();
        }

        public OneOf<long, InternalError> AggiungiLibro(Libro libro)
        {
            try
            {
                return _libriRepository.Create(libro);
            }
            catch (Exception ex)
            {
                return InternalError.Create(ex.Message);
            }
        }

        public OneOf<IReadOnlyList<Libro>, InternalError> LeggiLibri()
        {
            try
            {
                return _libriRepository.Read().ToList();
            }
            catch (Exception ex)
            {
                return InternalError.Create(ex.Message);
            }
        }

        public OneOf<Libro, LibroNotFound> CercaLibro(long id)
        {
            var libro = _libriRepository.Read(id);

            if (libro is null)
            {
                return LibroNotFound.Create(id);
            }

            return libro;
        }

        public OneOf<long, InternalError, LibroNotUpdated> ModificaLibro(Libro libro)
        {
            try
            {
                var libroModificato = _libriRepository.Update(libro);

                if (!libroModificato)
                {
                    return LibroNotUpdated.Create(libro);
                }

                return libro.Id;
            }
            catch (Exception ex)
            {
                return InternalError.Create(ex.Message);
            }
        }

        public OneOf<long, InternalError, LibroNotDeleted> EliminaLibro(long id)
        {
            try
            {
                var libroEliminato = _libriRepository.Delete(id);

                if (!libroEliminato)
                {
                    return LibroNotDeleted.Create(id);
                }

                return id;
            }
            catch (Exception ex)
            {
                return InternalError.Create(ex.Message);
            }
        }
    }
}