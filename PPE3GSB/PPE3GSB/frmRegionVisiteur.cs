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
    public partial class frmRegionVisiteur : Form
    {
        public frmRegionVisiteur()
        {
            InitializeComponent();
        }

        private void frmRegionVisiteur_Load(object sender, EventArgs e)
        {
            cboRegion.ValueMember = "idRegion";//permet de stocker l'identifiant
            cboRegion.DisplayMember = "libRegion";
            bsRegion.DataSource = Modele.MaConnexion.Region.ToList();
            cboRegion.DataSource = bsRegion;
        }

        private void cboRegion_SelectedIndexChanged(object sender, EventArgs e)
        {

            var innerJoinQuery =
            from R in Region
            join T in Travailler on R.idRegion equals V.idVisiteur
            select new { V.nom, V.prenom, V.rue, V.ville, V.cp, V.dateEmbauche };



            /*var LQuery = Modele.MaConnexion.Visiteur.ToList()
                           .Where(x => x.idLabo == int.Parse(cboRegion.SelectedValue.ToString()))
                           .Select(x => new { x.nom, x.prenom, x.rue, x.ville, x.cp, x.dateEmbauche })
                           .OrderBy(x => x.nom);*/


            bsVisiteur.DataSource = innerJoinQuery;
            dgvVisiteur.DataSource = bsVisiteur;
            dgvVisiteur.Columns[0].HeaderText = "Nom";
            dgvVisiteur.Columns[1].HeaderText = "Prenom";
            dgvVisiteur.Columns[2].HeaderText = "Rue";
            dgvVisiteur.Columns[3].HeaderText = "Ville";
            dgvVisiteur.Columns[4].HeaderText = "CP";
            dgvVisiteur.Columns[5].HeaderText = "Date d'embauche";


        }
    }
}
