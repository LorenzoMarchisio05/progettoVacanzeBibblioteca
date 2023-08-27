using progettoVacanzeBibblioteca.Domain.Entities;
using progettoVacanzeBibblioteca.Infrastructure.Controllers;
using progettoVacanzeBibblioteca.Infrastructure.Interfaces;
using progettoVacanzeBibblioteca.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progettoVacanzeBibblioteca.Presentation
{
    public partial class FrmLibri : Form
    {

        private static readonly LibriController _libriController = new LibriController();

        private static List<Libro> libri;

        private static int indiceLibroSelezionato = -1;
        
        public FrmLibri()
        {
            InitializeComponent();
        }

        private void FrmLibri_Load(object sender, EventArgs e)
        {
            txtId.ReadOnly = true;
            txtIdGenere.ReadOnly = true;

            _libriController.LeggiLibri().Switch(
                data => libri = data.ToList(),
                error => MessageBox.Show(error.ToString())
            );

            updateDataGridView();
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            var libro = mapLibro();

            if (libro is null)
            {
                return;
            }
            _libriController.AggiungiLibro(libro).Switch(
                _ =>
                {
                    libri.Add(libro);
                    updateDataGridView();
                    MessageBox.Show("Libro inserito con successo");
                    clearModifica();
                },

                error => MessageBox.Show(error.ToString())
            );
        }

        private void btnAggiorna_Click(object sender, EventArgs e)
        {
            var libro = mapLibro();

            if (libro is null)
            {
                return;
            }

            _libriController.ModificaLibro(libro).Switch(
                _ =>
                {
                    libri[indiceLibroSelezionato] = libro;
                    updateDataGridView();
                    MessageBox.Show("Libro aggiornato con successo");
                    clearModifica();
                },

                error => MessageBox.Show(error.ToString()),

                libroNonAggiornato => MessageBox.Show(libroNonAggiornato.ToString())
            );
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(txtId.Text, out var id))
            {
                MessageBox.Show("Id non valido");
                return;
            }

            _libriController.EliminaLibro(id).Switch(
                _ =>
                {
                    libri.RemoveAt(indiceLibroSelezionato);
                    updateDataGridView();
                    MessageBox.Show("Libro eliminato con successo");
                    clearModifica();
                },
                
                errore => MessageBox.Show(errore.ToString()),

                libroNonEliminato => MessageBox.Show(libroNonEliminato.ToString())
            );
        }

        private void dgvLibri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceLibroSelezionato = e.RowIndex;
            updateModifica();
        }

        private Libro mapLibro()
        {
            if (!long.TryParse(txtId.Text, out var id))
            {
                MessageBox.Show("Id non valido");
                return null;
            }

            var titolo = txtTitolo.Text?.Trim();
            if (string.IsNullOrEmpty(titolo))
            {
                MessageBox.Show("Titolo non valido");
                return null;
            }

            var annoPubblicazione = (uint)nudAnnoPubblicazione.Value;
            var disponibile = chkDisponibile.Checked;

            var lingua = txtLingua.Text?.Trim();
            if (string.IsNullOrEmpty(lingua))
            {
                MessageBox.Show("Lingua non valida");
                return null;
            }

            if (!long.TryParse(txtIdGenere.Text, out var idGenere))
            {
                MessageBox.Show("Id Genere non valido");
                return null;
            }

            return new Libro(id, titolo, annoPubblicazione, lingua, disponibile, idGenere);
        }

        private void updateModifica()
        {
            var libro = libri[indiceLibroSelezionato];

            txtId.Text = libro.Id.ToString();
            txtTitolo.Text = libro.Titolo;
            nudAnnoPubblicazione.Value = libro.AnnoPubblicazione;
            chkDisponibile.Checked = libro.Disponibile;
            txtLingua.Text = libro.Lingua;
            txtIdGenere.Text = libro.IdGenere.ToString();

            txtId.ReadOnly = true;
            txtIdGenere.ReadOnly = true;
        }

        private void updateDataGridView()
        {
            dgvLibri.DataSource = null;
            dgvLibri.DataSource = libri;
        }

        private void clearModifica()
        {
            foreach (var textbox in grpModifica.Controls.OfType<TextBox>())
            {
                textbox.Clear();
            }
            nudAnnoPubblicazione.Value = 2000;
            txtId.ReadOnly = false;
            txtIdGenere.ReadOnly = false;
        }

        
    }
}
