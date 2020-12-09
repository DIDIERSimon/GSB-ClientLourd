using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PPE3.Metier;
using Persistance;

namespace DAO
{
	public class DAOMedicament
	{

		///<summary>
		///Fournit la liste de tous les rapportvisites.
		///</summary>
		///<returns>
		///Une collection (list) de rapportvisites
		///</returns>
		public static List<Medicament> GetMedicament()
		{
			//Collection de rapportvisite qui sera retournée à la couche présentation.
			//Cette dernière ne doit travailler qu'avec des objets métiers.
			List<Medicament> medicament = null;
			//La requête à exécuter pour sélectionner tous les rapportvisites
			string selectMedicament = "SELECT MED_DEPOTLEGAL, MED_NOMCOMMERCIAL, MED_COMPOSITION, MED_EFFETS, MED_CONTREINDIC, MED_PRIXECHANTILLON FROM medicament";
			//On appelle la couche persistance pour faire exécuter la requête. On exécute la méthode statique Select de la classe DBInterface
			//Rappel : la méthode Select retourne un datatable
			DataTable dataTable = DBInterface.Select(selectMedicament);
			//Le Datatable retourné est transformé en collection de rapportvisite
			if (dataTable != null)
			{
				medicament = new List<Medicament>();
				foreach (DataRow row in dataTable.Rows)
				{
					Medicament medicaments = CreerMedicament(row);
					medicament.Add(medicaments);
				}
			}
			return medicament;
		}

		//Construction d'une instance de rapportvisite à partir d'une ligne du résultat de la requête.
		//Rappel : on souhaite que la couche "Présentation" ne soit pas liée à la base de données.
		//Elle ne doit travailler qu'avec des objets métiers.
		private static Medicament CreerMedicament(DataRow row)
		{
			Medicament medicament = new Medicament();
			medicament.DepotLegalMed = row["MED_DEPOTLEGAL"].ToString();
			medicament.NomCommercialMed = row["MED_NOMCOMMERCIAL"].ToString();
			medicament.CompositionMed = row["MED_COMPOSITION"].ToString();
			medicament.EffetsMed = row["MED_EFFETS"].ToString();
			medicament.ContreindicMed = row["MED_CONTREINDIC"].ToString();
			medicament.PrixEchantillonMed = row["MED_PRIXECHANTILLON"].ToString();
			return medicament;
		}
	}
}
