using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dll_Voiture_Vehicule
{
    class Vehicule
    {
        private string couleur;
        private string immat;

        public override string ToString()
        {
            return immat + " : " + couleur + "/";
        }
        public Vehicule(string immat)
        {
            this.immat = immat;
            this.couleur = "verte";
        }
        public Vehicule(string immat, string couleur)
        {
            this.immat = immat;
            this.couleur = couleur;
        }
    }
}
