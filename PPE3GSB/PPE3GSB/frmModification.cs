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
    public partial class frmModification : Form
    {
        private Visiteur vVisiteur;
        public frmModification()
        {
            InitializeComponent();
           vVisiteur = Modele.VisiteurConnecte;
            bsVisiteur.DataSource = Modele.VisiteurConnecte;
        }

        private void btnEnregistrement_Click(object sender, EventArgs e)
        {

                vVisiteur.rue = txtRue.Text;
                vVisiteur.cp = txtCP.Text;
                vVisiteur.ville = txtVille.Text;
                vVisiteur.identifiant = txtIdentifiant.Text;
                vVisiteur.password = txtMotDePasse.Text;
                Modele.MaConnexion.SaveChanges();
                MessageBox.Show("Modification ok", "Action");
                this.Close();
            
           
        }


        private void txtVille_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
                e.Handled = true;

        }
    }
}
