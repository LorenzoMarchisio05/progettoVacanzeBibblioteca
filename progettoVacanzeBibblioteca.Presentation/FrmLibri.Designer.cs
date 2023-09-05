namespace progettoVacanzeBibblioteca.Presentation
{
    partial class FrmLibri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvLibri = new System.Windows.Forms.DataGridView();
            this.grpModifica = new System.Windows.Forms.GroupBox();
            this.chkDisponibile = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudAnnoPubblicazione = new System.Windows.Forms.NumericUpDown();
            this.txtIdGenere = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLingua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnAggiorna = new System.Windows.Forms.Button();
            this.btnInserisci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibri)).BeginInit();
            this.grpModifica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnoPubblicazione)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLibri
            // 
            this.dgvLibri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibri.Location = new System.Drawing.Point(13, 6);
            this.dgvLibri.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLibri.Name = "dgvLibri";
            this.dgvLibri.RowHeadersWidth = 82;
            this.dgvLibri.RowTemplate.Height = 33;
            this.dgvLibri.Size = new System.Drawing.Size(708, 531);
            this.dgvLibri.TabIndex = 1;
            this.dgvLibri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibri_CellClick);
            // 
            // grpModifica
            // 
            this.grpModifica.Controls.Add(this.chkDisponibile);
            this.grpModifica.Controls.Add(this.label6);
            this.grpModifica.Controls.Add(this.nudAnnoPubblicazione);
            this.grpModifica.Controls.Add(this.txtIdGenere);
            this.grpModifica.Controls.Add(this.label5);
            this.grpModifica.Controls.Add(this.txtLingua);
            this.grpModifica.Controls.Add(this.label4);
            this.grpModifica.Controls.Add(this.label3);
            this.grpModifica.Controls.Add(this.txtTitolo);
            this.grpModifica.Controls.Add(this.label2);
            this.grpModifica.Controls.Add(this.txtId);
            this.grpModifica.Controls.Add(this.label1);
            this.grpModifica.Controls.Add(this.btnElimina);
            this.grpModifica.Controls.Add(this.btnAggiorna);
            this.grpModifica.Controls.Add(this.btnInserisci);
            this.grpModifica.Location = new System.Drawing.Point(741, 6);
            this.grpModifica.Margin = new System.Windows.Forms.Padding(2);
            this.grpModifica.Name = "grpModifica";
            this.grpModifica.Padding = new System.Windows.Forms.Padding(2);
            this.grpModifica.Size = new System.Drawing.Size(444, 531);
            this.grpModifica.TabIndex = 2;
            this.grpModifica.TabStop = false;
            this.grpModifica.Text = "Modifica";
            // 
            // chkDisponibile
            // 
            this.chkDisponibile.AutoSize = true;
            this.chkDisponibile.Location = new System.Drawing.Point(320, 127);
            this.chkDisponibile.Margin = new System.Windows.Forms.Padding(2);
            this.chkDisponibile.Name = "chkDisponibile";
            this.chkDisponibile.Size = new System.Drawing.Size(77, 17);
            this.chkDisponibile.TabIndex = 15;
            this.chkDisponibile.Text = "Disponibile";
            this.chkDisponibile.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 217);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 14;
            // 
            // nudAnnoPubblicazione
            // 
            this.nudAnnoPubblicazione.Location = new System.Drawing.Point(140, 126);
            this.nudAnnoPubblicazione.Margin = new System.Windows.Forms.Padding(2);
            this.nudAnnoPubblicazione.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAnnoPubblicazione.Name = "nudAnnoPubblicazione";
            this.nudAnnoPubblicazione.Size = new System.Drawing.Size(60, 20);
            this.nudAnnoPubblicazione.TabIndex = 13;
            this.nudAnnoPubblicazione.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // txtIdGenere
            // 
            this.txtIdGenere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtIdGenere.Location = new System.Drawing.Point(70, 229);
            this.txtIdGenere.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdGenere.Name = "txtIdGenere";
            this.txtIdGenere.Size = new System.Drawing.Size(342, 21);
            this.txtIdGenere.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Id Genere";
            // 
            // txtLingua
            // 
            this.txtLingua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtLingua.Location = new System.Drawing.Point(70, 173);
            this.txtLingua.Margin = new System.Windows.Forms.Padding(2);
            this.txtLingua.Name = "txtLingua";
            this.txtLingua.Size = new System.Drawing.Size(342, 21);
            this.txtLingua.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lingua";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Anno Pubblicazione";
            // 
            // txtTitolo
            // 
            this.txtTitolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtTitolo.Location = new System.Drawing.Point(70, 76);
            this.txtTitolo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(342, 21);
            this.txtTitolo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Titolo";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtId.Location = new System.Drawing.Point(70, 28);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(342, 21);
            this.txtId.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(320, 482);
            this.btnElimina.Margin = new System.Windows.Forms.Padding(2);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(114, 35);
            this.btnElimina.TabIndex = 2;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnAggiorna
            // 
            this.btnAggiorna.Location = new System.Drawing.Point(168, 482);
            this.btnAggiorna.Margin = new System.Windows.Forms.Padding(2);
            this.btnAggiorna.Name = "btnAggiorna";
            this.btnAggiorna.Size = new System.Drawing.Size(114, 35);
            this.btnAggiorna.TabIndex = 1;
            this.btnAggiorna.Text = "Aggiorna";
            this.btnAggiorna.UseVisualStyleBackColor = true;
            this.btnAggiorna.Click += new System.EventHandler(this.btnAggiorna_Click);
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(15, 482);
            this.btnInserisci.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(114, 35);
            this.btnInserisci.TabIndex = 0;
            this.btnInserisci.Text = "Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // FrmLibri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 548);
            this.Controls.Add(this.grpModifica);
            this.Controls.Add(this.dgvLibri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmLibri";
            this.Text = "FrmLibri";
            this.Load += new System.EventHandler(this.FrmLibri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibri)).EndInit();
            this.grpModifica.ResumeLayout(false);
            this.grpModifica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnoPubblicazione)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLibri;
        private System.Windows.Forms.GroupBox grpModifica;
        private System.Windows.Forms.CheckBox chkDisponibile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudAnnoPubblicazione;
        private System.Windows.Forms.TextBox txtIdGenere;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLingua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnAggiorna;
        private System.Windows.Forms.Button btnInserisci;
    }
}