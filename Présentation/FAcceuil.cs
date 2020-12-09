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
    public partial class FAcceuil : Form
    {
        public FAcceuil()
        {
            InitializeComponent();
        }

        private void FAcceuil_Load(object sender, EventArgs e)
        {

        }

        private void BTNValider_Click(object sender, EventArgs e)
        {
            if (TBIdentifiant.Text == "swiss" && TBMotDePasse.Text == "18-jun-2003")
            {
                this.Hide();
                FGestionComptesRendu fGestionComptesRendu = new FGestionComptesRendu();
                fGestionComptesRendu.Closed += (s, arg) => this.Close();
                fGestionComptesRendu.Show();
            }
            else
            {
                MessageBox.Show("L'identifiant ou le Mot de passe est incorrect");
            }

        }


    }
}
