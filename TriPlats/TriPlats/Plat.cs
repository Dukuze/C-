using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriPlats
{
    public class Plat  : IComparable<Plat>
    {
        private string categories;
        private bool glutenFree;
        private int nbCalorie;
        private string nom;
        private float prix;
        private bool vegan;

        public Plat(string uneCategorie, int unNbCalorie, string unNom, float unPrix)
        {
            this.categories = uneCategorie;
            this.nbCalorie = unNbCalorie;
            this.nom = unNom;
            this.prix = unPrix;
            this.glutenFree = false;
            this.vegan = false;
        }

        public override string ToString(){

           return "nom:" + nom + "/categorie:" + categories + "/prix:" + prix + "/calories:" + nbCalorie + "/glutenFree:" + glutenFree + "/vegan:" + vegan;

        }

        public string GetCategorie(){
            return categories;
        }

        public bool GetVegan()
        {
            return vegan;
        }

        public string GetNom()
        {
            return nom;
        }

        public float GetPrix(){
            return prix;
        }

        public bool GetGlutenFree()
        {
            return glutenFree;
        }

        public int GetNbCalorie(){
            return nbCalorie;
        }

        public int CompareTo(Plat other)
        {
            throw new NotImplementedException();
        }
    }
}
