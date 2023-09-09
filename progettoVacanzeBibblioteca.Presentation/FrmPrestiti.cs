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
            MessageBox.Show("Doppio click su una riga per restituire il libro in prestito");

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
            _prestitiController.LeggiPrestitiByParolaChiave(txtParolaChiave.Text?.Trim()).Switch(
                libri => updateDgv(libri),
                errore => MessageBox.Show(errore.ToString()));
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

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;

            if (rowIndex < 0) return;

            if(DialogResult.Yes == MessageBox.Show("Vuoi restituire il libro?", "Confirm", MessageBoxButtons.YesNoCancel))
            {
                var id = Convert.ToInt64(dgv.Rows[rowIndex].Cells[0].Value);
                var message = _prestitiController.EliminaPrestito(id).Match(
                    _ => "libro restituito con successo",
                    errore1 => errore1.ToString(),
                    errore2 => errore2.ToString()
                );
                MessageBox.Show(message);
                dgv.DataSource = null;
                dgv.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Operazione annullata");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            dgv.Rows.Clear();
            if(tabControl1.SelectedIndex == 1)
            {
                dgv.CellDoubleClick += dgv_CellDoubleClick;
            }
            else
            {
                dgv.CellDoubleClick -= dgv_CellDoubleClick;
            }
        }
    }
}
