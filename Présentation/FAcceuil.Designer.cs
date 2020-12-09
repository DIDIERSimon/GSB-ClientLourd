namespace PPE3_
{
    partial class FAcceuil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TBIdentifiant = new System.Windows.Forms.TextBox();
            this.TBMotDePasse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNValider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PPE3_.Properties.Resources.gsb;
            this.pictureBox1.Location = new System.Drawing.Point(0, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(555, 299);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TBIdentifiant
            // 
            this.TBIdentifiant.Location = new System.Drawing.Point(561, 180);
            this.TBIdentifiant.Name = "TBIdentifiant";
            this.TBIdentifiant.Size = new System.Drawing.Size(190, 22);
            this.TBIdentifiant.TabIndex = 1;
            // 
            // TBMotDePasse
            // 
            this.TBMotDePasse.Location = new System.Drawing.Point(561, 251);
            this.TBMotDePasse.Name = "TBMotDePasse";
            this.TBMotDePasse.Size = new System.Drawing.Size(190, 22);
            this.TBMotDePasse.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(599, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Identifiez vous";
            // 
            // BTNValider
            // 
            this.BTNValider.Location = new System.Drawing.Point(602, 333);
            this.BTNValider.Name = "BTNValider";
            this.BTNValider.Size = new System.Drawing.Size(116, 47);
            this.BTNValider.TabIndex = 4;
            this.BTNValider.Text = "Valider";
            this.BTNValider.UseVisualStyleBackColor = true;
            this.BTNValider.Click += new System.EventHandler(this.BTNValider_Click);
            // 
            // FAcceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNValider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBMotDePasse);
            this.Controls.Add(this.TBIdentifiant);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FAcceuil";
            this.Text = "Acceuil";
            this.Load += new System.EventHandler(this.FAcceuil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TBIdentifiant;
        private System.Windows.Forms.TextBox TBMotDePasse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNValider;
    }
}

