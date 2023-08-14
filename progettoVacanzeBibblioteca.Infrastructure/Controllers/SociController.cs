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
    public sealed class SociController
    {
        private readonly ISociRepository _sociRepository;

        public SociController()
        {
            _sociRepository = SociRepository.Create();
        }
        
        public OneOf<long, InternalError> AggiungiSocio(Socio socio)
        {
            try
            {
                return _sociRepository.Create(socio);
            }
            catch (Exception ex)
            {
                return InternalError.Create(ex.Message);
            }
        }

        public OneOf<IReadOnlyList<Socio>, InternalError> LeggiSoci()
        {
            try
            {
                return _sociRepository.Read().ToList();
            }
            catch (Exception ex)
            {
                return InternalError.Create(ex.Message);
            }
        }

        public OneOf<Socio, SocioNotFound> CercaSocio(long id)
        {
            var socio = _sociRepository.Read(id);

            if (socio is null)
            {
                return SocioNotFound.Create(id);
            }

            return socio;
        }

        public OneOf<long, InternalError, SocioNotUpdated> ModificaSocio(Socio socio)
        {
            try
            {
                var socioModificato = _sociRepository.Update(socio);

                if (!socioModificato)
                {
                    return SocioNotUpdated.Create(socio);
                }

                return socio.Id;
            }
            catch (Exception ex)
            {
                return InternalError.Create(ex.Message);
            }
        }

        public OneOf<long, InternalError, SocioNotDeleted> EliminaSocio(long id)
        {
            try
            {
                var socioEliminato = _sociRepository.Delete(id);

                if (!socioEliminato)
                {
                    return SocioNotDeleted.Create(id);
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