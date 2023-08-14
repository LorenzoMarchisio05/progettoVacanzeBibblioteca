using System.Collections.Generic;
using progettoVacanzeBibblioteca.Domain.Entities;

namespace progettoVacanzeBibblioteca.Infrastructure.Interfaces
{
    public interface ISociRepository : IRepository<Socio>
    {
        IEnumerable<Socio> Read();
        Socio Read(long id);
        bool Update(Socio socio);
        bool Delete(long id);
    }
}