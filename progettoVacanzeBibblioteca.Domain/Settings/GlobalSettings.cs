using System.Net;
using System.Runtime.CompilerServices;

namespace progettoVacanzeBibblioteca.Domain.Settings
{
    public static class GlobalSettings
    {
        public static string ConnectionString { get; private set; } = null;

        public static void SetConnectionString(string connectionString)
        {
            if(ConnectionString is null)
            {
                ConnectionString = connectionString;
            }
        }
    }
}