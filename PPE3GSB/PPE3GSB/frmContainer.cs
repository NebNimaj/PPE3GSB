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
    public partial class frmContainer :frmBase
    {
        public frmContainer() :base()
        {
            InitializeComponent();
        }

        private void gestionRapportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionCptRendu frmGstCptRendu = new frmGestionCptRendu();
            frmGstCptRendu.MdiParent = this;
            frmGstCptRendu.Show();
        }

        private void gestionFraisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemboursementFrais frmremboursFrais = new frmRemboursementFrais();
            frmremboursFrais.MdiParent = this;
            frmremboursFrais.Show();
        }

        private void frmContainer_Load(object sender, EventArgs e)
        {
            lblTitre.Text +=" " + Modele.VisiteurConnecte.nom + " " + Modele.VisiteurConnecte.prenom;

        }
    }
}
