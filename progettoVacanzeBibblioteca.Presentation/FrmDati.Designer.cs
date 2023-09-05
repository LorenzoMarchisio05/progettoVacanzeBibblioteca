namespace progettoVacanzeBibblioteca.Presentation
{
    partial class FrmDati
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnQuery1 = new System.Windows.Forms.Button();
            this.btnQuery2 = new System.Windows.Forms.Button();
            this.btnQuery3 = new System.Windows.Forms.Button();
            this.btnQuery4 = new System.Windows.Forms.Button();
            this.btnQuery5 = new System.Windows.Forms.Button();
            this.btnQuery6 = new System.Windows.Forms.Button();
            this.btnQuery7 = new System.Windows.Forms.Button();
            this.btnQuery8 = new System.Windows.Forms.Button();
            this.btnQuery9 = new System.Windows.Forms.Button();
            this.btnQuery10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(429, 432);
            this.dgv.TabIndex = 0;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(447, 12);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(547, 432);
            this.chart.TabIndex = 1;
            this.chart.Text = "chart1";
            // 
            // btnQuery1
            // 
            this.btnQuery1.Location = new System.Drawing.Point(12, 466);
            this.btnQuery1.Name = "btnQuery1";
            this.btnQuery1.Size = new System.Drawing.Size(57, 23);
            this.btnQuery1.TabIndex = 2;
            this.btnQuery1.Text = "Query 1";
            this.btnQuery1.UseVisualStyleBackColor = true;
            this.btnQuery1.Click += new System.EventHandler(this.btnQuery1_Click);
            // 
            // btnQuery2
            // 
            this.btnQuery2.Location = new System.Drawing.Point(85, 466);
            this.btnQuery2.Name = "btnQuery2";
            this.btnQuery2.Size = new System.Drawing.Size(57, 23);
            this.btnQuery2.TabIndex = 3;
            this.btnQuery2.Text = "Query 2";
            this.btnQuery2.UseVisualStyleBackColor = true;
            this.btnQuery2.Click += new System.EventHandler(this.btnQuery2_Click);
            // 
            // btnQuery3
            // 
            this.btnQuery3.Location = new System.Drawing.Point(162, 466);
            this.btnQuery3.Name = "btnQuery3";
            this.btnQuery3.Size = new System.Drawing.Size(57, 23);
            this.btnQuery3.TabIndex = 4;
            this.btnQuery3.Text = "Query 3";
            this.btnQuery3.UseVisualStyleBackColor = true;
            this.btnQuery3.Click += new System.EventHandler(this.btnQuery3_Click);
            // 
            // btnQuery4
            // 
            this.btnQuery4.Location = new System.Drawing.Point(238, 466);
            this.btnQuery4.Name = "btnQuery4";
            this.btnQuery4.Size = new System.Drawing.Size(57, 23);
            this.btnQuery4.TabIndex = 5;
            this.btnQuery4.Text = "Query 4";
            this.btnQuery4.UseVisualStyleBackColor = true;
            this.btnQuery4.Click += new System.EventHandler(this.btnQuery4_Click);
            // 
            // btnQuery5
            // 
            this.btnQuery5.Location = new System.Drawing.Point(310, 466);
            this.btnQuery5.Name = "btnQuery5";
            this.btnQuery5.Size = new System.Drawing.Size(57, 23);
            this.btnQuery5.TabIndex = 6;
            this.btnQuery5.Text = "Query 5";
            this.btnQuery5.UseVisualStyleBackColor = true;
            this.btnQuery5.Click += new System.EventHandler(this.btnQuery5_Click);
            // 
            // btnQuery6
            // 
            this.btnQuery6.Location = new System.Drawing.Point(384, 466);
            this.btnQuery6.Name = "btnQuery6";
            this.btnQuery6.Size = new System.Drawing.Size(57, 23);
            this.btnQuery6.TabIndex = 7;
            this.btnQuery6.Text = "Query 6";
            this.btnQuery6.UseVisualStyleBackColor = true;
            this.btnQuery6.Click += new System.EventHandler(this.btnQuery6_Click);
            // 
            // btnQuery7
            // 
            this.btnQuery7.Location = new System.Drawing.Point(457, 466);
            this.btnQuery7.Name = "btnQuery7";
            this.btnQuery7.Size = new System.Drawing.Size(57, 23);
            this.btnQuery7.TabIndex = 8;
            this.btnQuery7.Text = "Query 7";
            this.btnQuery7.UseVisualStyleBackColor = true;
            this.btnQuery7.Click += new System.EventHandler(this.btnQuery7_Click);
            // 
            // btnQuery8
            // 
            this.btnQuery8.Location = new System.Drawing.Point(535, 466);
            this.btnQuery8.Name = "btnQuery8";
            this.btnQuery8.Size = new System.Drawing.Size(57, 23);
            this.btnQuery8.TabIndex = 9;
            this.btnQuery8.Text = "Query 8";
            this.btnQuery8.UseVisualStyleBackColor = true;
            this.btnQuery8.Click += new System.EventHandler(this.btnQuery8_Click);
            // 
            // btnQuery9
            // 
            this.btnQuery9.Location = new System.Drawing.Point(617, 466);
            this.btnQuery9.Name = "btnQuery9";
            this.btnQuery9.Size = new System.Drawing.Size(57, 23);
            this.btnQuery9.TabIndex = 10;
            this.btnQuery9.Text = "Query 9";
            this.btnQuery9.UseVisualStyleBackColor = true;
            this.btnQuery9.Click += new System.EventHandler(this.btnQuery9_Click);
            // 
            // btnQuery10
            // 
            this.btnQuery10.Location = new System.Drawing.Point(701, 466);
            this.btnQuery10.Name = "btnQuery10";
            this.btnQuery10.Size = new System.Drawing.Size(69, 23);
            this.btnQuery10.TabIndex = 11;
            this.btnQuery10.Text = "Query 10";
            this.btnQuery10.UseVisualStyleBackColor = true;
            this.btnQuery10.Click += new System.EventHandler(this.btnQuery10_Click);
            // 
            // FrmDati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 501);
            this.Controls.Add(this.btnQuery10);
            this.Controls.Add(this.btnQuery9);
            this.Controls.Add(this.btnQuery8);
            this.Controls.Add(this.btnQuery7);
            this.Controls.Add(this.btnQuery6);
            this.Controls.Add(this.btnQuery5);
            this.Controls.Add(this.btnQuery4);
            this.Controls.Add(this.btnQuery3);
            this.Controls.Add(this.btnQuery2);
            this.Controls.Add(this.btnQuery1);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.dgv);
            this.Name = "FrmDati";
            this.Text = "FrmDati";
            this.Load += new System.EventHandler(this.FrmDati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button btnQuery1;
        private System.Windows.Forms.Button btnQuery2;
        private System.Windows.Forms.Button btnQuery3;
        private System.Windows.Forms.Button btnQuery4;
        private System.Windows.Forms.Button btnQuery5;
        private System.Windows.Forms.Button btnQuery6;
        private System.Windows.Forms.Button btnQuery7;
        private System.Windows.Forms.Button btnQuery8;
        private System.Windows.Forms.Button btnQuery9;
        private System.Windows.Forms.Button btnQuery10;
    }
}