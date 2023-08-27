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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnGestioneSoci_Click(object sender, EventArgs e) => new FrmSoci().ShowDialog(this);

        private void btnGestioneLibri_Click(object sender, EventArgs e) => new FrmLibri().ShowDialog(this);

        private void btnGestionePrestiti_Click(object sender, EventArgs e) => new FrmPrestiti().ShowDialog(this);

        private void btnVisualizzazioneDati_Click(object sender, EventArgs e) => new FrmDati().ShowDialog(this);
    }
}
