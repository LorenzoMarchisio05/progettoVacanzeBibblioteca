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
        private QueryController queryController;
        public FrmDati()
        {
            InitializeComponent();
        }

        private void FrmDati_Load(object sender, EventArgs e)
        {
            queryController = new QueryController();
        }

        private void btnQuery1_Click(object sender, EventArgs e)
        {
            queryController.fetch5libriPiuLettiConNumeroPrestiti()
                .Switch(
                    data => updateDgv(data),
                    errore => MessageBox.Show(errore.ToString())
                );
        }

        private void btnQuery2_Click(object sender, EventArgs e)
        {
            queryController.fetchLibriMaiLetti()
                .Switch(
                    data => updateDgv(data),
                    errore => MessageBox.Show(errore.ToString())
                );
        }

        private void btnQuery3_Click(object sender, EventArgs e)
        {
            queryController.fetchSocioPiuLibriLettiCoNumeroPrestiti()
                .Switch(
                    data => updateDgv(new[] { data }),
                    errore => MessageBox.Show(errore.ToString())
                );
        }

        private void btnQuery4_Click(object sender, EventArgs e)
        {
            queryController.fetchSociInRitardoRestituzioneLibri()
                .Switch(
                    data => updateDgv(data),
                    errore => MessageBox.Show(errore.ToString())
                );
        }

        private void btnQuery5_Click(object sender, EventArgs e)
        {
            queryController.fetchNumeroLibriPerAutore()
                .Switch(
                    data => updateDgv(data),
                    errore => MessageBox.Show(errore.ToString())
                );
        }

        private void btnQuery6_Click(object sender, EventArgs e)
        {
            queryController.fetchLibriPerParolaChiave(Interaction.InputBox("Inserisci parola chiave"))
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

            queryController.fetchLibriPerLinguaGenere(lingua, genere)
                .Switch(
                    data => updateDgv(data),
                    errore => MessageBox.Show(errore.ToString())
                );
        }

        private void btnQuery8_Click(object sender, EventArgs e)
        {
            queryController.fetchNumeroGiorniMedioPrestitoPerLibro()
                .Switch(
                    data => updateDgv(data),
                    errore => MessageBox.Show(errore.ToString())
                );
        }

        private void btnQuery9_Click(object sender, EventArgs e)
        {
            queryController.fetchLibriAttualmenteInPrestitoInOrdineDataPrestitoTitolo()
                .Switch(
                    data => updateDgv(data),
                    errore => MessageBox.Show(errore.ToString())
                );
        }

        private void btnQuery10_Click(object sender, EventArgs e)
        {
            queryController.fetchNumeroPrestitiPerMeseAnno()
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
