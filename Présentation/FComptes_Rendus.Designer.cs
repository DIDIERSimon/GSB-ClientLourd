namespace PPE3_
{
    partial class FComptes_Rendus
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
            this.lbel1 = new System.Windows.Forms.Label();
            this.TBXNumRapport = new System.Windows.Forms.TextBox();
            this.CBXPraticien = new System.Windows.Forms.ComboBox();
            this.BTNDetails = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColMedicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNbEchant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TBXDateRapport = new System.Windows.Forms.TextBox();
            this.TBXMotif = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBXBilan = new System.Windows.Forms.TextBox();
            this.Bilan = new System.Windows.Forms.Label();
            this.BTNPrecedent = new System.Windows.Forms.Button();
            this.BTNSuivant = new System.Windows.Forms.Button();
            this.BTNNouveau = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BTNEnregistrer = new System.Windows.Forms.Button();
            this.BTNQuitter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbel1
            // 
            this.lbel1.AutoSize = true;
            this.lbel1.Location = new System.Drawing.Point(12, 100);
            this.lbel1.Name = "lbel1";
            this.lbel1.Size = new System.Drawing.Size(113, 17);
            this.lbel1.TabIndex = 0;
            this.lbel1.Text = "Numéro Rapport";
            // 
            // TBXNumRapport
            // 
            this.TBXNumRapport.Location = new System.Drawing.Point(127, 100);
            this.TBXNumRapport.Name = "TBXNumRapport";
            this.TBXNumRapport.Size = new System.Drawing.Size(100, 22);
            this.TBXNumRapport.TabIndex = 1;
            // 
            // CBXPraticien
            // 
            this.CBXPraticien.FormattingEnabled = true;
            this.CBXPraticien.Location = new System.Drawing.Point(127, 156);
            this.CBXPraticien.Name = "CBXPraticien";
            this.CBXPraticien.Size = new System.Drawing.Size(121, 24);
            this.CBXPraticien.TabIndex = 2;
            // 
            // BTNDetails
            // 
            this.BTNDetails.Location = new System.Drawing.Point(294, 157);
            this.BTNDetails.Name = "BTNDetails";
            this.BTNDetails.Size = new System.Drawing.Size(75, 23);
            this.BTNDetails.TabIndex = 3;
            this.BTNDetails.Text = "Details";
            this.BTNDetails.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMedicament,
            this.ColNbEchant});
            this.dataGridView1.Location = new System.Drawing.Point(420, 346);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(299, 184);
            this.dataGridView1.TabIndex = 4;
            // 
            // ColMedicament
            // 
            this.ColMedicament.HeaderText = "Médicament";
            this.ColMedicament.MinimumWidth = 6;
            this.ColMedicament.Name = "ColMedicament";
            this.ColMedicament.Width = 125;
            // 
            // ColNbEchant
            // 
            this.ColNbEchant.HeaderText = "NB Echantillon";
            this.ColNbEchant.MinimumWidth = 6;
            this.ColNbEchant.Name = "ColNbEchant";
            this.ColNbEchant.Width = 125;
            // 
            // TBXDateRapport
            // 
            this.TBXDateRapport.Location = new System.Drawing.Point(127, 221);
            this.TBXDateRapport.Name = "TBXDateRapport";
            this.TBXDateRapport.Size = new System.Drawing.Size(133, 22);
            this.TBXDateRapport.TabIndex = 5;
            // 
            // TBXMotif
            // 
            this.TBXMotif.Location = new System.Drawing.Point(127, 279);
            this.TBXMotif.Multiline = true;
            this.TBXMotif.Name = "TBXMotif";
            this.TBXMotif.Size = new System.Drawing.Size(221, 22);
            this.TBXMotif.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Motif Visite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date Rapport";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Praticien";
            // 
            // TBXBilan
            // 
            this.TBXBilan.Location = new System.Drawing.Point(127, 333);
            this.TBXBilan.Multiline = true;
            this.TBXBilan.Name = "TBXBilan";
            this.TBXBilan.Size = new System.Drawing.Size(242, 100);
            this.TBXBilan.TabIndex = 10;
            // 
            // Bilan
            // 
            this.Bilan.AutoSize = true;
            this.Bilan.Location = new System.Drawing.Point(12, 336);
            this.Bilan.Name = "Bilan";
            this.Bilan.Size = new System.Drawing.Size(39, 17);
            this.Bilan.TabIndex = 11;
            this.Bilan.Text = "Bilan";
            // 
            // BTNPrecedent
            // 
            this.BTNPrecedent.Location = new System.Drawing.Point(63, 450);
            this.BTNPrecedent.Name = "BTNPrecedent";
            this.BTNPrecedent.Size = new System.Drawing.Size(86, 29);
            this.BTNPrecedent.TabIndex = 12;
            this.BTNPrecedent.Text = "Precedent";
            this.BTNPrecedent.UseVisualStyleBackColor = true;
            this.BTNPrecedent.Click += new System.EventHandler(this.BTNPrecedent_Click);
            // 
            // BTNSuivant
            // 
            this.BTNSuivant.Location = new System.Drawing.Point(174, 450);
            this.BTNSuivant.Name = "BTNSuivant";
            this.BTNSuivant.Size = new System.Drawing.Size(86, 29);
            this.BTNSuivant.TabIndex = 13;
            this.BTNSuivant.Text = "Suivant";
            this.BTNSuivant.UseVisualStyleBackColor = true;
            this.BTNSuivant.Click += new System.EventHandler(this.BTNSuivant_Click);
            // 
            // BTNNouveau
            // 
            this.BTNNouveau.Location = new System.Drawing.Point(283, 450);
            this.BTNNouveau.Name = "BTNNouveau";
            this.BTNNouveau.Size = new System.Drawing.Size(86, 29);
            this.BTNNouveau.TabIndex = 14;
            this.BTNNouveau.Text = "Nouveau";
            this.BTNNouveau.UseVisualStyleBackColor = true;
            this.BTNNouveau.Click += new System.EventHandler(this.BTNNouveau_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(173, 549);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Details";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Offres d\'échantillon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "RAPPORT DE VISITE";
            // 
            // BTNEnregistrer
            // 
            this.BTNEnregistrer.Location = new System.Drawing.Point(112, 496);
            this.BTNEnregistrer.Name = "BTNEnregistrer";
            this.BTNEnregistrer.Size = new System.Drawing.Size(189, 29);
            this.BTNEnregistrer.TabIndex = 18;
            this.BTNEnregistrer.Text = "Enregistrer";
            this.BTNEnregistrer.UseVisualStyleBackColor = true;
            this.BTNEnregistrer.Click += new System.EventHandler(this.BTNEnregistrer_Click);
            // 
            // BTNQuitter
            // 
            this.BTNQuitter.Location = new System.Drawing.Point(739, 471);
            this.BTNQuitter.Name = "BTNQuitter";
            this.BTNQuitter.Size = new System.Drawing.Size(86, 29);
            this.BTNQuitter.TabIndex = 19;
            this.BTNQuitter.Text = "Quitter";
            this.BTNQuitter.UseVisualStyleBackColor = true;
            this.BTNQuitter.Click += new System.EventHandler(this.BTNQuitter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PPE3_.Properties.Resources.gsb;
            this.pictureBox1.Location = new System.Drawing.Point(365, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(666, 478);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // FComptes_Rendus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 550);
            this.Controls.Add(this.BTNQuitter);
            this.Controls.Add(this.BTNEnregistrer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BTNNouveau);
            this.Controls.Add(this.BTNSuivant);
            this.Controls.Add(this.BTNPrecedent);
            this.Controls.Add(this.Bilan);
            this.Controls.Add(this.TBXBilan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBXMotif);
            this.Controls.Add(this.TBXDateRapport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTNDetails);
            this.Controls.Add(this.CBXPraticien);
            this.Controls.Add(this.TBXNumRapport);
            this.Controls.Add(this.lbel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FComptes_Rendus";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FComptes_Rendus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbel1;
        private System.Windows.Forms.TextBox TBXNumRapport;
        private System.Windows.Forms.ComboBox CBXPraticien;
        private System.Windows.Forms.Button BTNDetails;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TBXDateRapport;
        private System.Windows.Forms.TextBox TBXMotif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBXBilan;
        private System.Windows.Forms.Label Bilan;
        private System.Windows.Forms.Button BTNPrecedent;
        private System.Windows.Forms.Button BTNSuivant;
        private System.Windows.Forms.Button BTNNouveau;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTNEnregistrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNbEchant;
        private System.Windows.Forms.Button BTNQuitter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}