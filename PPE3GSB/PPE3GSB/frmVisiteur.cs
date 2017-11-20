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
    public partial class frmVisiteur : Form
    {
        public frmVisiteur()
        {
            InitializeComponent();
            bsVisiteur.DataSource = Modele.VisiteurConnecte;
            var filteredData = Modele.MaConnexion.Laboratoire.ToList()
            .Where(x => x.idLabo == Modele.VisiteurConnecte.idLabo);
            // création d'un filtre pour les salles sur l' idBati de l'enregistrement courrant
            // x représente un enregistrement de salle

            bsLaboratoire.DataSource = filteredData;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmModification f1 = new frmModification();
            f1.Show();
        }
    }
}
