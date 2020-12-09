using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3.Metier
{
    /// <summary>
    /// Représente la Medicament en tant qu'objet métier ; correspond à la table Medicament de la BDD.
    /// </summary>
    public class Medicament
    {
        #region Attributs privés
        private string _DepotLegalMed;
        private string _NomCommercialMed;
        private string _CompositionMed;
        private string _EffetsMed;
        private string _ContreindicMed;
        private string _PrixEchantillonMed;
        #endregion

        #region Constructeurs
        /// <summary>
        /// Initialise une nouvelle instance de la classe Medicament qui est vide.
        /// </summary>
        public Medicament()
        {
           DepotLegalMed = NomCommercialMed = CompositionMed = EffetsMed = ContreindicMed = PrixEchantillonMed = " ";
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe Medicament à partir des paramètres passés.
        /// </summary>
        public Medicament(string depotLegalMed, string nomCommercialMed, string compositionMed, string effetsMed, string contreindicMed, string prixEchantillonMed) : this()
        {
            DepotLegalMed = depotLegalMed;
            NomCommercialMed = nomCommercialMed;
            CompositionMed = compositionMed;
            EffetsMed = effetsMed;
            ContreindicMed = contreindicMed;
            PrixEchantillonMed = prixEchantillonMed;
        }
        #endregion

        #region Propriétes (Accesseurs en L/E)
        /// <summary>
        /// Obtient ou défini le depot legale du medicament.
        /// </summary>
        public string DepotLegalMed { get => _DepotLegalMed; set => _DepotLegalMed = value; }
        /// <summary>
        /// Obtient ou défini le nom du commercial du medicament.
        /// </summary> 
        public string NomCommercialMed { get => _NomCommercialMed; set => _NomCommercialMed = value; }
        /// <summary>
        /// Obtient ou défini la composition du medicament.
        /// </summary> 
        public string CompositionMed { get => _CompositionMed; set => _CompositionMed = value; }
        /// <summary>
        /// Obtient ou défini les effets du medicament.
        /// </summary> 
        public string EffetsMed { get => _EffetsMed; set => _EffetsMed = value; }
        /// <summary>
        /// Obtient ou défini les contre indication du medicament.
        /// </summary> 
        public string ContreindicMed { get => _ContreindicMed; set => _ContreindicMed = value; }
        /// <summary>
        /// Obtient ou défini le prix de l'echantillon du medicament.
        /// </summary> 
        public string PrixEchantillonMed { get => _PrixEchantillonMed; set => _PrixEchantillonMed = value; }
        #endregion

        #region Méthodes

        /// <summary>
        /// Retourne une chaine qui représente l'objet actuel.
        /// </summary>
        public override string ToString()
        {
            string leMedicament;
            leMedicament = String.Concat("Le depot legal du medicament : ", DepotLegalMed, "Le nom du commercial : ", NomCommercialMed, "La composition : ", CompositionMed, "Les Effets : ", EffetsMed, "Les contre Indication : ", ContreindicMed, "Le prix de l'echantillon", PrixEchantillonMed);
            return leMedicament;
        }
        #endregion

    }
}
