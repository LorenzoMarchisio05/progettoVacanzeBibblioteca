namespace progettoVacanzeBibblioteca.Presentation
{
    partial class FrmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGestioneSoci = new System.Windows.Forms.Button();
            this.btnGestioneLibri = new System.Windows.Forms.Button();
            this.btnGestionePrestiti = new System.Windows.Forms.Button();
            this.btnVisualizzazioneDati = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestioneSoci
            // 
            this.btnGestioneSoci.Location = new System.Drawing.Point(47, 31);
            this.btnGestioneSoci.Name = "btnGestioneSoci";
            this.btnGestioneSoci.Size = new System.Drawing.Size(439, 84);
            this.btnGestioneSoci.TabIndex = 0;
            this.btnGestioneSoci.Text = "Gestione Soci";
            this.btnGestioneSoci.UseVisualStyleBackColor = true;
            this.btnGestioneSoci.Click += new System.EventHandler(this.btnGestioneSoci_Click);
            // 
            // btnGestioneLibri
            // 
            this.btnGestioneLibri.Location = new System.Drawing.Point(47, 150);
            this.btnGestioneLibri.Name = "btnGestioneLibri";
            this.btnGestioneLibri.Size = new System.Drawing.Size(439, 84);
            this.btnGestioneLibri.TabIndex = 1;
            this.btnGestioneLibri.Text = "Gestione Libri";
            this.btnGestioneLibri.UseVisualStyleBackColor = true;
            this.btnGestioneLibri.Click += new System.EventHandler(this.btnGestioneLibri_Click);
            // 
            // btnGestionePrestiti
            // 
            this.btnGestionePrestiti.Location = new System.Drawing.Point(47, 266);
            this.btnGestionePrestiti.Name = "btnGestionePrestiti";
            this.btnGestionePrestiti.Size = new System.Drawing.Size(439, 84);
            this.btnGestionePrestiti.TabIndex = 2;
            this.btnGestionePrestiti.Text = "Gestione Prestiti";
            this.btnGestionePrestiti.UseVisualStyleBackColor = true;
            this.btnGestionePrestiti.Click += new System.EventHandler(this.btnGestionePrestiti_Click);
            // 
            // btnVisualizzazioneDati
            // 
            this.btnVisualizzazioneDati.Location = new System.Drawing.Point(47, 386);
            this.btnVisualizzazioneDati.Name = "btnVisualizzazioneDati";
            this.btnVisualizzazioneDati.Size = new System.Drawing.Size(439, 84);
            this.btnVisualizzazioneDati.TabIndex = 3;
            this.btnVisualizzazioneDati.Text = "Visualizzazione Dati";
            this.btnVisualizzazioneDati.UseVisualStyleBackColor = true;
            this.btnVisualizzazioneDati.Click += new System.EventHandler(this.btnVisualizzazioneDati_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 512);
            this.Controls.Add(this.btnVisualizzazioneDati);
            this.Controls.Add(this.btnGestionePrestiti);
            this.Controls.Add(this.btnGestioneLibri);
            this.Controls.Add(this.btnGestioneSoci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMain";
            this.Text = "Gestione Biblioteca";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestioneSoci;
        private System.Windows.Forms.Button btnGestioneLibri;
        private System.Windows.Forms.Button btnGestionePrestiti;
        private System.Windows.Forms.Button btnVisualizzazioneDati;
    }
}

