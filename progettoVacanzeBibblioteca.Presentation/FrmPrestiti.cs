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

namespace progettoVacanzeBibblioteca.Presentation
{
    public partial class FrmPrestiti : Form
    {

        private readonly PrestitiController _prestitiController;
        public FrmPrestiti()
        {
            InitializeComponent();

            _prestitiController = new PrestitiController();
        }

        private void btnCercaPerAutore_Click(object sender, EventArgs e)
        {
            _prestitiController.LeggiPrestitiByAutore(txtNomeAutore.Text?.Trim(), txtCognomeAutore.Text?.Trim()).Switch(
                    libri => updateDgv(libri),
                    errore => MessageBox.Show(errore.ToString()));
        }

        private void btnCercaParolaChiave_Click(object sender, EventArgs e)
        {

        }

        private void btnCercaPerIdSocio_Click(object sender, EventArgs e)
        {
            _prestitiController.LeggiPrestitiByIdSocio((long)nudIdSocio.Value).Switch(
                    libri => updateDgv(libri),
                    errore => MessageBox.Show(errore.ToString()));
        }

        private void btnRicercaPerNominativo_Click(object sender, EventArgs e)
        {
            _prestitiController.LeggiPrestitiByNomeSocio(txtNome.Text?.Trim(), txtCognome.Text?.Trim()).Switch(
                    libri => updateDgv(libri),
                    errore => MessageBox.Show(errore.ToString()));
        }

        private void updateDgv<T>(IEnumerable<T> data)
        {
            dgv.DataSource = null;
            dgv.DataSource = data;
        }
    }
}
