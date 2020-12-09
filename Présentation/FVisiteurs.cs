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
    public partial class FVisiteurs : Form
    {
        public FVisiteurs()
        {
            InitializeComponent();
        }

        private void BTNQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void FVisiteurs_Load(object sender, EventArgs e)
        {
            //On récupère tous les clients
            List<Visiteur> visiteurs = DAOVisiteur.GetVisiteur();
            //On vérifique la liste des visiteurs n'est pas vide
            if (visiteurs != null)
            {
                //On insère dans un tableau tous les clients
                foreach (Visiteur visiteur in visiteurs)
                {
                    string[] row = { visiteur.MatriculeVisiteur, visiteur.NomVisiteur, visiteur.PrenomVisiteur, visiteur.AdresseVisiteur, visiteur.CpVisiteur, visiteur.VilleVisiteur, visiteur.DateEmbaucheVisiteur.ToString() };
                    ListViewItem listViewItem = new ListViewItem(row);
                    lVVisiteurs.Items.Add(listViewItem);
                }
            }
        }
    }
}
