using Microsoft.VisualBasic;
using progettoVacanzeBibblioteca.Infrastructure.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace progettoVacanzeBibblioteca.Presentation
{
    public partial class FrmDati : Form
    {
        private QueryController _queryController;
        private ChartController _chartController;
        public FrmDati()
        {
            InitializeComponent();
        }

        private void FrmDati_Load(object sender, EventArgs e)
        {
            _queryController = new QueryController();
            _chartController = new ChartController(chart);
        }

        private void btnQuery1_Click(object sender, EventArgs e)
        {
            _queryController.fetch5libriPiuLettiConNumeroPrestiti()
                .Switch(
                    data =>
                    {
                        updateDgv(data);
                        _chartController.MostraNumeroPrestiti();
                    },
                    errore => MessageBox.Show(errore.ToString())
                );
        }

        private void btnQuery2_Click(object sender, EventArgs e)
        {
            _queryController.fetchLibriMaiLetti()
                .Switch(
                    data => updateDgv(data),
                    errore => MessageBox.Show(errore.ToString())
                );
        }

        private void btnQuery3_Click(object sender, EventArgs e)
        {
            _queryController.fetchSocioPiuLibriLettiCoNumeroPrestiti()
                .Switch(
                    data =>
                    {
                        updateDgv(new[] { data });
                        _chartController.MostraNumeroPrestiti();
                    },
                    errore => MessageBox.Show(errore.ToString())
                );
        }

        private void btnQuery4_Click(object sender, EventArgs e)
        {
            _queryController.fetchSociInRitardoRestituzioneLibri()
                .Switch(
                    data => updateDgv(data),
                    errore => MessageBox.Show(errore.ToString())
                );
        }

        private void btnQuery5_Click(object sender, EventArgs e)
        {
            _queryController.fetchNumeroLibriPerAutore()
                .Switch(
                    data => updateDgv(data),
                    errore => MessageBox.Show(errore.ToString())
                );
        }

        private void btnQuery6_Click(object sender, EventArgs e)
        {
            _queryController.fetchLibriPerParolaChiave(Interaction.InputBox("Inserisci parola chiave"))
                .Switch(
                    data => updateDgv(data),
                    errore => MessageBox.Show(errore.ToString())
                );
        }

        private void btnQuery7_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("ricerca per lingua o genere? (si -> lingua, no -> genere)", "Tipo ricerca", MessageBoxButtons.YesNoCancel);
            
            if(result == DialogResult.Cancel)
            {
                return;
            }

            string lingua = null, 
                   genere = null;

            if(result == DialogResult.Yes)
            {
                lingua = Interaction.InputBox("Inserisci lingua");
            }
            else
            {
                genere = Interaction.InputBox("Inserisci genere");
            }

            _queryController.fetchLibriPerLinguaGenere(lingua, genere)
                .Switch(
                    data => updateDgv(data),
                    errore => MessageBox.Show(errore.ToString())
                );
        }

        private void btnQuery8_Click(object sender, EventArgs e)
        {
            _queryController.fetchNumeroGiorniMedioPrestitoPerLibro()
                .Switch(
                    data => updateDgv(data),
                    errore => MessageBox.Show(errore.ToString())
                );
        }

        private void btnQuery9_Click(object sender, EventArgs e)
        {
            _queryController.fetchLibriAttualmenteInPrestitoInOrdineDataPrestitoTitolo()
                .Switch(
                    data => updateDgv(data),
                    errore => MessageBox.Show(errore.ToString())
                );
        }

        private void btnQuery10_Click(object sender, EventArgs e)
        {
            _queryController.fetchNumeroPrestitiPerMeseAnno()
                .Switch(
                    data => updateDgv(data),
                    errore => MessageBox.Show(errore.ToString())
                );
        }

        private void updateDgv<T>(IEnumerable<T> data)
        {
            dgv.DataSource = null;
            dgv.DataSource = data;
        }
    }
}
