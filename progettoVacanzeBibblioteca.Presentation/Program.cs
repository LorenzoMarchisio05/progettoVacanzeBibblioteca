using progettoVacanzeBibblioteca.Domain.Settings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progettoVacanzeBibblioteca.Presentation
{
    internal static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string DB_FILE = System.IO.Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Database", "DB_BIBLIOTECA.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={DB_FILE};Integrated Security=True;Connect Timeout=30";             
            GlobalSettings.SetConnectionString(connectionString);

            Application.Run(new FrmMain());
        }
    }
}
