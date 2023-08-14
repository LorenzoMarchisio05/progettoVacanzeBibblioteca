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
    public sealed class PrestitiController
    {
        private readonly IPrestitiRepository _prestitiRepository;

        public PrestitiController()
        {
            _prestitiRepository = PrestitiRepository.Create();
        }
        

        public OneOf<long, InternalError> AggiungiPrestito(Prestito prestito)
        {
            try
            {
                return _prestitiRepository.Create(prestito);
            }
            catch (Exception ex)
            {
                return InternalError.Create(ex.Message);
            }
        }

        public OneOf<IReadOnlyList<Prestito>, InternalError> LeggiPrestiti()
        {
            try
            {
                return _prestitiRepository.Read().ToList();
            }
            catch (Exception ex)
            {
                return InternalError.Create(ex.Message);
            }
        }

        public OneOf<Prestito, PresitoNotFound> CercaPrestito(long id)
        {
            var prestito = _prestitiRepository.Read(id);

            if (prestito is null)
            {
                return PresitoNotFound.Create(id);
            }

            return prestito;
        }

        public OneOf<long, InternalError, PrestitoNotUpdated> ModificaPrestito(Prestito prestito)
        {
            try
            {
                var prestitoModificato = _prestitiRepository.Update(prestito);

                if (!prestitoModificato)
                {
                    return PrestitoNotUpdated.Create(prestito);
                }

                return prestito.Id;
            }
            catch (Exception ex)
            {
                return InternalError.Create(ex.Message);
            }
        }

        public OneOf<long, InternalError, PrestitoNotDeleted> EliminaPrestito(long id)
        {
            try
            {
                var prestitoEliminato = _prestitiRepository.Delete(id);

                if (!prestitoEliminato)
                {
                    return PrestitoNotDeleted.Create(id);
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