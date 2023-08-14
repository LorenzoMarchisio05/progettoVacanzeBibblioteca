using progettoVacanzeBibblioteca.Domain.Settings;
using progettoVacanzeBibblioteca.Infrastructure.Repositories;

namespace progettoVacanzeBibblioteca.Infrastructure.Controllers
{
    public sealed class QueryController
    {
        private readonly AdoNetDatabase _database;
        
        public QueryController()
        {
            _database = AdoNetDatabase.Create(connectionString: GlobalSettings.ConnectionString);
        }
    }
}