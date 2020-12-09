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
    public partial class FPraticiens : Form
    {
        public FPraticiens()
        {
            InitializeComponent();
        }

        private void BTNQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FPraticiens_Load(object sender, EventArgs e)
        {
            //On récupère tous les clients
            List<Praticien> praticiens = DAOPraticien.GetPraticien();
            //On vérifique la liste des visiteurs n'est pas vide
            if (praticiens != null)
            {
                //On insère dans un tableau tous les clients
                foreach (Praticien praticien in praticiens)
                {
                    string[] row = { praticien.NumPraticien, praticien.NomPraticien, praticien.PrenomPraticien, praticien.AdressePraticien, praticien.CpPraticien, praticien.VillePraticien, praticien.CoefNotorietePraticien };
                    ListViewItem listViewItem = new ListViewItem(row);
                    lVPraticien.Items.Add(listViewItem);
                }
            }
        }
    }
}
