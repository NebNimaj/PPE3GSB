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
        }

        private void cboTypeFrais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)cboTypeFrais.SelectedItem == "Forfaitisés")
            {

                // Rend visible les parties concernant les forfait forfaitisés

                lblTypeForfait.Visible = true;
                cboTypeForfait.Visible = true;
                lblQuantité.Visible = true;
                txtQuantité.Visible = true;
                lblMontantUnitaire.Visible = true;
                txtMontantUnitaire.Visible = true;
                lblTotal.Visible = true;
                txtTotal.Visible = true;
                lblDate.Visible = false;
                dateTimeP.Visible = false;
                lblLibellé.Visible = false;
                txtLibellé.Visible = false;
                lblMontant.Visible = false;
                txtMontant.Visible = false;
            }
            else if ((string)cboTypeFrais.SelectedItem == "Hors forfait")
            {

                // Rend visible les parties concernant les forfait hors forfait

                lblTypeForfait.Visible = false;
                cboTypeForfait.Visible = false;
                lblQuantité.Visible = false;
                txtQuantité.Visible = false;
                lblMontantUnitaire.Visible = false;
                txtMontantUnitaire.Visible = false;
                lblTotal.Visible = false;
                txtTotal.Visible = false;
                lblDate.Visible = true;
                dateTimeP.Visible = true;
                lblLibellé.Visible = true;
                txtLibellé.Visible = true;
                lblMontant.Visible = true;
                txtMontant.Visible = true;
            }


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


        private void txtForfaitisés_TextChanged(object sender, EventArgs e)
        {
            //Affiche le calcul de Quantité et Montant Unitaire dans la boîte Total
            txtTotal.Text = Convert.ToString(Convert.ToDouble(txtQuantité.Text) * Convert.ToDouble(txtMontantUnitaire.Text));
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
            try
            {
                if (((string)cboTypeFrais.SelectedItem == "Forfaitisés") && (int.Parse(txtTotal.Text) > 0) && ((string)cboTypeForfait.SelectedItem == "Forfait étape" || (string)cboTypeForfait.SelectedItem == "Frais kilométrique" || (string)cboTypeForfait.SelectedItem == "Nuitée hôtel" || (string)cboTypeForfait.SelectedItem == "Repas restaurant") || (((string)cboTypeFrais.SelectedItem == "Hors forfait") && (int.Parse(txtMontant.Text) > 0) && (txtLibellé.Text != null))) //Vérifie si il y a des valeurs inscrite dans les TextBox et que c'est possible de d'insérer (Pas de valeur total nul)
                {
                    if (MessageBox.Show("Rajouter les frais inscrits ?", "   ",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        
                        
                        if ((string)cboTypeFrais.SelectedItem == "Forfaitisés")
                        {
                            LigneFraisForfait monFrais = new LigneFraisForfait();
                            if ((string)cboTypeForfait.SelectedItem == "Frais kilométrique")
                                monFrais.idFraisForfait = "KM";
                            if ((string)cboTypeForfait.SelectedItem == "Forfait étape")
                                monFrais.idFraisForfait = "ETP";
                            if ((string)cboTypeForfait.SelectedItem == "Nuitée hôtel")
                                monFrais.idFraisForfait = "NUI";
                            if ((string)cboTypeForfait.SelectedItem == "Repas restaurant")
                                monFrais.idFraisForfait = "REP";
                            monFrais.quantite = int.Parse(txtQuantité.Text);
                            monFrais.idVisiteur = Modele.VisiteurConnecte.idVisiteur; // Récupère l'id de l'utilisateur connecté
                            monFrais.mois = "juin"; //Récupère le dernier mois non accepté
                            Modele.MaConnexion.LigneFraisForfait.AddObject(monFrais);
                            Modele.MaConnexion.SaveChanges();
                            MessageBox.Show("L'enregistrement a réussis", "Action");
                            this.Close();

                        } else if ((string)cboTypeFrais.SelectedItem == "Hors forfait") 
                        {
                            LigneFraisHorsForfait monFraisHF = new LigneFraisHorsForfait();
                            monFraisHF.montant = int.Parse(txtQuantité.Text);
                            monFraisHF.idVisiteur = Modele.VisiteurConnecte.idVisiteur; // Récupère l'id de l'utilisateur connecté
                            monFraisHF.mois = "juin"; //Récupère le dernier mois non accepté ou moins en cours
                            //monFraisHF.date = dateTimeP; //La date du forfait
                            monFraisHF.libelle = txtLibellé.Text; //Le libellé du forfait
                            Modele.MaConnexion.LigneFraisHorsForfait.AddObject(monFraisHF);
                            Modele.MaConnexion.SaveChanges();
                            MessageBox.Show("L'enregistrement a réussis", "Action");
                            this.Close();



                        }
                    }
                }
            } catch
            {
                MessageBox.Show("L'enregistrement n'a pas réussis", "Action");
                this.Close();
            }
        }

        private void cboTypeForfait_SelectedIndexChanged(object sender, EventArgs e)
        {
            bsTypeFrais.DataSource = Modele.MaConnexion.FraisForfait.ToList();
            if ((string)cboTypeForfait.SelectedItem == "Forfait étape")
            {
                var MontantUnitaire = Modele.MaConnexion.FraisForfait.ToList()
                .Where(x => x.id == "ETP")
                .Select(x => new { x.montant });
                txtMontantUnitaire.Text = MontantUnitaire.ElementAt(0).montant.ToString();
            }
            else if ((string)cboTypeForfait.SelectedItem == "Frais kilométrique")
            {
                //txtMontantUnitaire.Enabled = true;
                var MontantUnitaire = Modele.MaConnexion.FraisForfait.ToList()
                .Where(x => x.id == "KM")
                .Select(x => new { x.montant });
                txtMontantUnitaire.Text = MontantUnitaire.ElementAt(0).montant.ToString();
            }
            else if ((string)cboTypeForfait.SelectedItem == "Nuitée hôtel")
            {
                var MontantUnitaire = Modele.MaConnexion.FraisForfait.ToList()
                .Where(x => x.id == "NUI")
                .Select(x => new { x.montant });
                txtMontantUnitaire.Text = MontantUnitaire.ElementAt(0).montant.ToString();

            }
            else if ((string)cboTypeForfait.SelectedItem == "Repas restaurant")
            {
                var MontantUnitaire = Modele.MaConnexion.FraisForfait.ToList()
                .Where(x => x.id == "REP")
                .Select(x => new { x.montant });
                txtMontantUnitaire.Text = MontantUnitaire.ElementAt(0).montant.ToString();
            }
            else
            {
                txtMontantUnitaire.Enabled = false;
                txtMontantUnitaire.Text = "0";
            }


            /*var MontantUnitaire = Modele.MaConnexion.FraisForfait.ToList()
            .Where(x => x.id == "NUI")
            .Select(x => new { x.montant });
            nupMontantUnitaireNuitee.Value = decimal.Parse(MontantUnitaire.ElementAt(0).montant.ToString());

            MontantUnitaire = Modele.MaConnexion.FraisForfait.ToList()
                 .Where(x => x.id == "REP")
                 .Select(x => new { x.montant });
            nupMontantUnitaireRepasMidi.Value = decimal.Parse(MontantUnitaire.ElementAt(0).montant.ToString());

            MontantUnitaire = Modele.MaConnexion.FraisForfait.ToList()
                .Where(x => x.id == "ETP")
                .Select(x => new { x.montant });
            nupMontantUnitaireRelaisEtape.Value = decimal.Parse(MontantUnitaire.ElementAt(0).montant.ToString());

            nupMontantUnitaireKilometrage.Value = 0.52M;*/
        }
    }
}
