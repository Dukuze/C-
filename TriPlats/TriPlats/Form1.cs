using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TriPlats
{
    public partial class FormTriPlats : Form
    {
       
        public FormTriPlats()
        {
            List<Plat> listePlats;
            InitializeComponent();
            listePlats = new List<Plat>();


            listePlats.Add(new Plat("plats1", 31, "dessert", 3000));
            listePlats.Add(new Plat("plats2", 25, "entrée", 6500));
            listePlats.Add(new Plat("plats3", 52, "entrée", 8500));

            listBox1.Items.AddRange(listePlats.ToArray());

        }

        private void btdefaut_Click(object sender, EventArgs e)
        {
            
           
       
        }

        private void bt_connexion_Click(object sender, EventArgs e)
        {
            bool etatC = ORMplat.Connexion ();
            if (etatC)
                lbetatconnexion.Text = "ouverte";
            else
                lbetatconnexion.Text = "fermee";

        }
    }
}
