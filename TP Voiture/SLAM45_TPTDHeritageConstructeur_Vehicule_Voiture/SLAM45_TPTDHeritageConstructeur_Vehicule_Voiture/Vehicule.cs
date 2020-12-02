using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SLAM45_TPTDHeritageConstructeur_Vehicule_Voiture
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
