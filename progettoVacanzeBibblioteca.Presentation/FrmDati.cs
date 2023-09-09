using Microsoft.VisualBasic;
using progettoVacanzeBibblioteca.Domain.Entities;
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

        /*
         * 1. Il titolo dei 5 libri più letti visualizzando anche il numero di prestiti con un istogramma usando l’oggetto msChart
         * 2. Tutti i dati del/i Libro/i mai letto/i
         * 3. Il/i socio/i che ha/hanno letto il numero maggiore di libri visualizzando anche il numero di prestiti con un istogramma usando l’oggetto msChart
         * 4. Tutti i dati dei soci in ritardo con la restituzione dei libri (oltre 30 giorni)
         * 5. Il numero di libri per autore
         * 6. I libri contenenti una determinata parola chiave
         * 7. I libri di una determinata lingua e/o genere
         * 8. Il numero medio di giorni di prestito per ogni libro
         * 9. I libri attualmente in prestito in ordine di data prestito e titolo
         * 10. Il numero di prestiti per mese e anno 
         */

        private void btnQuery1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il titolo dei 5 libri più letti visualizzando anche il numero di prestiti con un istogramma usando l’oggetto msChart");
            _queryController.fetch5libriPiuLettiConNumeroPrestiti()
                .Switch(
                    data =>
                    {
                        updateDgv(data.Select(tuple => new TupleDTO(tuple.titolo, tuple.prestiti)).ToArray());
                        _chartController.MostraNumeroPrestiti();
                    },
                    errore => MessageBox.Show(errore.ToString())
                );
        }

        private void btnQuery2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tutti i dati del/i Libro/i mai letto/i");
            _queryController.fetchLibriMaiLetti()
                .Switch(
                    data => updateDgv(data),
                    errore => MessageBox.Show(errore.ToString())
                );
        }

        private void btnQuery3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il/i socio/i che ha/hanno letto il numero maggiore di libri visualizzando anche il numero di prestiti con un istogramma usando l’oggetto msChart");
            _queryController.fetchSocioPiuLibriLettiCoNumeroPrestiti()
                .Switch(
                    data =>
                    {
                        updateDgv(data);
                        _chartController.MostraNumeroPrestiti();
                    },
                    errore => MessageBox.Show(errore.ToString())
                );
        }

        private void btnQuery4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tutti i dati dei soci in ritardo con la restituzione dei libri (oltre 30 giorni)");
            _queryController.fetchSociInRitardoRestituzioneLibri()
                .Switch(
                    data => updateDgv(data),
                    errore => MessageBox.Show(errore.ToString())
                );
        }

        private void btnQuery5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il numero di libri per autore");
            _queryController.fetchNumeroLibriPerAutore()
                .Switch(
                    data => updateDgv(data.Select(tuple => new TupleDTO(tuple.autore, tuple.libri)).ToArray()),
                    errore => MessageBox.Show(errore.ToString())
                );
        }

        private void btnQuery6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I libri contenenti una determinata parola chiave");
            _queryController.fetchLibriPerParolaChiave(Interaction.InputBox("Inserisci parola chiave"))
                .Switch(
                    data => updateDgv(data),
                    errore => MessageBox.Show(errore.ToString())
                );
        }

        private void btnQuery7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" I libri di una determinata lingua e/o genere");
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
            MessageBox.Show("Il numero medio di giorni di prestito per ogni libro");
            _queryController.fetchNumeroGiorniMedioPrestitoPerLibro()
                .Switch(
                    data => updateDgv(data.Select(tuple => new TupleDTO(tuple.titolo, tuple.numeroGiorniMedioPrestito)).ToArray()),
                    errore => MessageBox.Show(errore.ToString())
                );
        }

        private void btnQuery9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I libri attualmente in prestito in ordine di data prestito e titolo");
            _queryController.fetchLibriAttualmenteInPrestitoInOrdineDataPrestitoTitolo()
                .Switch(
                    data => updateDgv(data.Select(tuple => new TupleDTO(tuple.titolo, tuple.data)).ToArray()),
                    errore => MessageBox.Show(errore.ToString())
                );
        }

        private void btnQuery10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il numero di prestiti per mese e anno");
            _queryController.fetchNumeroPrestitiPerMeseAnno()
                .Switch(
                    data => updateDgv(data.Select(tuple => new TupleDTO(tuple.meseAnno, tuple.numeroPrestiti)).ToArray()),
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
