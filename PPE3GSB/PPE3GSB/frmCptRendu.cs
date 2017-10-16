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
            dtpRapport.Value = Convert.ToDateTime(vcurrent.dateRapport);
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
            {
                try
                {
                
                RAPPORT vcurrent = (RAPPORT)bsRapport.Current;
                bsPracticien.DataSource = Modele.MaConnexion.MEDECIN.ToList()
                    .Where(x => x.idMedecin == vcurrent.idMedecin);
                cboPracticiens.DataSource = bsPracticien;

                txtNumRapport.Text = vcurrent.idRapport.ToString();
                dtpRapport.Value = Convert.ToDateTime(vcurrent.dateRapport);
                txtMotif.Text = vcurrent.MOTIF.libMotif.ToString();
                txtBilan.Text = vcurrent.bilan.ToString();


                bsOffreEchantillon.DataSource = Modele.MaConnexion.OFFRIR.ToList()
                    .Where(x => x.idRapport == vcurrent.idRapport);
                dgvEchantillons.DataSource = bsOffreEchantillon;
                }
                catch
                {
                    //rien
                }
            }

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            frmDetailsMedecin frmDetMed = new frmDetailsMedecin((MEDECIN)bsPracticien.Current);
            frmDetMed.MdiParent = this.MdiParent;
            frmDetMed.Show();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            dtpRapport.Enabled = true;
            txtBilan.Enabled = true;
            txtMotif.Enabled = true;
            txtNumRapport.Text = (bsRapport.Count + 1).ToString();
            bsPracticien.DataSource = Modele.MaConnexion.MEDECIN.ToList();
            cboPracticiens.DataSource = bsPracticien;

            txtNumRapport.Text = "";
            txtMotif.Text = "";
            txtBilan.Text = "";
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                RAPPORT monRapport = new RAPPORT();
                monRapport.idRapport = int.Parse(txtNumRapport.Text);
                monRapport.dateRapport = Convert.ToDateTime(dtpRapport.Value);
                // monRapport.idMotif = txtMotif.Text;
                monRapport.bilan = txtBilan.Text;
                monRapport.idVisiteur = Modele.VisiteurConnecte.idVisiteur;
                //monRapport.idMedecin = bsPracticien.Current;
                Modele.MaConnexion.RAPPORT.AddObject(monRapport);
                Modele.MaConnexion.SaveChanges();
                MessageBox.Show("Enregistrement ok", "Action");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enregistrement erreur : " + ex.ToString(), "Action");
            }
        }
    }
}
