namespace PPE3_
{
    partial class FMedicaments
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
            this.label1 = new System.Windows.Forms.Label();
            this.LVMedicament = new System.Windows.Forms.ListView();
            this.columnDepotLegal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNomCommercial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnComposition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEffets = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnContreIndic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrixEchantillon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTNQuitter = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste des Médicaments :";
            // 
            // LVMedicament
            // 
            this.LVMedicament.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDepotLegal,
            this.columnNomCommercial,
            this.columnComposition,
            this.columnEffets,
            this.columnContreIndic,
            this.columnPrixEchantillon});
            this.LVMedicament.HideSelection = false;
            this.LVMedicament.Location = new System.Drawing.Point(13, 49);
            this.LVMedicament.Name = "LVMedicament";
            this.LVMedicament.Size = new System.Drawing.Size(682, 396);
            this.LVMedicament.TabIndex = 1;
            this.LVMedicament.UseCompatibleStateImageBehavior = false;
            this.LVMedicament.View = System.Windows.Forms.View.Details;
            // 
            // columnDepotLegal
            // 
            this.columnDepotLegal.Text = "Dépot légal";
            this.columnDepotLegal.Width = 100;
            // 
            // columnNomCommercial
            // 
            this.columnNomCommercial.Text = "Nom Commercial";
            this.columnNomCommercial.Width = 100;
            // 
            // columnComposition
            // 
            this.columnComposition.Text = "Composition";
            this.columnComposition.Width = 100;
            // 
            // columnEffets
            // 
            this.columnEffets.Text = "Effets";
            this.columnEffets.Width = 100;
            // 
            // columnContreIndic
            // 
            this.columnContreIndic.Text = "Contre indication";
            this.columnContreIndic.Width = 100;
            // 
            // columnPrixEchantillon
            // 
            this.columnPrixEchantillon.Text = "Prix échantillon";
            this.columnPrixEchantillon.Width = 100;
            // 
            // BTNQuitter
            // 
            this.BTNQuitter.Location = new System.Drawing.Point(846, 455);
            this.BTNQuitter.Name = "BTNQuitter";
            this.BTNQuitter.Size = new System.Drawing.Size(75, 23);
            this.BTNQuitter.TabIndex = 5;
            this.BTNQuitter.Text = "Quitter";
            this.BTNQuitter.UseVisualStyleBackColor = true;
            this.BTNQuitter.Click += new System.EventHandler(this.BTNQuitter_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox3.Image = global::PPE3_.Properties.Resources.medic;
            this.pictureBox3.Location = new System.Drawing.Point(727, 87);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(266, 279);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // FMedicaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 541);
            this.Controls.Add(this.BTNQuitter);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.LVMedicament);
            this.Controls.Add(this.label1);
            this.Name = "FMedicaments";
            this.Text = "Médicaments";
            this.Load += new System.EventHandler(this.FMedicaments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView LVMedicament;
        private System.Windows.Forms.ColumnHeader columnDepotLegal;
        private System.Windows.Forms.ColumnHeader columnNomCommercial;
        private System.Windows.Forms.ColumnHeader columnComposition;
        private System.Windows.Forms.ColumnHeader columnEffets;
        private System.Windows.Forms.ColumnHeader columnContreIndic;
        private System.Windows.Forms.ColumnHeader columnPrixEchantillon;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BTNQuitter;
    }
}