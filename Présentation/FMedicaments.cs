using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using PPE3.Metier;

namespace PPE3_
{
    public partial class FMedicaments : Form
    {
        public FMedicaments()
        {
            InitializeComponent();
        }

        private void FMedicaments_Load(object sender, EventArgs e)
        {
            //On récupère la liste des médicaments
            List<Medicament> medicaments = DAOMedicament.GetMedicament();

            //Il faut vérifier que cette liste n'est pas vide 
            if (medicaments != null)
            {
                //On met chaque medicament dans un tableau
                foreach (Medicament medicament in medicaments)
                {
                    string[] row = { medicament.DepotLegalMed, medicament.NomCommercialMed, medicament.CompositionMed, medicament.EffetsMed, medicament.ContreindicMed, medicament.PrixEchantillonMed.ToString() };
                    ListViewItem listViewItem = new ListViewItem(row);
                    LVMedicament.Items.Add(listViewItem);
                }
            }

        }

        private void BTNQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
