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
    public partial class FrmSoci : Form
    {
        private static SociController _sociController = new SociController();

        private static List<Socio> soci;

        private static int indiceSocioSelezionato = -1;

        public FrmSoci()
        {
            InitializeComponent();
        }

        private void FrmSoci_Load(object sender, EventArgs e)
        {
            txtId.ReadOnly = true;

            _sociController.LeggiSoci().Switch(
                    data => soci = data.ToList(),
                    error => MessageBox.Show(error.ToString())
            );
            updateDataGridView();
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            var socio = mapSocio();

            if(socio is null)
            {
                return;
            }

            _sociController.AggiungiSocio(socio).Switch(
                id =>
                {
                    soci.Add(socio);
                    updateDataGridView();
                    MessageBox.Show("Socio inserito con successo");
                    clearModifica();
                },

                errore => MessageBox.Show(errore.ToString())
            );
        }

        private void btnAggiorna_Click(object sender, EventArgs e)
        {
            var socio = mapSocio();

            if (socio is null)
            {
                return;
            }

            _sociController.ModificaSocio(socio).Switch(
                    id =>
                    {
                        soci[indiceSocioSelezionato] = socio;
                        updateDataGridView();
                        MessageBox.Show("Socio aggiornato con successo");
                        clearModifica();
                    },

                    errore => MessageBox.Show(errore.ToString()),

                    socioNonTrovato => MessageBox.Show(socioNonTrovato.ToString())
            );
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(txtId.Text, out var id))
            {
                MessageBox.Show("Id non valido");
                return;
            }

            _sociController.EliminaSocio(id).Switch(
                _ =>
                {
                    soci.RemoveAt(indiceSocioSelezionato);
                    updateDataGridView();
                    MessageBox.Show("Socio eliminato con successo");
                    clearModifica();
                },

                errore => MessageBox.Show(errore.ToString()),

                socioNonEliminato => MessageBox.Show(socioNonEliminato.ToString())
            );
        }

        private void dgvSoci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceSocioSelezionato = e.RowIndex;
            updateModifica();
        }

        private Socio mapSocio()
        {
            if (!long.TryParse(txtId.Text, out var id))
            {
                MessageBox.Show("Id non valido");
                return null;
            }

            var nome = txtNome.Text?.Trim();
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Nome non valido");
                return null;
            }

            var cognome = txtCognome.Text?.Trim();
            if (string.IsNullOrEmpty(cognome))
            {
                MessageBox.Show("Cognome non valido");
                return null;
            }

            var telefono = PhoneNumber.From(txtTelefono.Text?.Trim());
            var email = Email.From(txtEmail.Text?.Trim());

            return new Socio(id, nome, cognome, telefono, email);
        }

        private void updateModifica()
        {
            var socio = soci[indiceSocioSelezionato];

            txtId.Text = socio.Id.ToString();
            txtNome.Text = socio.Nome;
            txtCognome.Text = socio.Cognome;
            txtTelefono.Text = socio.Telefono;
            txtEmail.Text = socio.Email;

            txtId.ReadOnly = true;
        }

        private void updateDataGridView()
        {
            dgvSoci.DataSource = null;
            dgvSoci.DataSource = soci;
        }

        private void clearModifica()
        {
            foreach(var textbox in grpModifica.Controls.OfType<TextBox>())
            {
                textbox.Clear();
            }
            txtId.ReadOnly = false;
        }
    }
}
