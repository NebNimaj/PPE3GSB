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

            bsRapport.DataSource = Modele.MaConnexion.RAPPORT.ToList();
            RAPPORT vcurrent = (RAPPORT)bsRapport.Current;
            txtNumRapport.Text = vcurrent.idRapport.ToString();
            txtDateRapport.Text = vcurrent.dateRapport.ToString().Substring(0, 10);
            txtMotif.Text = vcurrent.MOTIF.libMotif.ToString();
            txtBilan.Text = vcurrent.bilan.ToString();

            cboPracticiens.ValueMember = "idMedecin";//permet de stocker l'identifiant
            cboPracticiens.DisplayMember = "NP";
            bsPracticien.DataSource = Modele.MaConnexion.MEDECIN.ToList()
                .Where(x=> x.idMedecin ==vcurrent.idMedecin);
                       cboPracticiens.DataSource = bsPracticien;

            bsOffreEchantillon.DataSource = Modele.MaConnexion.OFFRIR.ToList()
                .Where(x=> x.idRapport == vcurrent.idRapport) ;
            dgvEchantillons.DataSource = bsOffreEchantillon;
        }

        private void bsRapport_CurrentChanged(object sender, EventArgs e)
        {
            RAPPORT vcurrent = (RAPPORT)bsRapport.Current;
            bsPracticien.DataSource = Modele.MaConnexion.MEDECIN.ToList()
                .Where(x => x.idMedecin == vcurrent.idMedecin);
            cboPracticiens.DataSource = bsPracticien;

            txtNumRapport.Text = vcurrent.idRapport.ToString();
            txtDateRapport.Text = vcurrent.dateRapport.ToString().Substring(0, 10);
            txtMotif.Text = vcurrent.MOTIF.libMotif.ToString();
            txtBilan.Text = vcurrent.bilan.ToString();


            bsOffreEchantillon.DataSource = Modele.MaConnexion.OFFRIR.ToList()
                .Where(x => x.idRapport == vcurrent.idRapport);
            dgvEchantillons.DataSource = bsOffreEchantillon;

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
