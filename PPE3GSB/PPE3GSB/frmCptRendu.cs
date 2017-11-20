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
    
    public partial class frmCptRendu :frmBase
    {
        //TODO : Remplacant, coefficient de confiance, presentation de medicament
        RAPPORT vcurrent;
        BindingList<OFFRIR> lesOffres= new BindingList<OFFRIR>();
        bool presentation = true;
        public frmCptRendu() : base()
        {
            InitializeComponent();
            
        }

        private void frmCptRendu_Load(object sender, EventArgs e)
        {

            bsRapport.DataSource = Modele.MaConnexion.RAPPORT.ToList();
            vcurrent = (RAPPORT)bsRapport.Current;
            txtNumRapport.Text = vcurrent.idRapport.ToString();
            dtpRapport.Value = Convert.ToDateTime(vcurrent.dateRapport);
            
            txtBilan.Text = vcurrent.bilan.ToString();

            bsMotif.DataSource = Modele.MaConnexion.MOTIF.ToList();
            cboIdMotif.DataSource = bsMotif;
            cboIdMotif.ValueMember = "idMotif";//permet de stocker l'identifiant
            cboIdMotif.DisplayMember = "libMotif";
            cboIdMotif.SelectedValue = vcurrent.MOTIF.idMotif;

            bsMedicament.DataSource = Modele.MaConnexion.MEDICAMENT.ToList();
            cboMedicament.DataSource = bsMedicament;
            cboMedicament.ValueMember = "idMedicament";//permet de stocker l'identifiant
            cboMedicament.DisplayMember = "nomCommercial";

            cboPracticiens.ValueMember = "idMedecin";//permet de stocker l'identifiant
            cboPracticiens.DisplayMember = "NP";
            bsPracticien.DataSource = Modele.MaConnexion.MEDECIN.ToList()
                .Where(x=> x.idMedecin ==vcurrent.idMedecin);
                       cboPracticiens.DataSource = bsPracticien;

            bsOffreEchantillon.DataSource = Modele.MaConnexion.OFFRIR.ToList()
                .Where(x=> x.idRapport == vcurrent.idRapport) ;
            dgvEchantillon.DataSource = bsOffreEchantillon;


        }

        private void bsRapport_CurrentChanged(object sender, EventArgs e)
        {
            {
                try
                {
                    if (presentation)
                    {

                    }
                    else
                    {
                        RAPPORT vcurrent = (RAPPORT)bsRapport.Current;
                        bsPracticien.DataSource = Modele.MaConnexion.MEDECIN.ToList()
                            .Where(x => x.idMedecin == vcurrent.idMedecin);
                        cboPracticiens.DataSource = bsPracticien;


                        txtNumRapport.Text = vcurrent.idRapport.ToString();
                        dtpRapport.Value = Convert.ToDateTime(vcurrent.dateRapport);
                        cboIdMotif.SelectedValue = vcurrent.MOTIF.idMotif;
                        txtBilan.Text = vcurrent.bilan.ToString();


                        bsOffreEchantillon.DataSource = Modele.MaConnexion.OFFRIR.ToList()
                            .Where(x => x.idRapport == vcurrent.idRapport);
                        dgvEchantillon.DataSource = bsOffreEchantillon;

                        bsOffrir.DataSource = lesOffres;
                        dgvAjoutEchantillons.DataSource = bsOffrir;
                    }
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
            lblMedicament.Visible = true;
            lblQuantite.Visible = true;
            nupQuantite.Visible = true;
            btnAjoutMedicament.Visible = true;
            cboMedicament.Visible = true;
            dgvAjoutEchantillons.Visible = true;
            lblAjoutEchantillons.Visible = true;

            btnAjout.Visible = true;
            dtpRapport.Enabled = true;
            txtBilan.Enabled = true;
            cboIdMotif.Enabled = true;
            txtNumRapport.Text = (bsRapport.Count + 1).ToString();
            bsPracticien.DataSource = Modele.MaConnexion.MEDECIN.ToList();
            cboPracticiens.DataSource = bsPracticien;

            txtNumRapport.Text = "";
            txtBilan.Text = "";

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            
                try
                {
                vcurrent = (RAPPORT)bsRapport.Current;
                vcurrent.idVisiteur = Modele.VisiteurConnecte.idVisiteur;
                vcurrent.dateRapport = Convert.ToDateTime(dtpRapport.Value);
                vcurrent.bilan = txtBilan.Text;
                vcurrent.idMotif = int.Parse(cboIdMotif.SelectedValue.ToString());
                vcurrent.idMedecin = int.Parse(cboPracticiens.SelectedValue.ToString());
                Modele.MaConnexion.SaveChanges();
                    MessageBox.Show("Enregistrement ok", "Action");
                btnModifier.Visible = false;
                btnModifier.Visible = false;
                dtpRapport.Enabled = false;
                txtBilan.Enabled = false;
                cboIdMotif.Enabled = false;
                lblMedicament.Visible = false;
                lblQuantite.Visible = false;
                nupQuantite.Visible = false;
                cboMedicament.Visible = false;
                btnAjoutMedicament.Visible = false;
                dgvAjoutEchantillons.Visible = false;
                lblAjoutEchantillons.Visible = false;
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Enregistrement erreur : " + ex.ToString(), "Action");
                }
            }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            try
            {
                if (presentation)
                {

                }
                else
                {
                    RAPPORT monRapport = new RAPPORT();
                    monRapport.idRapport = bsRapport.Count + 1;
                    monRapport.dateRapport = Convert.ToDateTime(dtpRapport.Value);
                    monRapport.idMotif = int.Parse(cboIdMotif.SelectedValue.ToString());
                    monRapport.bilan = txtBilan.Text;
                    monRapport.idVisiteur = Modele.VisiteurConnecte.idVisiteur;
                    monRapport.idMedecin = int.Parse(cboPracticiens.SelectedValue.ToString());
                    Modele.MaConnexion.RAPPORT.AddObject(monRapport);
                    if (lesOffres.Count != 0)
                    {
                        foreach (OFFRIR uneOffre in lesOffres)
                        {
                            Modele.MaConnexion.OFFRIR.AddObject(uneOffre);
                        }
                    }

                    Modele.MaConnexion.SaveChanges();
                    MessageBox.Show("Enregistrement ok", "Action");


                    btnAjout.Visible = false;
                    btnAjoutMedicament.Visible = false;
                    dtpRapport.Enabled = false;
                    txtBilan.Enabled = false;
                    cboIdMotif.Enabled = false;
                    lblMedicament.Visible = false;
                    lblQuantite.Visible = false;
                    nupQuantite.Visible = false;
                    cboMedicament.Visible = false;
                    dgvAjoutEchantillons.Visible = false;
                    lblAjoutEchantillons.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enregistrement erreur : " + ex.ToString(), "Action");
            }
        }

        private void bindingNavigatorModifyItem_Click(object sender, EventArgs e)
        {
            if (presentation)
            {

            }
            else
            {
                lblMedicament.Visible = true;
                lblQuantite.Visible = true;
                nupQuantite.Visible = true;
                btnAjoutMedicament.Visible = true;
                cboMedicament.Visible = true;
                btnModifier.Visible = true;
                dtpRapport.Enabled = true;
                txtBilan.Enabled = true;
                cboIdMotif.Enabled = true;
                dgvAjoutEchantillons.Visible = true;
                lblAjoutEchantillons.Visible = true;

                txtNumRapport.Text = (bsRapport.Count + 1).ToString();
                bsPracticien.DataSource = Modele.MaConnexion.MEDECIN.ToList();
                cboPracticiens.DataSource = bsPracticien;
            }
        }

        private void btnAjoutMedicament_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (presentation)
                {

                }
                else
                {
                    vcurrent = (RAPPORT)bsRapport.Current;
                    OFFRIR ajoutOffre = new OFFRIR();
                    ajoutOffre.idRapport = vcurrent.idRapport;
                    ajoutOffre.idMedicament = cboMedicament.SelectedValue.ToString();
                    ajoutOffre.quantite = int.Parse(nupQuantite.Value.ToString());
                    lesOffres.Add(ajoutOffre);
                }
            }
            catch
            {

            }
            
        }

        private void btnOffert_Click(object sender, EventArgs e)
        {
            dgvEchantillon.Visible = true;
            lblOffre.Visible = true;
            lblOffre.Text = "Echantillons offert";
        }

        private void btnPresentation_Click(object sender, EventArgs e)
        {
            dgvEchantillon.Visible = true;
            lblOffre.Visible = true;
            lblOffre.Text = "Echantillons présentés";
        }
    }
}
