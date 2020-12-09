using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3.Metier
{
    /// <summary>
    /// Représente le RapportVisite en tant qu'objet métier ; correspond à la table RapportVisite de la BDD.
    /// </summary>
    public class RapportVisite
    {
        #region Attributs privés
        private string _NumRapport;
        private string _DateRapport;
        private string _BilanRapport;
        private string _MotifRapport;
        private int _Pra_numRapport;
        private string _Vis_matriculeRapport;
        #endregion


        #region Constructeurs
        /// <summary>
        /// Initialise une nouvelle instance de la classe RapportVisite qui est vide.
        /// </summary>
        public RapportVisite()
        {
           NumRapport = DateRapport = BilanRapport = MotifRapport = Vis_matriculeRapport = " ";
           Pra_numRapport = 0;
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe RapportVisite à partir des paramètres passés.
        /// </summary>
        public RapportVisite(string numRapport, string dateRapport, string bilanRapport, string motifRapport, int pra_numRapport, string vis_matriculeRapport)
        {
            NumRapport = numRapport;
            DateRapport = dateRapport;
            BilanRapport = bilanRapport;
            MotifRapport = motifRapport;
            Pra_numRapport = pra_numRapport;
            Vis_matriculeRapport = vis_matriculeRapport;

        }
        #endregion


        #region Propriétes (Accesseurs en L/E)
        /// <summary>
        /// Obtient ou défini le numero du rapport.
        /// </summary>
        public string NumRapport { get => _NumRapport; set => _NumRapport = value; }
        /// <summary>
        /// Obtient ou défini la date du rapport.
        /// </summary>
        public string DateRapport { get => _DateRapport; set => _DateRapport = value; }
        /// <summary>
        /// Obtient ou défini le bilan du rapport.
        /// </summary>
        public string BilanRapport { get => _BilanRapport; set => _BilanRapport = value; }
        /// <summary>
        /// Obtient ou défini le motif du rapport.
        /// </summary>
        public string MotifRapport { get => _MotifRapport; set => _MotifRapport = value; }
        /// <summary>
        /// Obtient ou défini le pra_num du rapport.
        /// </summary>
        public int Pra_numRapport { get => _Pra_numRapport; set => _Pra_numRapport = value; }
        /// <summary>
        /// Obtient ou défini le vis_matricule du rapport.
        /// </summary>
        public string Vis_matriculeRapport { get => _Vis_matriculeRapport; set => _Vis_matriculeRapport = value; }
        #endregion

        #region Méthodes

        /// <summary>
        /// Retourne une chaine qui représente l'objet actuel.
        /// </summary>
        public override string ToString()
        {
            string leRapport;
            leRapport = String.Concat("Numéro rapport : ", NumRapport, "Date rapport : ", DateRapport, "Bilan rapport : ", BilanRapport, "Motif rapport : ", MotifRapport, "Praticient Num : ", Pra_numRapport, "Visiteur matricule : ", Vis_matriculeRapport);
            return leRapport;
        }
        #endregion

    }
}
