namespace PartiSecimGrafikIstatistik
{
    partial class FrmGrafikler
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbIlceler = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PrbAp = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PrbBp = new System.Windows.Forms.ProgressBar();
            this.PrbCp = new System.Windows.Forms.ProgressBar();
            this.PrbDp = new System.Windows.Forms.ProgressBar();
            this.PrbEp = new System.Windows.Forms.ProgressBar();
            this.LblAp = new System.Windows.Forms.Label();
            this.LblBp = new System.Windows.Forms.Label();
            this.LblCp = new System.Windows.Forms.Label();
            this.LblDp = new System.Windows.Forms.Label();
            this.LblEp = new System.Windows.Forms.Label();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblGecerliOy = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafikler";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 16);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Partiler";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(770, 226);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblGecerliOy);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.BtnCikis);
            this.groupBox2.Controls.Add(this.LblEp);
            this.groupBox2.Controls.Add(this.LblDp);
            this.groupBox2.Controls.Add(this.LblCp);
            this.groupBox2.Controls.Add(this.LblBp);
            this.groupBox2.Controls.Add(this.LblAp);
            this.groupBox2.Controls.Add(this.PrbEp);
            this.groupBox2.Controls.Add(this.PrbDp);
            this.groupBox2.Controls.Add(this.PrbCp);
            this.groupBox2.Controls.Add(this.PrbBp);
            this.groupBox2.Controls.Add(this.PrbAp);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CmbIlceler);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 236);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İlçe Değerleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlçe Seçin:";
            // 
            // CmbIlceler
            // 
            this.CmbIlceler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbIlceler.FormattingEnabled = true;
            this.CmbIlceler.Location = new System.Drawing.Point(245, 26);
            this.CmbIlceler.Name = "CmbIlceler";
            this.CmbIlceler.Size = new System.Drawing.Size(121, 21);
            this.CmbIlceler.TabIndex = 1;
            this.CmbIlceler.SelectedIndexChanged += new System.EventHandler(this.CmbIlceler_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "APartisi:";
            // 
            // PrbAp
            // 
            this.PrbAp.Location = new System.Drawing.Point(228, 65);
            this.PrbAp.Maximum = 200;
            this.PrbAp.Name = "PrbAp";
            this.PrbAp.Size = new System.Drawing.Size(324, 21);
            this.PrbAp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "BPartisi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "CPartisi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "DPartisi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "EPartisi:";
            // 
            // PrbBp
            // 
            this.PrbBp.Location = new System.Drawing.Point(228, 92);
            this.PrbBp.Maximum = 200;
            this.PrbBp.Name = "PrbBp";
            this.PrbBp.Size = new System.Drawing.Size(324, 21);
            this.PrbBp.TabIndex = 3;
            // 
            // PrbCp
            // 
            this.PrbCp.Location = new System.Drawing.Point(228, 119);
            this.PrbCp.Maximum = 200;
            this.PrbCp.Name = "PrbCp";
            this.PrbCp.Size = new System.Drawing.Size(324, 21);
            this.PrbCp.TabIndex = 3;
            // 
            // PrbDp
            // 
            this.PrbDp.Location = new System.Drawing.Point(228, 146);
            this.PrbDp.Maximum = 200;
            this.PrbDp.Name = "PrbDp";
            this.PrbDp.Size = new System.Drawing.Size(324, 21);
            this.PrbDp.TabIndex = 3;
            // 
            // PrbEp
            // 
            this.PrbEp.Location = new System.Drawing.Point(228, 173);
            this.PrbEp.Maximum = 200;
            this.PrbEp.Name = "PrbEp";
            this.PrbEp.Size = new System.Drawing.Size(324, 21);
            this.PrbEp.TabIndex = 3;
            // 
            // LblAp
            // 
            this.LblAp.AutoSize = true;
            this.LblAp.Location = new System.Drawing.Point(559, 68);
            this.LblAp.Name = "LblAp";
            this.LblAp.Size = new System.Drawing.Size(13, 13);
            this.LblAp.TabIndex = 4;
            this.LblAp.Text = "0";
            // 
            // LblBp
            // 
            this.LblBp.AutoSize = true;
            this.LblBp.Location = new System.Drawing.Point(559, 95);
            this.LblBp.Name = "LblBp";
            this.LblBp.Size = new System.Drawing.Size(13, 13);
            this.LblBp.TabIndex = 5;
            this.LblBp.Text = "0";
            // 
            // LblCp
            // 
            this.LblCp.AutoSize = true;
            this.LblCp.Location = new System.Drawing.Point(559, 122);
            this.LblCp.Name = "LblCp";
            this.LblCp.Size = new System.Drawing.Size(13, 13);
            this.LblCp.TabIndex = 6;
            this.LblCp.Text = "0";
            // 
            // LblDp
            // 
            this.LblDp.AutoSize = true;
            this.LblDp.Location = new System.Drawing.Point(559, 149);
            this.LblDp.Name = "LblDp";
            this.LblDp.Size = new System.Drawing.Size(13, 13);
            this.LblDp.TabIndex = 7;
            this.LblDp.Text = "0";
            // 
            // LblEp
            // 
            this.LblEp.AutoSize = true;
            this.LblEp.Location = new System.Drawing.Point(559, 176);
            this.LblEp.Name = "LblEp";
            this.LblEp.Size = new System.Drawing.Size(13, 13);
            this.LblEp.TabIndex = 8;
            this.LblEp.Text = "0";
            // 
            // BtnCikis
            // 
            this.BtnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCikis.Location = new System.Drawing.Point(353, 207);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(75, 23);
            this.BtnCikis.TabIndex = 10;
            this.BtnCikis.Text = "Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(537, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Aldığı Oy";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(456, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Toplam Geçerli Oy:";
            // 
            // LblGecerliOy
            // 
            this.LblGecerliOy.AutoSize = true;
            this.LblGecerliOy.Location = new System.Drawing.Point(559, 207);
            this.LblGecerliOy.Name = "LblGecerliOy";
            this.LblGecerliOy.Size = new System.Drawing.Size(13, 13);
            this.LblGecerliOy.TabIndex = 13;
            this.LblGecerliOy.Text = "0";
            // 
            // FrmGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGrafikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGrafikler";
            this.Load += new System.EventHandler(this.FrmGrafikler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar PrbAp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbIlceler;
        private System.Windows.Forms.ProgressBar PrbEp;
        private System.Windows.Forms.ProgressBar PrbDp;
        private System.Windows.Forms.ProgressBar PrbCp;
        private System.Windows.Forms.ProgressBar PrbBp;
        private System.Windows.Forms.Label LblEp;
        private System.Windows.Forms.Label LblDp;
        private System.Windows.Forms.Label LblCp;
        private System.Windows.Forms.Label LblBp;
        private System.Windows.Forms.Label LblAp;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblGecerliOy;
        private System.Windows.Forms.Label label8;
    }
}