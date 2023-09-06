using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using progettoVacanzeBibblioteca.Domain.Settings;
using progettoVacanzeBibblioteca.Infrastructure.Repositories;

namespace progettoVacanzeBibblioteca.Infrastructure.Controllers
{
    
    public class ChartController
    {
        private readonly AdoNetDatabase _database = AdoNetDatabase.Create(GlobalSettings.ConnectionString);
        private readonly Chart _chart;
        
        private const string query = @"SELECT COUNT(*), Libri.Titolo
                FROM Libri, Prestiti 
                WHERE Libri.idLibro = Prestiti.idLibro
                GROUP BY Prestiti.idLibro, Libri.Titolo
                ORDER BY COUNT(*)";
        public ChartController(Chart chart)
        {
            _chart = chart;
            _chart.ChartAreas.Add(new ChartArea());
            chart.Legends.Add(new Legend
            {
                Title = "Graphs"
            });
        }

        public void MostraNumeroPrestiti()
        {
            _chart.Series.Clear();
            
            var series = new Series("TitoloNumeroPrestiti")
            {
                ChartType = SeriesChartType.Spline,
                Color = Color.Blue,
                IsValueShownAsLabel = true,
                IsVisibleInLegend = true,
            };
            
            var command = new SqlCommand
            {
                CommandText = query,
            };

            var dataTable = _database.ExecuteQuery(command);
            
            foreach (DataRow row in dataTable.Rows)
            {
                var prestito = Convert.ToInt32(row.ItemArray.GetValue(0));
                var titolo = row.ItemArray.GetValue(1).ToString();
                
                series.Points.Add(new DataPoint
                {
                    Name = titolo,
                    AxisLabel = titolo,
                    XValue = prestito,
                });
            }
            
            _chart.Series.Add(series);
        }
        
    }
}