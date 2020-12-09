namespace PPE3_
{
    partial class FPraticiens
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
            this.lVPraticien = new System.Windows.Forms.ListView();
            this.BTNQuitter = new System.Windows.Forms.Button();
            this.columnNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAdresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCoefnotoriete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lVPraticien
            // 
            this.lVPraticien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNum,
            this.columnNom,
            this.columnPrenom,
            this.columnAdresse,
            this.columnCp,
            this.columnVille,
            this.columnCoefnotoriete});
            this.lVPraticien.HideSelection = false;
            this.lVPraticien.Location = new System.Drawing.Point(12, 12);
            this.lVPraticien.Name = "lVPraticien";
            this.lVPraticien.Size = new System.Drawing.Size(667, 424);
            this.lVPraticien.TabIndex = 0;
            this.lVPraticien.UseCompatibleStateImageBehavior = false;
            this.lVPraticien.View = System.Windows.Forms.View.Details;
            // 
            // BTNQuitter
            // 
            this.BTNQuitter.Location = new System.Drawing.Point(772, 453);
            this.BTNQuitter.Name = "BTNQuitter";
            this.BTNQuitter.Size = new System.Drawing.Size(75, 23);
            this.BTNQuitter.TabIndex = 1;
            this.BTNQuitter.Text = "Quitter";
            this.BTNQuitter.UseVisualStyleBackColor = true;
            this.BTNQuitter.Click += new System.EventHandler(this.BTNQuitter_Click);
            // 
            // columnNum
            // 
            this.columnNum.Text = "Numéro";
            // 
            // columnNom
            // 
            this.columnNom.Text = "Nom";
            this.columnNom.Width = 80;
            // 
            // columnPrenom
            // 
            this.columnPrenom.Text = "Prénom";
            this.columnPrenom.Width = 90;
            // 
            // columnAdresse
            // 
            this.columnAdresse.Text = "Adresse";
            this.columnAdresse.Width = 120;
            // 
            // columnCp
            // 
            this.columnCp.Text = "Code postal";
            this.columnCp.Width = 110;
            // 
            // columnVille
            // 
            this.columnVille.Text = "Ville";
            this.columnVille.Width = 90;
            // 
            // columnCoefnotoriete
            // 
            this.columnCoefnotoriete.Text = "Coeff notoriété";
            this.columnCoefnotoriete.Width = 120;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PPE3_.Properties.Resources.praticien;
            this.pictureBox1.Location = new System.Drawing.Point(685, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 215);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FPraticiens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 502);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTNQuitter);
            this.Controls.Add(this.lVPraticien);
            this.Name = "FPraticiens";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FPraticiens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lVPraticien;
        private System.Windows.Forms.ColumnHeader columnNum;
        private System.Windows.Forms.ColumnHeader columnNom;
        private System.Windows.Forms.ColumnHeader columnPrenom;
        private System.Windows.Forms.ColumnHeader columnAdresse;
        private System.Windows.Forms.ColumnHeader columnCp;
        private System.Windows.Forms.ColumnHeader columnVille;
        private System.Windows.Forms.ColumnHeader columnCoefnotoriete;
        private System.Windows.Forms.Button BTNQuitter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}