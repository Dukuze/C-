using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dll_Voiture_Vehicule
{
    class Voiture : Vehicule
    {
        private int nbVitesse;
        private string typeBoite;
        private int v;

        public Voiture(string immat, string couleur, string typeBoite, int nbVitesse)
            : base(immat, couleur)
        {
            this.typeBoite = typeBoite;
            this.nbVitesse = nbVitesse;

        }
        public Voiture(string immat, string typeBoite, int nbVitesse)
            : this(immat, "rouge", typeBoite, nbVitesse)
        {

        }
        public Voiture(string immat, int nbVitesse)
            : this(immat, "rouge", "manuelle", nbVitesse)
        { }



        public override string ToString()
        {
            return base.ToString() + nbVitesse + "/" + typeBoite;
        }
    }
}
