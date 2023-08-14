using progettoVacanzeBibblioteca.Domain.Settings;
using progettoVacanzeBibblioteca.Infrastructure.Repositories;

namespace progettoVacanzeBibblioteca.Infrastructure.Controllers
{
    public class ChartController
    {
        private readonly AdoNetDatabase _database;
        
        public ChartController()
        {
            _database = AdoNetDatabase.Create(connectionString: GlobalSettings.ConnectionString);
        }
    }
}