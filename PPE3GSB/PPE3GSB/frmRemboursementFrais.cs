using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace PPE3GSB
{
    public partial class frmRemboursementFrais : Form
    {
       // private connectFrais maConnexion;
        public frmRemboursementFrais()
        {
            InitializeComponent();
        }

        private void txtTotal_txtChanged(object sender, EventArgs e)
        {
            //Affiche le calcul de Quantité et Montant Unitaire dans la boîte Total
            txtPTotalEtape.Text = Convert.ToString(Convert.ToDouble(txtQteEtape.Text) * Convert.ToDouble(txtPUniteEtape.Text));
            txtPTotalKm.Text = Convert.ToString(Convert.ToDouble(txtQteKm.Text) * Convert.ToDouble(txtPUniteKm.Text));
            txtPTotalNuite.Text = Convert.ToString(Convert.ToDouble(txtQteNuite.Text) * Convert.ToDouble(txtPUniteNuite.Text));
            txtPTotalRepas.Text = Convert.ToString(Convert.ToDouble(txtQteRepas.Text) * Convert.ToDouble(txtPUniteRepas.Text));
        }

    
        private void prixUnit() //Récupère les prix unitaire des différents forfaits
        {

            //bsLigneFraisForfait.DataSource = Modele.MaConnexion.LigneFraisForfait.ToList();
            //var QuantiteETP = Modele.MaConnexion.LigneFraisForfait.ToList()
            //  .Where(x => x.idFraisForfait.Trim() == "ETP")
            //   .Select(x => new { x.quantite });
            //txtPUniteEtape.Text = MontantUnitaireETP.ElementAt(0).montant.ToString();
            // Forfait Etape
            bsFraisForfait.DataSource = Modele.MaConnexion.FraisForfait.ToList();
            var MontantUnitaireETP = Modele.MaConnexion.FraisForfait.ToList()
                .Where(x => x.id.Trim() == "ETP")
                .Select(x => new { x.montant });
            txtPUniteEtape.Text = MontantUnitaireETP.ElementAt(0).montant.ToString();


            // Nuitée Hotel
            bsFraisForfait.DataSource = Modele.MaConnexion.FraisForfait.ToList();
            var MontantUnitaireNUI = Modele.MaConnexion.FraisForfait.ToList()
                .Where(x => x.id.Trim() == "NUI")
                .Select(x => new { x.montant });
            txtPUniteNuite.Text = MontantUnitaireNUI.ElementAt(0).montant.ToString();

            // Frais kilométrique
            bsFraisForfait.DataSource = Modele.MaConnexion.FraisForfait.ToList();
            var MontantUnitaireKM = Modele.MaConnexion.FraisForfait.ToList()
                .Where(x => x.id.Trim() == "KM")
                .Select(x => new { x.montant });
            txtPUniteKm.Text = MontantUnitaireKM.ElementAt(0).montant.ToString();

            // Repas Restaurant
            bsFraisForfait.DataSource = Modele.MaConnexion.FraisForfait.ToList();
            var MontantUnitaireREP = Modele.MaConnexion.FraisForfait.ToList()
                .Where(x => x.id.Trim() == "REP")
                .Select(x => new { x.montant });
            txtPUniteRepas.Text = MontantUnitaireREP.ElementAt(0).montant.ToString();
        }

        private void butModifier_Click(object sender, EventArgs e)
        {
            frmModFrais frm = new frmModFrais();
            frm.Show();
        }

        private void butAjouter_Click(object sender, EventArgs e)
        {
            frmModFrais frm = new frmModFrais();
            frm.Show();
        }


        public void loadBS()
        {
            bsLigneFraisForfait.DataSource = Modele.MaConnexion.LigneFraisForfait.ToList();
            bsFraisHorsForfait.DataSource = Modele.MaConnexion.LigneFraisHorsForfait.ToList();
            dgvFraisHorsForfait.DataSource = bsFraisHorsForfait;


        }

        private void frmRemboursementFrais_Load(object sender, EventArgs e)
        {
            loadBS();
            prixUnit();
        }

        private void butSuppr_Click(object sender, EventArgs e)
        {
            try
            {
                //Supprime donnée HorsForfait sélectioné
                LigneFraisHorsForfait monLigneFraisHorsForfait = (LigneFraisHorsForfait)bsFraisHorsForfait.Current;
                Modele.MaConnexion.LigneFraisHorsForfait.DeleteObject(monLigneFraisHorsForfait);
                Modele.MaConnexion.SaveChanges();
                MessageBox.Show("Frais supprimé", "Action");
            }
            catch
            {
                MessageBox.Show("Erreur lors de la suppression", "Action");
            }
            loadBS();
        }


        private void butCloture_Click(object sender, EventArgs e)
        {
            
            var monfiltre = Modele.MaConnexion.LigneFraisForfait.ToList().Where(x => x.idVisiteur == Modele.VisiteurConnecte.idVisiteur && x.mois == "juin  " && x.idFraisForfait == "ETP");
            if (monfiltre.ToList().Count == 0)
            {
                LigneFraisForfait monFraisETP = new LigneFraisForfait();
                monFraisETP.idVisiteur = Modele.VisiteurConnecte.idVisiteur; // Récupère l'id de l'utilisateur connecté
                monFraisETP.mois = "juin";
                monFraisETP.idFraisForfait = "ETP";
                monFraisETP.quantite = int.Parse(txtQteEtape.Text);
                Modele.MaConnexion.LigneFraisForfait.AddObject(monFraisETP);
            }
            else { LigneFraisForfait monFraisETP = monfiltre.ElementAt(0); monFraisETP.quantite = int.Parse(txtQteEtape.Text); Modele.MaConnexion.SaveChanges(); }

            var monfiltre = Modele.MaConnexion.LigneFraisForfait.ToList().Where(x => x.idVisiteur == Modele.VisiteurConnecte.idVisiteur && x.mois == "juin  " && x.idFraisForfait == "KM");
            if (monfiltre.ToList().Count == 0)
            {
                LigneFraisForfait monFraisKM = new LigneFraisForfait();
                monFraisKM.idVisiteur = Modele.VisiteurConnecte.idVisiteur; // Récupère l'id de l'utilisateur connecté
                monFraisKM.mois = "juin";
                monFraisKM.quantite = int.Parse(txtQteKm.Text);
                monFraisKM.idFraisForfait = "KM";
                Modele.MaConnexion.LigneFraisForfait.AddObject(monFraisKM);
            }
            else { LigneFraisForfait monFraisETP = monfiltre.ElementAt(0); monFraisETP.quantite = int.Parse(txtQteEtape.Text); Modele.MaConnexion.SaveChanges(); }

            var monfiltre = Modele.MaConnexion.LigneFraisForfait.ToList().Where(x => x.idVisiteur == Modele.VisiteurConnecte.idVisiteur && x.mois == "juin  " && x.idFraisForfait == "NUI");
            if (monfiltre.ToList().Count == 0)
            {
                LigneFraisForfait monFraisNUI = new LigneFraisForfait();
                monFraisNUI.idVisiteur = Modele.VisiteurConnecte.idVisiteur; // Récupère l'id de l'utilisateur connecté
                monFraisNUI.mois = "juin";
                monFraisNUI.quantite = int.Parse(txtQteNuite.Text);
                monFraisNUI.idFraisForfait = "NUI";
                Modele.MaConnexion.LigneFraisForfait.AddObject(monFraisNUI);
            }
            else { LigneFraisForfait monFraisETP = monfiltre.ElementAt(0); monFraisETP.quantite = int.Parse(txtQteEtape.Text); Modele.MaConnexion.SaveChanges(); }

            var monfiltre = Modele.MaConnexion.LigneFraisForfait.ToList().Where(x => x.idVisiteur == Modele.VisiteurConnecte.idVisiteur && x.mois == "juin  " && x.idFraisForfait == "REP");
            if (monfiltre.ToList().Count == 0)
            {
                LigneFraisForfait monFraisETP = new LigneFraisForfait();
                monFraisREP.idVisiteur = Modele.VisiteurConnecte.idVisiteur; // Récupère l'id de l'utilisateur connecté
                monFraisREP.mois = "juin";
                monFraisREP.quantite = int.Parse(txtQteRepas.Text);
                monFraisREP.idFraisForfait = "REP";
                Modele.MaConnexion.LigneFraisForfait.AddObject(monFraisREP);
            }
            else { LigneFraisForfait monFraisETP = monfiltre.ElementAt(0); monFraisETP.quantite = int.Parse(txtQteEtape.Text); Modele.MaConnexion.SaveChanges(); }



   

           




            

     

            MessageBox.Show("L'enregistrement a réussis", "Action");
        }

        private void butActu_Click(object sender, EventArgs e)
        {
            loadBS();
        }
    }
}
