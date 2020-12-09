namespace PPE3_
{
    partial class FGestionComptesRendu
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
            this.BTNVisiteurs = new System.Windows.Forms.Button();
            this.BTNPraticiens = new System.Windows.Forms.Button();
            this.BTNComptesRendu = new System.Windows.Forms.Button();
            this.BTNMedicaments = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNVisiteurs
            // 
            this.BTNVisiteurs.Location = new System.Drawing.Point(597, 211);
            this.BTNVisiteurs.Name = "BTNVisiteurs";
            this.BTNVisiteurs.Size = new System.Drawing.Size(46, 37);
            this.BTNVisiteurs.TabIndex = 0;
            this.BTNVisiteurs.UseVisualStyleBackColor = true;
            this.BTNVisiteurs.Click += new System.EventHandler(this.BTNVisiteurs_Click);
            // 
            // BTNPraticiens
            // 
            this.BTNPraticiens.Location = new System.Drawing.Point(597, 275);
            this.BTNPraticiens.Name = "BTNPraticiens";
            this.BTNPraticiens.Size = new System.Drawing.Size(46, 37);
            this.BTNPraticiens.TabIndex = 1;
            this.BTNPraticiens.UseVisualStyleBackColor = true;
            this.BTNPraticiens.Click += new System.EventHandler(this.BTNPraticiens_Click);
            // 
            // BTNComptesRendu
            // 
            this.BTNComptesRendu.Location = new System.Drawing.Point(597, 154);
            this.BTNComptesRendu.Name = "BTNComptesRendu";
            this.BTNComptesRendu.Size = new System.Drawing.Size(46, 37);
            this.BTNComptesRendu.TabIndex = 3;
            this.BTNComptesRendu.UseVisualStyleBackColor = true;
            this.BTNComptesRendu.Click += new System.EventHandler(this.BTNComptesRendu_Click);
            // 
            // BTNMedicaments
            // 
            this.BTNMedicaments.Location = new System.Drawing.Point(597, 337);
            this.BTNMedicaments.Name = "BTNMedicaments";
            this.BTNMedicaments.Size = new System.Drawing.Size(46, 37);
            this.BTNMedicaments.TabIndex = 4;
            this.BTNMedicaments.UseVisualStyleBackColor = true;
            this.BTNMedicaments.Click += new System.EventHandler(this.BTNMedicaments_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PPE3_.Properties.Resources.gsb;
            this.pictureBox1.Location = new System.Drawing.Point(22, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(654, 420);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(694, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Comptes-rendu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(694, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Visiteurs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(694, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Praticiens";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(694, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Médicaments";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(597, 414);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 46);
            this.button3.TabIndex = 10;
            this.button3.Text = "Quitter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FGestionComptesRendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 502);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNMedicaments);
            this.Controls.Add(this.BTNComptesRendu);
            this.Controls.Add(this.BTNPraticiens);
            this.Controls.Add(this.BTNVisiteurs);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FGestionComptesRendu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FGestionComptesRendu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNVisiteurs;
        private System.Windows.Forms.Button BTNPraticiens;
        private System.Windows.Forms.Button BTNComptesRendu;
        private System.Windows.Forms.Button BTNMedicaments;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
    }
}