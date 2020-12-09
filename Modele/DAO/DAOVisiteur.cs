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
	public class DAOVisiteur
	{

		///<summary>
		///Fournit la liste de tous les rapportvisites.
		///</summary>
		///<returns>
		///Une collection (list) de rapportvisites
		///</returns>
		public static List<Visiteur> GetVisiteur()
		{
			//Collection de rapportvisite qui sera retournée à la couche présentation.
			//Cette dernière ne doit travailler qu'avec des objets métiers.
			List<Visiteur> visiteur = null;
			//La requête à exécuter pour sélectionner tous les rapportvisites
			string selectVisiteur = "SELECT VIS_MATRICULE, VIS_NOM, VIS_PRENOM, VIS_ADRESSE, VIS_CP, VIS_VILLE, VIS_DATEEMBAUCHE FROM visiteur";
			//On appelle la couche persistance pour faire exécuter la requête. On exécute la méthode statique Select de la classe DBInterface
			//Rappel : la méthode Select retourne un datatable
			DataTable dataTable = DBInterface.Select(selectVisiteur);
			//Le Datatable retourné est transformé en collection de rapportvisite
			if (dataTable != null)
			{
				visiteur = new List<Visiteur>();
				foreach (DataRow row in dataTable.Rows)
				{
					Visiteur visiteurs = CreerVisiteur(row);
					visiteur.Add(visiteurs);
				}
			}
			return visiteur;
		}

		//Construction d'une instance de rapportvisite à partir d'une ligne du résultat de la requête.
		//Rappel : on souhaite que la couche "Présentation" ne soit pas liée à la base de données.
		//Elle ne doit travailler qu'avec des objets métiers.
		private static Visiteur CreerVisiteur(DataRow row)
		{
			Visiteur visiteur = new Visiteur();
			visiteur.MatriculeVisiteur = row["VIS_MATRICULE"].ToString();
			visiteur.NomVisiteur = row["VIS_NOM"].ToString();
			visiteur.PrenomVisiteur = row["VIS_PRENOM"].ToString();
			visiteur.AdresseVisiteur = row["VIS_ADRESSE"].ToString();
			visiteur.CpVisiteur = row["VIS_CP"].ToString();
			visiteur.VilleVisiteur = row["VIS_VILLE"].ToString();
			visiteur.DateEmbaucheVisiteur = row["VIS_DATEEMBAUCHE"].ToString();
			return visiteur;
		}
	}
}
