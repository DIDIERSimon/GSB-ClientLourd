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
    class TypePraticien
    {
        #region Attributs privés
        private string _CodeTypePraticien;
        private string _LibelleTypePraticien;
        private string _LieuTypePraticien;
        #endregion

        #region Constructeurs
        /// <summary>
        /// Initialise une nouvelle instance de la classe TypePraticien qui est vide.
        /// </summary>
        public TypePraticien()
        {
           CodeTypePraticien = LibelleTypePraticien = LieuTypePraticien = " ";
        }
        /// <summary>
        /// Initialise une nouvelle instance de la classe Praticien à partir des paramètres passés.
        /// </summary>
        public TypePraticien(string codeTypePraticien, string libelleTypePraticien, string lieuTypePraticien)
        {
            CodeTypePraticien = codeTypePraticien;
            LibelleTypePraticien = libelleTypePraticien;
            LieuTypePraticien = lieuTypePraticien;
        }
        #endregion

        #region Propriétes (Accesseurs en L/E)
        /// <summary>
        /// Obtient ou défini le code du type praticien.
        /// </summary>
        public string CodeTypePraticien { get => _CodeTypePraticien; set => _CodeTypePraticien = value; }
        /// <summary>
        /// Obtient ou défini le libelle du type praticien.
        /// </summary>
        public string LibelleTypePraticien { get => _LibelleTypePraticien; set => _LibelleTypePraticien = value; }
        /// <summary>
        /// Obtient ou défini le lieu du type praticien.
        /// </summary>
        public string LieuTypePraticien { get => _LieuTypePraticien; set => _LieuTypePraticien = value; }
        #endregion

        #region Méthodes

        /// <summary>
        /// Retourne une chaine qui représente l'objet actuel.
        /// </summary>
        public override string ToString()
        {
            string leTypePraticien;
            leTypePraticien = String.Concat("Le code : ", CodeTypePraticien, "Le libelle : ", LibelleTypePraticien, "Le lieu : ", LieuTypePraticien);
            return leTypePraticien;
        }
        #endregion



    }
}
