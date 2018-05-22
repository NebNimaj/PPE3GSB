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
    public partial class frmModFrais : Form
    {
        public frmModFrais()
        {
            InitializeComponent();
            dateTimeP.Value = DateTime.Today;
        }




        private void txtNoLettre(object sender, KeyPressEventArgs e)
        {

            //Vérifie la touche en entrée, en acceptant que les "," ou chiffres
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar)
            && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            //Vérifie si une "," est déjà écris, si oui impossible d'en remmettre une
            if (e.KeyChar == ','
            && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
            if (this.Text == "")
            {
                this.Text = "0";
            }

        }

        private void txtNoLettre_NoVirgule(object sender, KeyPressEventArgs e)
        {

            //Vérifie la touche en entrée, en acceptant que les chiffres
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }




        private void butAnnuler_Click(object sender, EventArgs e)
        {
            // message confirmation quitter l'application
            if (MessageBox.Show("Quitter sans enregistrer les modifications ?", "   ",
                               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Si oui, on ferme l'application
                this.Close();
            }
        }

        private void butAccept_Click(object sender, EventArgs e)
        {
            try {
            if ((decimal.Parse(txtMontant.Text) > 0) && (txtLibellé.Text != null)) //Vérifie si il y a des valeurs inscrite dans les TextBox et que c'est possible d'insérer (Pas de valeur total nul) 
                {
                    if (MessageBox.Show("Rajouter les frais inscrits ?", "   ",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //Frais kilométrique Forfait étape Nuitée hôtel Repas restaurant

                        string mt = string.Format("{0:F2}", txtMontant.Text);
                        LigneFraisHorsForfait monFraisHF = new LigneFraisHorsForfait();
                        monFraisHF.montant = decimal.Parse(txtMontant.Text);
                        monFraisHF.id = 1000;
                        monFraisHF.idVisiteur = Modele.VisiteurConnecte.idVisiteur; // Récupère l'id de l'utilisateur connecté
                        monFraisHF.date = dateTimeP.Value;
                        monFraisHF.mois = "juin"; //Récupère le dernier mois non accepté ou moins en cours
                                                  //monFraisHF.date = dateTimeP; //La date du forfait
                        monFraisHF.libelle = txtLibellé.Text; //Le libellé du forfait
                        Modele.MaConnexion.LigneFraisHorsForfait.AddObject(monFraisHF);
                        Modele.MaConnexion.SaveChanges();
                        MessageBox.Show("L'enregistrement a réussis", "Action");
                        this.Close();




                    }
                }
            } catch
            {
                MessageBox.Show("L'enregistrement n'a pas réussis", "Action");
                this.Close();
            }
        }

    }
}
