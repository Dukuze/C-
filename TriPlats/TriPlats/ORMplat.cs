using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriPlats
{
   static  class ORMplat
    {
        private static MySqlConnection conn = null;

        public static bool Connexion()
        {
            string sConnexion = @"server=localhost;userid=root;password=;database=resto";
            conn = new MySqlConnection(sConnexion);
            conn.Open();
            return (conn.State == System.Data.ConnectionState.Open);
            //if (conn.State == System.Data.ConnectionState.Open)
            //    return true;
            //else
            //    return false;

        }

        public static bool ModifierPlat (Plat p)
        {
            MySqlCommand cmd = conn.CreateCommand();
            string reqI = "UPDATE plat SET categorie='" + p.GetCategorie() + "', calories = " + p.GetNbCalorie() + ", prix = " + p.GetPrix() + ", vegan = " + p.GetVegan() +
            ",glutenFree = " + p.GetGlutenFree() +
            " WHERE nom = '" + p.GetNom() + "'";
            cmd.CommandText = reqI;
            int nbMaj = cmd.ExecuteNonQuery();
            return (nbMaj == 1);
        }

    }
}
