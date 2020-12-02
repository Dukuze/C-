namespace TriPlats
{
    partial class FormTriPlats
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btdefaut = new System.Windows.Forms.Button();
            this.btcatprix = new System.Windows.Forms.Button();
            this.bttricatcalories = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.bt_connexion = new System.Windows.Forms.Button();
            this.lbetatconnexion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(261, 212);
            this.listBox1.TabIndex = 0;
            // 
            // btdefaut
            // 
            this.btdefaut.Location = new System.Drawing.Point(317, 24);
            this.btdefaut.Name = "btdefaut";
            this.btdefaut.Size = new System.Drawing.Size(96, 23);
            this.btdefaut.TabIndex = 1;
            this.btdefaut.Text = "Tri par defaut";
            this.btdefaut.UseVisualStyleBackColor = true;
            this.btdefaut.Click += new System.EventHandler(this.btdefaut_Click);
            // 
            // btcatprix
            // 
            this.btcatprix.Location = new System.Drawing.Point(317, 120);
            this.btcatprix.Name = "btcatprix";
            this.btcatprix.Size = new System.Drawing.Size(96, 23);
            this.btcatprix.TabIndex = 2;
            this.btcatprix.Text = "Tri Categorie Prix";
            this.btcatprix.UseVisualStyleBackColor = true;
            // 
            // bttricatcalories
            // 
            this.bttricatcalories.Location = new System.Drawing.Point(303, 187);
            this.bttricatcalories.Name = "bttricatcalories";
            this.bttricatcalories.Size = new System.Drawing.Size(121, 23);
            this.bttricatcalories.TabIndex = 3;
            this.bttricatcalories.Text = "Tri Categorie Calories";
            this.bttricatcalories.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(444, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(273, 212);
            this.listBox2.TabIndex = 4;
            // 
            // bt_connexion
            // 
            this.bt_connexion.Location = new System.Drawing.Point(610, 251);
            this.bt_connexion.Name = "bt_connexion";
            this.bt_connexion.Size = new System.Drawing.Size(75, 23);
            this.bt_connexion.TabIndex = 5;
            this.bt_connexion.Text = "Connexion";
            this.bt_connexion.UseVisualStyleBackColor = true;
            this.bt_connexion.Click += new System.EventHandler(this.bt_connexion_Click);
            // 
            // lbetatconnexion
            // 
            this.lbetatconnexion.AutoSize = true;
            this.lbetatconnexion.Location = new System.Drawing.Point(628, 227);
            this.lbetatconnexion.Name = "lbetatconnexion";
            this.lbetatconnexion.Size = new System.Drawing.Size(26, 13);
            this.lbetatconnexion.TabIndex = 6;
            this.lbetatconnexion.Text = "Etat";
            // 
            // FormTriPlats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 298);
            this.Controls.Add(this.lbetatconnexion);
            this.Controls.Add(this.bt_connexion);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.bttricatcalories);
            this.Controls.Add(this.btcatprix);
            this.Controls.Add(this.btdefaut);
            this.Controls.Add(this.listBox1);
            this.Name = "FormTriPlats";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btdefaut;
        private System.Windows.Forms.Button btcatprix;
        private System.Windows.Forms.Button bttricatcalories;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button bt_connexion;
        private System.Windows.Forms.Label lbetatconnexion;
    }
}

