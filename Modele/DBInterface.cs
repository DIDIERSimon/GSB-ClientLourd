using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Persistance
{
    public class DBInterface
    {
		/// <summary>
		/// Execute une requete Select (Read du CRUD)
		/// </summary>
		/// <param name="req"></param>
		/// <returns></returns>
		public static DataTable Select(String req)
		{
			MySqlConnection cnx = null;
			DataTable dataTable = null;
			try
			{
				//La méthode GetConnexion de la classe Connexion est statique : méthode à portée classe.
				cnx = Connexion.GetConnexion();
				//On crée une commande mysql comme dans le TP précédent
				MySqlCommand cmd = new MySqlCommand();
				cmd.Connection = cnx;
				cmd.CommandText = req;
				//On crée le dataadapter qui communique avec la BDD
				MySqlDataAdapter da = new MySqlDataAdapter();
				da.SelectCommand = cmd;
				// Construire le DataSet. Ce DataSet porte un nom générique (et non le nom d'une table précise).
				DataSet ds = new DataSet();
				da.Fill(ds, "resultat");
				dataTable = ds.Tables["resultat"];
				cnx.Close();

			}
			catch (MySql.Data.MySqlClient.MySqlException me)
			{
				MessageBox.Show("Erreur de connexion à la base de données.\n" + me.ToString());
			}
			finally
			{
				// S'il y a eu un problème, la connexion
				// peut être encore ouverte, dans ce cas
				// il faut la fermer.
				if (cnx != null)
					cnx.Close();
			}
			// Retourner la table résultat de la requête
			return dataTable;
		}

		/// <summary>
		/// Execute une requête Update (U du CRUD)
		/// </summary>
		/// <param name="req"></param>
		/// <returns>Le nombre de lignes affectées par la requête.</returns>
		public static int Update(string req)
		{
			MySqlConnection cnx = null;
			int rowsAffected = 0;
			try
			{
				cnx = Connexion.GetConnexion();
				MySqlCommand cmd = new MySqlCommand();
				cmd.Connection = cnx;
				cmd.CommandText = req;
				rowsAffected = cmd.ExecuteNonQuery();
			}
			catch (MySql.Data.MySqlClient.MySqlException me)
			{
				MessageBox.Show("Erreur de connexion à la base de données.\n" + me.ToString());
			}
			finally
			{
				// S'il y a eu un problème, la connexion
				// peut être encore ouverte, dans ce cas
				// il faut la fermer.
				if (cnx != null)
					cnx.Close();
			}
			return rowsAffected;
		}

		/// <summary>
		/// Execute une requête Insert (C du CRUD)
		/// </summary>
		/// <param name="req"></param>
		/// <returns>Le nombre de lignes affectées par la requête.</returns>
		public static int Insert(string req)
		{
			MySqlConnection cnx = null;
			int rowsAffected = 0;
			try
			{
				cnx = Connexion.GetConnexion();
				MySqlCommand cmd = new MySqlCommand();
				cmd.Connection = cnx;
				cmd.CommandText = req;
				rowsAffected = cmd.ExecuteNonQuery();
			}
			catch (MySql.Data.MySqlClient.MySqlException me)
			{
				MessageBox.Show("Erreur de connexion à la base de données.\n" + me.ToString());
			}
			finally
			{
				// S'il y a eu un problème, la connexion
				// peut être encore ouverte, dans ce cas
				// il faut la fermer.
				if (cnx != null)
					cnx.Close();
			}
			return rowsAffected;
		}

	}
}
