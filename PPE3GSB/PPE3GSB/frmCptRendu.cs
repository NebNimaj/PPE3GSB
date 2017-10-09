using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PPE3GSB
{
    public partial class frmCptRendu : frmBase
    {
        public frmCptRendu() : base()
        {
            InitializeComponent();
            
        }

        private void frmCptRendu_Load(object sender, EventArgs e)
        {   
           //permet de stocker l'identifiant
            var rapport = Modele.MaConnexion.RAPPORT.ToList();
            BindingSource bsRapport = new BindingSource();
            bsRapport.DataSource = rapport;
            bnRapport.BindingSource = bsRapport;
            RAPPORT rapportBS = new RAPPORT();
            txtNumRapport.Text = rapportBS.idRapport.ToString();

            cboPracticiens.ValueMember = "idMedecin";//permet de stocker l'identifiant
            cboPracticiens.DisplayMember = "NP";
            bsPracticien.DataSource = Modele.MaConnexion.MEDECIN.ToList();
                       cboPracticiens.DataSource = bsPracticien;
        }

        private void bnRapport_TabIndexChanged(object sender, EventArgs e)
        {
        }

        private void bindingNavigatorPositionItem_TextChanged(object sender, EventArgs e)
        {
            int emplacement=0;
            try
            {
               emplacement= int.Parse(bnRapport.PositionItem.Text.ToString());
            }
            catch
            {
                txtNumRapport.Text = "Entier non valide";
            }
            txtNumRapport.Text = emplacement.ToString();
        }
    }
}
