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
    public partial class FComptes_Rendus : Form
    {
        List<RapportVisite> RapportsListe = new List<RapportVisite>();
        List<Praticien> praticiens = DAOPraticien.GetPraticien();
        int index = 0;
        Boolean nouveau = false;


        public FComptes_Rendus()

        {
            InitializeComponent();
        }





        private void FComptes_Rendus_Load(object sender, EventArgs e)
        {
            List<RapportVisite> Rapport = DAORapportVisite.GetRapportVisite();

            foreach (RapportVisite Rapports in Rapport)
            {
                //On crée un tableau de chaine de caractères : chaque cellule contient un attribut chaine de caractères du client
                RapportVisite unRapport = new RapportVisite(Rapports.NumRapport, Rapports.DateRapport, Rapports.BilanRapport, Rapports.MotifRapport, Rapports.Pra_numRapport, Rapports.Vis_matriculeRapport);
                RapportsListe.Add(unRapport);

            }
            RapportVisite Rapportaffiche = RapportsListe[0];
            TBXNumRapport.Text = Rapportaffiche.NumRapport;
            TBXMotif.Text = Rapportaffiche.MotifRapport;
            TBXBilan.Text = Rapportaffiche.BilanRapport;
            BTNPrecedent.Enabled = false;

            foreach (Praticien praticien in praticiens)
            {

                string nomPrenom = praticien.NomPraticien + " " + praticien.PrenomPraticien;

                CBXPraticien.Items.Add(nomPrenom);
            }
            CBXPraticien.SelectedIndex = Rapportaffiche.Pra_numRapport - 1;
        }

        private void BTNSuivant_Click(object sender, EventArgs e)
        {
            if (index < RapportsListe.Count - 1)
            {
                index += 1;
                if (index == RapportsListe.Count - 1)
                {
                    BTNSuivant.Enabled = false;
                }
                RapportVisite Rapportaffiche = RapportsListe[index];
                TBXNumRapport.Text = Rapportaffiche.NumRapport;
                TBXDateRapport.Text = Rapportaffiche.DateRapport;
                TBXMotif.Text = Rapportaffiche.MotifRapport;
                TBXBilan.Text = Rapportaffiche.BilanRapport;
                CBXPraticien.SelectedIndex = Rapportaffiche.Pra_numRapport - 1;
                BTNPrecedent.Enabled = true;
            }
        }

        private void BTNPrecedent_Click(object sender, EventArgs e)
        {
            BTNSuivant.Enabled = true;
            if (index > 0)
            {
                index -= 1;
                if (index == 0)
                {
                    BTNPrecedent.Enabled = false;
                }
                RapportVisite Rapportaffiche = RapportsListe[index];
                TBXNumRapport.Text = Rapportaffiche.NumRapport;
                TBXDateRapport.Text = Rapportaffiche.DateRapport;
                TBXMotif.Text = Rapportaffiche.MotifRapport;
                TBXBilan.Text = Rapportaffiche.BilanRapport;
                CBXPraticien.SelectedIndex = Rapportaffiche.Pra_numRapport - 1;
            }
            if (nouveau)
            {
                index = RapportsListe.Count - 1;
                TBXNumRapport.Enabled = false;
                this.nouveau = false;
            }
        }

        private void BTNNouveau_Click(object sender, EventArgs e)
        {
            index = RapportsListe.Count;
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            TBXDateRapport.Text = sqlFormattedDate;
            TBXNumRapport.Text = "";
            TBXNumRapport.Enabled = true;
            TBXMotif.Text = "";
            TBXBilan.Text = "";
            CBXPraticien.SelectedIndex = 0;
            this.nouveau = true;
            BTNEnregistrer.Enabled = true;
            BTNEnregistrer.Visible = true;
        }

        private void BTNEnregistrer_Click(object sender, EventArgs e)
        {
            if (nouveau)
            {
                RapportVisite nouveauRapport = new RapportVisite();
                nouveauRapport.NumRapport = TBXNumRapport.Text;
                char[] separateurs = new char[] { '/', ':', ' ', '-' };
                string sqlFormattedDate = "1970-01-01";
                List<string> eltDate = new List<string>(TBXDateRapport.Text.Split(separateurs));
                if (eltDate.Count == 3)
                {
                    DateTime newDate = new DateTime(Convert.ToInt32(eltDate[0]), Convert.ToInt32(eltDate[1]), Convert.ToInt32(eltDate[2]));
                    sqlFormattedDate = newDate.ToString("yyyy-MM-dd HH:mm:ss");
                }
                else if (eltDate.Count == 6)
                {
                    DateTime newDate = new DateTime(Convert.ToInt32(eltDate[0]), Convert.ToInt32(eltDate[1]), Convert.ToInt32(eltDate[2]), Convert.ToInt32(eltDate[3]), Convert.ToInt32(eltDate[4]), Convert.ToInt32(eltDate[5]));
                    sqlFormattedDate = newDate.ToString("yyyy-MM-dd HH:mm:ss");
                }
                nouveauRapport.DateRapport = sqlFormattedDate;
                nouveauRapport.BilanRapport = TBXBilan.Text;
                nouveauRapport.MotifRapport = TBXMotif.Text;
                nouveauRapport.Pra_numRapport= CBXPraticien.SelectedIndex + 1;
                if (DAORapportVisite.CreateRapport(nouveauRapport))
                {
                    RapportsListe.Add(nouveauRapport);
                };

            }
            else
            {
                RapportVisite rapportModifie = new RapportVisite();
                char[] separateurs = new char[] { '/', ':', ' ', '-' };
                string sqlFormattedDate = "1970-01-01";
                List<string> eltDate = new List<string>(TBXDateRapport.Text.Split(separateurs));
                if (eltDate.Count == 3)
                {
                    DateTime newDate = new DateTime(Convert.ToInt32(eltDate[0]), Convert.ToInt32(eltDate[1]), Convert.ToInt32(eltDate[2]));
                    sqlFormattedDate = newDate.ToString("yyyy-MM-dd HH:mm:ss");
                }
                else if (eltDate.Count == 6)
                {
                    DateTime newDate = new DateTime(Convert.ToInt32(eltDate[0]), Convert.ToInt32(eltDate[1]), Convert.ToInt32(eltDate[2]), Convert.ToInt32(eltDate[3]), Convert.ToInt32(eltDate[4]), Convert.ToInt32(eltDate[5]));
                    sqlFormattedDate = newDate.ToString("yyyy-MM-dd HH:mm:ss");
                }
                rapportModifie.NumRapport = TBXNumRapport.Text;
                rapportModifie.DateRapport = sqlFormattedDate;
                rapportModifie.BilanRapport = TBXBilan.Text;
                rapportModifie.MotifRapport = TBXMotif.Text;
                rapportModifie.Pra_numRapport = CBXPraticien.SelectedIndex + 1;
                DAORapportVisite.UpdateRapport(rapportModifie);
                this.RapportsListe[index] = rapportModifie;
            }
        }

        private void BTNQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
