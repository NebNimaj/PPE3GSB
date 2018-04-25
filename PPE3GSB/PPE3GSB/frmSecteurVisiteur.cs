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
    public partial class frmSecteurVisiteur : Form
    {
        public frmSecteurVisiteur()
        {
            InitializeComponent();
        }

        private void frmSecteurVisiteur_Load(object sender, EventArgs e)
        {
            cboSecteur.ValueMember = "idSecteur";//permet de stocker l'identifiant
            cboSecteur.DisplayMember = "libSecteur";
            bsSecteur.DataSource = Modele.MaConnexion.Secteur.ToList();
            cboSecteur.DataSource = bsSecteur;
        }

        private void cboSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            var LQuery = Modele.MaConnexion.Secteur.ToList().Where(x => x.idSecteur == int.Parse(cboSecteur.SelectedValue.ToString()));
            Secteur monsecteur = (Secteur)LQuery.First();
            var LQuery2 = Modele.MaConnexion.Region.ToList()
                .Where(x => x.idSecteur == monsecteur.idSecteur);
            bsRegion.DataSource = LQuery2;
            List<Region> mesregions = LQuery2.ToList();
            foreach (Region maregion in mesregions)
            {
                bsVisiteur.DataSource = maregion.Visiteur1;
                dgvVisiteur.Columns[0].HeaderText = "Id";
                dgvVisiteur.Columns[0].Visible = false;
                dgvVisiteur.Columns[1].HeaderText = "Nom";
                dgvVisiteur.Columns[2].HeaderText = "Prenom";
                dgvVisiteur.Columns[3].HeaderText = "Rue";
                dgvVisiteur.Columns[4].HeaderText = "Ville";
                dgvVisiteur.Columns[5].HeaderText = "CP";
                dgvVisiteur.Columns[6].HeaderText = "Date d'embauche";

            }



            var filteredData = Modele.MaConnexion.Secteur.ToList()
                .Where(x => x.idSecteur == int.Parse(cboSecteur.SelectedValue.ToString()));
            bsSecteur.DataSource = filteredData;
            bsSecteur.MoveFirst();

            var LQuery1 = Modele.MaConnexion.Secteur.ToList()
                .Where(x => x.idVisiteur == x.Visiteur.idVisiteur);
            bsSecteur.DataSource = LQuery1;
            bsSecteur.MoveFirst();
            Secteur monsecteur1 = (Secteur)bsSecteur.Current;
            txtNom.Text = monsecteur.Visiteur.nom;
            txtPrenom.Text = monsecteur.Visiteur.prenom;
            txtRue.Text = monsecteur.Visiteur.rue;
            txtVille.Text = monsecteur.Visiteur.ville;
            txtCodePostal.Text = monsecteur.Visiteur.cp;
            txtDateEmbauche.Text = monsecteur.Visiteur.dateEmbauche;
        }

        private void btnResponsable_Click(object sender, EventArgs e)
        {
            var filteredData = Modele.MaConnexion.Secteur.ToList()
              .Where(x => x.idSecteur == int.Parse(cboSecteur.SelectedValue.ToString()));
            bsSecteur.DataSource = filteredData;
            bsSecteur.MoveFirst();

            var LQuery1 = Modele.MaConnexion.Secteur.ToList()
                .Where(x => x.idVisiteur == x.Visiteur.idVisiteur);
            Secteur monsecteur1 = (Secteur)bsSecteur.Current;

            monsecteur1.Visiteur.nom = txtNom.Text;
            monsecteur1.Visiteur.prenom = txtPrenom.Text;
            monsecteur1.Visiteur.rue = txtRue.Text;
            monsecteur1.Visiteur.ville = txtVille.Text;
            monsecteur1.Visiteur.cp = txtCodePostal.Text;
            monsecteur1.Visiteur.dateEmbauche = txtDateEmbauche.Text;
            MessageBox.Show("Enregistrement ok", "Action");
            this.Close();
        }
    }
}
