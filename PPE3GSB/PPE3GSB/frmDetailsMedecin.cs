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
    public partial class frmDetailsMedecin : frmBase
    {
        MEDECIN monMedecin;
        public frmDetailsMedecin(MEDECIN unMedecin) :base()
        {
            InitializeComponent();
            monMedecin = unMedecin;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDetailsMedecin_Load(object sender, EventArgs e)
        {
            txtAdresse.Text = monMedecin.adresse.ToString();
            txtDepartement.Text = monMedecin.departement.ToString();
            txtIdMedecin.Text = monMedecin.idMedecin.ToString();
            txtIdSpecialite.Text = monMedecin.idSpecialite.ToString();
            txtLibSpecialite.Text = monMedecin.SPECIALITE.libSpecialite.ToString();
            txtNom.Text = monMedecin.nom.ToString();
            txtPrenom.Text = monMedecin.prenom.ToString();
            txtTel.Text = monMedecin.tel.ToString();
            
        }
    }
}
