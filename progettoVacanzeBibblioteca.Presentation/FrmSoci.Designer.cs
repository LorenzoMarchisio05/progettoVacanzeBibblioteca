namespace progettoVacanzeBibblioteca.Presentation
{
    partial class FrmSoci
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
            this.dgvSoci = new System.Windows.Forms.DataGridView();
            this.grpModifica = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnAggiorna = new System.Windows.Forms.Button();
            this.btnInserisci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoci)).BeginInit();
            this.grpModifica.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSoci
            // 
            this.dgvSoci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoci.Location = new System.Drawing.Point(6, 6);
            this.dgvSoci.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSoci.Name = "dgvSoci";
            this.dgvSoci.RowHeadersWidth = 82;
            this.dgvSoci.RowTemplate.Height = 33;
            this.dgvSoci.Size = new System.Drawing.Size(668, 531);
            this.dgvSoci.TabIndex = 0;
            this.dgvSoci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSoci_CellClick);
            // 
            // grpModifica
            // 
            this.grpModifica.Controls.Add(this.txtEmail);
            this.grpModifica.Controls.Add(this.label5);
            this.grpModifica.Controls.Add(this.txtTelefono);
            this.grpModifica.Controls.Add(this.label4);
            this.grpModifica.Controls.Add(this.txtCognome);
            this.grpModifica.Controls.Add(this.label3);
            this.grpModifica.Controls.Add(this.txtNome);
            this.grpModifica.Controls.Add(this.label2);
            this.grpModifica.Controls.Add(this.txtId);
            this.grpModifica.Controls.Add(this.label1);
            this.grpModifica.Controls.Add(this.btnElimina);
            this.grpModifica.Controls.Add(this.btnAggiorna);
            this.grpModifica.Controls.Add(this.btnInserisci);
            this.grpModifica.Location = new System.Drawing.Point(678, 6);
            this.grpModifica.Margin = new System.Windows.Forms.Padding(2);
            this.grpModifica.Name = "grpModifica";
            this.grpModifica.Padding = new System.Windows.Forms.Padding(2);
            this.grpModifica.Size = new System.Drawing.Size(444, 531);
            this.grpModifica.TabIndex = 1;
            this.grpModifica.TabStop = false;
            this.grpModifica.Text = "Modifica";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtEmail.Location = new System.Drawing.Point(70, 224);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(342, 21);
            this.txtEmail.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 227);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtTelefono.Location = new System.Drawing.Point(70, 173);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(342, 21);
            this.txtTelefono.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefono";
            // 
            // txtCognome
            // 
            this.txtCognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtCognome.Location = new System.Drawing.Point(70, 124);
            this.txtCognome.Margin = new System.Windows.Forms.Padding(2);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(342, 21);
            this.txtCognome.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cognome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNome.Location = new System.Drawing.Point(70, 76);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(342, 21);
            this.txtNome.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
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
            // FrmSoci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 542);
            this.Controls.Add(this.grpModifica);
            this.Controls.Add(this.dgvSoci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmSoci";
            this.Text = "FrmSoci";
            this.Load += new System.EventHandler(this.FrmSoci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoci)).EndInit();
            this.grpModifica.ResumeLayout(false);
            this.grpModifica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSoci;
        private System.Windows.Forms.GroupBox grpModifica;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnAggiorna;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
    }
}