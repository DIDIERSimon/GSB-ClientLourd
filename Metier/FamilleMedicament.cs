using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3.Metier
{
    /// <summary>
    /// Représente la FamilleMedicament en tant qu'objet métier ; correspond à la table FamilleMedicament de la BDD.
    /// </summary>
    class FamilleMedicament
    {
        #region Attributs privés
        private string _CodeFam;
        private string _LibelleFam;
        #endregion

        #region Constructeurs
        /// <summary>
        /// Initialise une nouvelle instance de la classe FamileMedicament qui est vide.
        /// </summary>
        public FamilleMedicament()
        {
            CodeFam = LibelleFam = " ";
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe FamilleMedicament à partir des paramètres passés.
        /// </summary>
        public FamilleMedicament(string codeFam, string libelleFam) : this()
        {
            CodeFam = codeFam;
            LibelleFam = libelleFam;
        }
        #endregion

        #region Propriétes (Accesseurs en L/E)
        /// <summary>
        /// Obtient ou défini le code de la famille de medicament.
        /// </summary>
        public string CodeFam { get => _CodeFam; set => _CodeFam = value; }
        /// <summary>
        /// Obtient ou défini le libelle de la famille de medicament.
        /// </summary> 
        public string LibelleFam { get => _LibelleFam; set => _LibelleFam = value; }
        #endregion

        #region Méthodes

        /// <summary>
        /// Retourne une chaine qui représente l'objet actuel.
        /// </summary>
        public override string ToString()
        {
            string laFamilleMedicament;
            laFamilleMedicament = String.Concat("Code de la famille : ", CodeFam, "Libelle famille : ", LibelleFam);
            return laFamilleMedicament;
        }
        #endregion


    }
}
