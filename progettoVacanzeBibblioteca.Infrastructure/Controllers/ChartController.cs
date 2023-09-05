using System.Windows.Forms.DataVisualization.Charting;

namespace progettoVacanzeBibblioteca.Infrastructure.Controllers
{
    
    public class ChartController
    {
        private readonly Chart _chart;
        public ChartController(Chart chart)
        {
            _chart = chart;
        }
    }
}