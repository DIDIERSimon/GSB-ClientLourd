using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3.Metier
{
    /// <summary>
    /// Représente le Visiteur en tant qu'objet métier ; correspond à la table Visiteur de la BDD.
    /// </summary>
    public class Visiteur
    {
        #region Attributs privés
        private string _MatriculeVisiteur;
        private string _NomVisiteur;
        private string _PrenomVisiteur;
        private string _AdresseVisiteur;
        private string _CpVisiteur;
        private string _VilleVisiteur;
        private string _DateEmbaucheVisiteur;
        #endregion

        #region Constructeurs
        /// <summary>
        /// Initialise une nouvelle instance de la classe Visiteur qui est vide.
        /// </summary>
        public Visiteur()
        {
            MatriculeVisiteur = NomVisiteur = PrenomVisiteur = NomVisiteur = AdresseVisiteur = CpVisiteur = VilleVisiteur = DateEmbaucheVisiteur = " ";
        }
        /// <summary>
        /// Initialise une nouvelle instance de la classe Visiteur à partir des paramètres passés.
        /// </summary>
        public Visiteur(string matriculeVisiteur, string nomVisiteur, string prenomVisiteur, string adresseVisiteur, string cpVisiteur, string villeVisiteur, string dateEmbaucheVisiteur)
        {
            MatriculeVisiteur = matriculeVisiteur;
            NomVisiteur = nomVisiteur;
            PrenomVisiteur = prenomVisiteur;
            AdresseVisiteur = adresseVisiteur;
            CpVisiteur = cpVisiteur;
            VilleVisiteur = villeVisiteur;
            DateEmbaucheVisiteur = dateEmbaucheVisiteur;
        }
        #endregion


        #region Propriétes (Accesseurs en L/E)
        /// <summary>
        /// Obtient ou défini le matricule du visiteur.
        /// </summary>
        public string MatriculeVisiteur { get => _MatriculeVisiteur; set => _MatriculeVisiteur = value; }
        /// <summary>
        /// Obtient ou défini le nom du visiteur.
        /// </summary>
        public string NomVisiteur { get => _NomVisiteur; set => _NomVisiteur = value; }
        /// <summary>
        /// Obtient ou défini le prenom du visiteur.
        /// </summary>
        public string PrenomVisiteur { get => _PrenomVisiteur; set => _PrenomVisiteur = value; }
        /// <summary>
        /// Obtient ou défini l'adresse du visiteur.
        /// </summary>
        public string AdresseVisiteur { get => _AdresseVisiteur; set => _AdresseVisiteur = value; }
        /// <summary>
        /// Obtient ou défini le Code postale du visiteur.
        /// </summary>
        public string CpVisiteur { get => _CpVisiteur; set => _CpVisiteur = value; }
        /// <summary>
        /// Obtient ou défini la ville du visiteur.
        /// </summary>
        public string VilleVisiteur { get => _VilleVisiteur; set => _VilleVisiteur = value; }
        /// <summary>
        /// Obtient ou défini la date d'embauche du visiteur.
        /// </summary>
        public string DateEmbaucheVisiteur { get => _DateEmbaucheVisiteur; set => _DateEmbaucheVisiteur = value; }
        #endregion

        #region Méthodes

        /// <summary>
        /// Retourne une chaine qui représente l'objet actuel.
        /// </summary>
        public override string ToString()
        {
            string leVisiteur;
            leVisiteur = String.Concat("Le matricule : ", MatriculeVisiteur, "Le nom : ", NomVisiteur, "Le prenom : ", PrenomVisiteur, "L'adresse : ", AdresseVisiteur, " Le code postale : ", CpVisiteur, "La ville : ", VilleVisiteur, "La date d'embauche : ", DateEmbaucheVisiteur);
            return leVisiteur;
        }
        #endregion
    }
}
