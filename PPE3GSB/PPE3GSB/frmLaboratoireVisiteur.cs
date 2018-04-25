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
    public partial class frmLaboratoireVisiteur : Form
    {
        
        public frmLaboratoireVisiteur()
        {
            InitializeComponent();
        }


        private void frmLaboratoireVisiteur_Load(object sender, EventArgs e)
        {
            cboLaboratoire.ValueMember = "idLabo";//permet de stocker l'identifiant
            cboLaboratoire.DisplayMember = "nomLabo";
            bsLaboratoire.DataSource = Modele.MaConnexion.Laboratoire.ToList();
            cboLaboratoire.DataSource = bsLaboratoire;
        }

        private void cboLaboratoire_SelectedIndexChanged(object sender, EventArgs e)
        {

            var LQuery = Modele.MaConnexion.Visiteur.ToList()
                           .Where(x => x.idLabo == int.Parse(cboLaboratoire.SelectedValue.ToString()))
                           .Select(x => new { x.nom, x.prenom, x.rue, x.ville, x.cp, x.dateEmbauche })
                           .OrderBy(x => x.nom);


            bsVisiteur.DataSource = LQuery;
            dgvVisiteur.DataSource = bsVisiteur;
            dgvVisiteur.Columns[0].HeaderText = "Id";
            dgvVisiteur.Columns[0].Visible = false;
            dgvVisiteur.Columns[1].HeaderText = "Nom";
            dgvVisiteur.Columns[2].HeaderText = "Prenom";
            dgvVisiteur.Columns[3].HeaderText = "Rue";
            dgvVisiteur.Columns[4].HeaderText = "Ville";
            dgvVisiteur.Columns[5].HeaderText = "CP";
            dgvVisiteur.Columns[6].HeaderText = "Date d'embauche";


        }
    }
}
