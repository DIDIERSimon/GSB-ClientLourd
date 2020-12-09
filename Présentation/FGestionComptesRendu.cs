using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3_
{
    public partial class FGestionComptesRendu : Form
    {
        public FGestionComptesRendu()
        {
            InitializeComponent();
        }

        private void FGestionComptesRendu_Load(object sender, EventArgs e)
        {

        }

        private void BTNComptesRendu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FComptes_Rendus fComptes_Rendus = new FComptes_Rendus();
            fComptes_Rendus.Closed += (s, args) => this.Close();
            fComptes_Rendus.Show();
        }

        private void BTNVisiteurs_Click(object sender, EventArgs e)
        {
            this.Hide();
            FVisiteurs fVisiteurs = new FVisiteurs();
            fVisiteurs.Closed += (s, args) => this.Close();
            fVisiteurs.Show();

        }

        private void BTNPraticiens_Click(object sender, EventArgs e)
        {
            this.Hide();
            FPraticiens fPraticiens = new FPraticiens();
            fPraticiens.Closed += (s, args) => this.Close();
            fPraticiens.Show();

        }

        private void BTNMedicaments_Click(object sender, EventArgs e)
        {
            this.Hide();
            FMedicaments fMedicaments = new FMedicaments();
            fMedicaments.Closed += (s, args) => this.Close();
            fMedicaments.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
