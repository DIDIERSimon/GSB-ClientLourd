using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;


namespace Persistance
{
	/// <summary>
	/// Gère la connexion à Mysql
	/// </summary>
	public class Connexion
	{
		/// <summary>
		/// Etablit et retourne la connexion à mysql. Exception gérée si probleme de connexion.
		/// </summary>
		private static MySql.Data.MySqlClient.MySqlConnection cnx = null;
		/// <summary>
		/// Connexion à MySql
		/// </summary>
		/// <returns>MysqlConnexion</returns>
		public static MySqlConnection GetConnexion()
		{
			string strConnexion;
			try
			{
				strConnexion = ConfigurationManager.ConnectionStrings["Cnxppe3"].ConnectionString;
				cnx = new MySqlConnection(strConnexion);
				cnx.Open();
			}
			catch (MySql.Data.MySqlClient.MySqlException me)
			{
				MessageBox.Show("Erreur de connexion à la base de données.\n" + me.ToString());
			}
			return cnx;
		}
	}
}

