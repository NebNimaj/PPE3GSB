using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3GSB
{
    public partial class frmAjoutVisiteur : Form
    {
        public frmAjoutVisiteur()
        {
            InitializeComponent();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

            Visiteur monVisiteur = new Visiteur();
            monVisiteur.nom = txtNom.Text;
            monVisiteur.prenom = txtPrenom.Text;
            monVisiteur.rue = txtRue.Text;
            monVisiteur.cp = txtCP.Text;
            monVisiteur.dateEmbauche = txtDateEmbauche.Text;
            monVisiteur.identifiant = txtIdentifiant.Text;
            monVisiteur.password = txtMotDePasse.Text;
            Modele.MaConnexion.Visiteur.AddObject(monVisiteur);
            Modele.MaConnexion.SaveChanges();
            MessageBox.Show("Enregistrement ok", "Action");
            this.Close();
        }

        private void txtMotDePasse_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
