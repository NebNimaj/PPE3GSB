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
            //lblDate.Visible = false;
            //dateTime.Visible = false;
            //lblLibellé.Visible = false;
            //txtLibellé.Visible = false;
            //lblMontant.Visible = false;
            //txtMontant.Visible = false;
            if ((string)cboTypeFrais.SelectedItem == "Forfaitisés")
                {
                lblTypeForfait.Visible = true;
                cboTypeForfait.Visible = true;
                lblQuantité.Visible = true;
                txtQuantité.Visible = true;
                lblMontantUnitaire.Visible = true;
                txtMontantUnitaire.Visible = true;
                lblTotal.Visible = true;
                txtTotal.Visible = true;
                lblDate.Visible = false;
                dateTime.Visible = false;
                lblLibellé.Visible = false;
                txtLibellé.Visible = false;
                lblMontant.Visible = false;
                txtMontant.Visible = false;
                } 
                else if((string)cboTypeFrais.SelectedItem =="Hors forfait")
                    {
                lblTypeForfait.Visible = false;
                cboTypeForfait.Visible = false;
                lblQuantité.Visible = false;
                txtQuantité.Visible = false;
                lblMontantUnitaire.Visible = false;
                txtMontantUnitaire.Visible = false;
                lblTotal.Visible = false;
                txtTotal.Visible = false;
                lblDate.Visible = true;
                dateTime.Visible = true;
                lblLibellé.Visible = true;
                txtLibellé.Visible = true;
                lblMontant.Visible = true;
                txtMontant.Visible = true;
                    }


            }
            private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar)
            && e.KeyChar != ',')
            {
                e.Handled = true;
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
    }
}
