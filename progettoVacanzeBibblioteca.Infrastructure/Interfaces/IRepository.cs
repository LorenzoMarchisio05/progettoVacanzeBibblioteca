using System.Collections.Generic;

namespace progettoVacanzeBibblioteca.Infrastructure.Interfaces
{
    public interface IRepository<T>
    {
        long Create(T data);
        IEnumerable<T> Read();
        T Read(long id);
        bool Update(T data);
        bool Delete(long id);
    }
}