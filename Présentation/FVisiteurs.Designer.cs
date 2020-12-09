namespace PPE3_
{
    partial class FVisiteurs
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
            this.lVVisiteurs = new System.Windows.Forms.ListView();
            this.BTNQuitter = new System.Windows.Forms.Button();
            this.columnMatricule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAdresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDateembauche = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lVVisiteurs
            // 
            this.lVVisiteurs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMatricule,
            this.columnNom,
            this.columnPrenom,
            this.columnAdresse,
            this.columnCp,
            this.columnVille,
            this.columnDateembauche});
            this.lVVisiteurs.HideSelection = false;
            this.lVVisiteurs.Location = new System.Drawing.Point(48, 46);
            this.lVVisiteurs.Name = "lVVisiteurs";
            this.lVVisiteurs.Size = new System.Drawing.Size(670, 341);
            this.lVVisiteurs.TabIndex = 0;
            this.lVVisiteurs.UseCompatibleStateImageBehavior = false;
            this.lVVisiteurs.View = System.Windows.Forms.View.Details;
            // 
            // BTNQuitter
            // 
            this.BTNQuitter.Location = new System.Drawing.Point(699, 404);
            this.BTNQuitter.Name = "BTNQuitter";
            this.BTNQuitter.Size = new System.Drawing.Size(75, 23);
            this.BTNQuitter.TabIndex = 1;
            this.BTNQuitter.Text = "Quitter";
            this.BTNQuitter.UseVisualStyleBackColor = true;
            this.BTNQuitter.Click += new System.EventHandler(this.BTNQuitter_Click);
            // 
            // columnMatricule
            // 
            this.columnMatricule.Text = "Matricule";
            // 
            // columnNom
            // 
            this.columnNom.Text = "Nom";
            // 
            // columnPrenom
            // 
            this.columnPrenom.Text = "Prenom";
            this.columnPrenom.Width = 80;
            // 
            // columnAdresse
            // 
            this.columnAdresse.Text = "Adresse";
            this.columnAdresse.Width = 120;
            // 
            // columnCp
            // 
            this.columnCp.Text = "Code postal";
            this.columnCp.Width = 100;
            // 
            // columnVille
            // 
            this.columnVille.Text = "Ville";
            this.columnVille.Width = 100;
            // 
            // columnDateembauche
            // 
            this.columnDateembauche.Text = "Date embauche";
            this.columnDateembauche.Width = 100;
            // 
            // FVisiteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNQuitter);
            this.Controls.Add(this.lVVisiteurs);
            this.Name = "FVisiteurs";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FVisiteurs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lVVisiteurs;
        private System.Windows.Forms.Button BTNQuitter;
        private System.Windows.Forms.ColumnHeader columnMatricule;
        private System.Windows.Forms.ColumnHeader columnNom;
        private System.Windows.Forms.ColumnHeader columnPrenom;
        private System.Windows.Forms.ColumnHeader columnAdresse;
        private System.Windows.Forms.ColumnHeader columnCp;
        private System.Windows.Forms.ColumnHeader columnVille;
        private System.Windows.Forms.ColumnHeader columnDateembauche;
    }
}