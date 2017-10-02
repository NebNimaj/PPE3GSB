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
    public partial class modFrais : Form
    {
        public modFrais()
        {
            InitializeComponent();
        }

        private void cboTypeFrais_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboTypeFrais.SelectedText == "Forfaitisés"  /*/ Frais hors forfait*/)
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
                txtDate.Visible = false;
                lblLibellé.Visible = false;
                txtLibellé.Visible = false;
                lblMontant.Visible = false;
                txtMontant.Visible = false;
                } 
                else if(cboTypeFrais.SelectedText == "Hors forfait" )
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
                txtDate.Visible = true;
                lblLibellé.Visible = true;
                txtLibellé.Visible = true;
                lblMontant.Visible = true;
                txtMontant.Visible = true;
                    }


            }

        }
    }
