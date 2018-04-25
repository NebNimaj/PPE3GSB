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

        private void gestionVisiteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void regionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegionVisiteur frmRegionVisi = new frmRegionVisiteur();
            frmRegionVisi.MdiParent = this;
            frmRegionVisi.Show();
        }

        private void secteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSecteurVisiteur frmSecteurVisi = new frmSecteurVisiteur();
            frmSecteurVisi.MdiParent = this;
            frmSecteurVisi.Show();
        }

        private void laboratoireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLaboratoireVisiteur frmLaboVisi = new frmLaboratoireVisiteur();
            frmLaboVisi.MdiParent = this;
            frmLaboVisi.Show();
        }
    }
}
