namespace progettoVacanzeBibblioteca.Presentation
{
    partial class FrmPrestiti
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParolaChiave = new System.Windows.Forms.TextBox();
            this.btnCercaParolaChiave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCognomeAutore = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeAutore = new System.Windows.Forms.TextBox();
            this.btnCercaPerAutore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnRicercaPerNominativo = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nudIdSocio = new System.Windows.Forms.NumericUpDown();
            this.btnCercaPerIdSocio = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdSocio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(804, 608);
            this.dgv.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(810, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(488, 608);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(480, 579);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ricerca Libri Disponibile";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtParolaChiave);
            this.groupBox2.Controls.Add(this.btnCercaParolaChiave);
            this.groupBox2.Location = new System.Drawing.Point(15, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 289);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ricerca per parola chiave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parola Chiave";
            // 
            // txtParolaChiave
            // 
            this.txtParolaChiave.Location = new System.Drawing.Point(20, 53);
            this.txtParolaChiave.Name = "txtParolaChiave";
            this.txtParolaChiave.Size = new System.Drawing.Size(422, 22);
            this.txtParolaChiave.TabIndex = 3;
            // 
            // btnCercaParolaChiave
            // 
            this.btnCercaParolaChiave.Location = new System.Drawing.Point(20, 81);
            this.btnCercaParolaChiave.Name = "btnCercaParolaChiave";
            this.btnCercaParolaChiave.Size = new System.Drawing.Size(116, 40);
            this.btnCercaParolaChiave.TabIndex = 4;
            this.btnCercaParolaChiave.Text = "Cerca";
            this.btnCercaParolaChiave.UseVisualStyleBackColor = true;
            this.btnCercaParolaChiave.Click += new System.EventHandler(this.btnCercaParolaChiave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCognomeAutore);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNomeAutore);
            this.groupBox1.Controls.Add(this.btnCercaPerAutore);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 271);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ricerca per autore";
            // 
            // txtCognomeAutore
            // 
            this.txtCognomeAutore.Location = new System.Drawing.Point(19, 104);
            this.txtCognomeAutore.Name = "txtCognomeAutore";
            this.txtCognomeAutore.Size = new System.Drawing.Size(422, 22);
            this.txtCognomeAutore.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cognome";
            // 
            // txtNomeAutore
            // 
            this.txtNomeAutore.Location = new System.Drawing.Point(19, 55);
            this.txtNomeAutore.Name = "txtNomeAutore";
            this.txtNomeAutore.Size = new System.Drawing.Size(422, 22);
            this.txtNomeAutore.TabIndex = 0;
            // 
            // btnCercaPerAutore
            // 
            this.btnCercaPerAutore.Location = new System.Drawing.Point(19, 141);
            this.btnCercaPerAutore.Name = "btnCercaPerAutore";
            this.btnCercaPerAutore.Size = new System.Drawing.Size(116, 40);
            this.btnCercaPerAutore.TabIndex = 1;
            this.btnCercaPerAutore.Text = "Cerca";
            this.btnCercaPerAutore.UseVisualStyleBackColor = true;
            this.btnCercaPerAutore.Click += new System.EventHandler(this.btnCercaPerAutore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(480, 579);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Libri in Prestito";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtCognome);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtNome);
            this.groupBox3.Controls.Add(this.btnRicercaPerNominativo);
            this.groupBox3.Location = new System.Drawing.Point(15, 283);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(459, 289);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ricerca per nominativo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cognome";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(20, 104);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(422, 22);
            this.txtCognome.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(20, 53);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(422, 22);
            this.txtNome.TabIndex = 3;
            // 
            // btnRicercaPerNominativo
            // 
            this.btnRicercaPerNominativo.Location = new System.Drawing.Point(20, 132);
            this.btnRicercaPerNominativo.Name = "btnRicercaPerNominativo";
            this.btnRicercaPerNominativo.Size = new System.Drawing.Size(116, 40);
            this.btnRicercaPerNominativo.TabIndex = 4;
            this.btnRicercaPerNominativo.Text = "Cerca";
            this.btnRicercaPerNominativo.UseVisualStyleBackColor = true;
            this.btnRicercaPerNominativo.Click += new System.EventHandler(this.btnRicercaPerNominativo_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nudIdSocio);
            this.groupBox4.Controls.Add(this.btnCercaPerIdSocio);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(468, 271);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ricerca per id socio";
            // 
            // nudIdSocio
            // 
            this.nudIdSocio.Location = new System.Drawing.Point(19, 55);
            this.nudIdSocio.Maximum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            0});
            this.nudIdSocio.Name = "nudIdSocio";
            this.nudIdSocio.Size = new System.Drawing.Size(432, 22);
            this.nudIdSocio.TabIndex = 3;
            // 
            // btnCercaPerIdSocio
            // 
            this.btnCercaPerIdSocio.Location = new System.Drawing.Point(19, 83);
            this.btnCercaPerIdSocio.Name = "btnCercaPerIdSocio";
            this.btnCercaPerIdSocio.Size = new System.Drawing.Size(116, 40);
            this.btnCercaPerIdSocio.TabIndex = 1;
            this.btnCercaPerIdSocio.Text = "Cerca";
            this.btnCercaPerIdSocio.UseVisualStyleBackColor = true;
            this.btnCercaPerIdSocio.Click += new System.EventHandler(this.btnCercaPerIdSocio_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID Socio";
            // 
            // FrmPrestiti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 609);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPrestiti";
            this.Text = "FrmPrestiti";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdSocio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtParolaChiave;
        private System.Windows.Forms.Button btnCercaParolaChiave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNomeAutore;
        private System.Windows.Forms.Button btnCercaPerAutore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnRicercaPerNominativo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown nudIdSocio;
        private System.Windows.Forms.Button btnCercaPerIdSocio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtCognomeAutore;
        private System.Windows.Forms.Label label6;
    }
}