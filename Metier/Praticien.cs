using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3.Metier
{
    /// <summary>
    /// Représente le Praticien en tant qu'objet métier ; correspond à la table Praticien de la BDD.
    /// </summary>
    public class Praticien
    {
        #region Attributs privés
        private string _NumPraticien;
        private string _NomPraticien;
        private string _PrenomPraticien;
        private string _AdressePraticien;
        private string _CpPraticien;
        private string _VillePraticien;
        private string _CoefNotorietePraticien;
        #endregion

        #region Constructeurs
        /// <summary>
        /// Initialise une nouvelle instance de la classe Praticien qui est vide.
        /// </summary>
        public Praticien()
        {
            NumPraticien = NomPraticien = PrenomPraticien = AdressePraticien = CpPraticien = VillePraticien = CoefNotorietePraticien = " ";
        }
        /// <summary>
        /// Initialise une nouvelle instance de la classe Praticien à partir des paramètres passés.
        /// </summary>
        public Praticien(string numPraticien, string nomPraticien, string prenomPraticien, string adressePraticien, string cpPraticien, string villePraticien, string coefNotorietePraticien)
        {
            NumPraticien = numPraticien;
            NomPraticien = nomPraticien;
            PrenomPraticien = prenomPraticien;
            AdressePraticien = adressePraticien;
            CpPraticien = cpPraticien;
            VillePraticien = villePraticien;
            CoefNotorietePraticien = coefNotorietePraticien;
        }
        #endregion

        #region Propriétes (Accesseurs en L/E)
        /// <summary>
        /// Obtient ou défini le numero du praticien.
        /// </summary>
        public string NumPraticien { get => _NumPraticien; set => _NumPraticien = value; }
        /// <summary>
        /// Obtient ou défini le nom du praticien.
        /// </summary>
        public string NomPraticien { get => _NomPraticien; set => _NomPraticien = value; }
        /// <summary>
        /// Obtient ou défini le prenom du praticien.
        /// </summary>
        public string PrenomPraticien { get => _PrenomPraticien; set => _PrenomPraticien = value; }
        /// <summary>
        /// Obtient ou défini l'adresse du praticien.
        /// </summary>
        public string AdressePraticien { get => _AdressePraticien; set => _AdressePraticien = value; }
        /// <summary>
        /// Obtient ou défini le code postale du praticien.
        /// </summary>
        public string CpPraticien { get => _CpPraticien; set => _CpPraticien = value; }
        /// <summary>
        /// Obtient ou défini la ville du praticien.
        /// </summary>
        public string VillePraticien { get => _VillePraticien; set => _VillePraticien = value; }
        /// <summary>
        /// Obtient ou défini le coef de notoriete du praticien.
        /// </summary>
        public string CoefNotorietePraticien { get => _CoefNotorietePraticien; set => _CoefNotorietePraticien = value; }
        #endregion

        #region Méthodes

        /// <summary>
        /// Retourne une chaine qui représente l'objet actuel.
        /// </summary>
        public override string ToString()
        {
            string lePraticien;
            lePraticien = String.Concat("Le num : ", NumPraticien, "Le nom : ", NomPraticien, "Le prenom : ", PrenomPraticien, "L'adresse : ", AdressePraticien, " Le code postale : ", CpPraticien, "La ville : ", VillePraticien, "Le coef de notoriete : ", CoefNotorietePraticien);
            return lePraticien;
        }
        #endregion
    }
}
