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
            //maConnexion = new connectFrais();
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

        private void frmRemboursementFrais_Load(object sender, EventArgs e)
        {
            bsFrais.DataSource = Modele.MaConnexion.LigneFraisForfait.ToList();
            dgvligneFraisForfait.DataSource = bsFrais;

        }

        private void butSuppr_Click(object sender, EventArgs e)
        {
            //Modele.MaConnexion.LigneFraisForfait.DeleteObject(vCompositeur);
            //this.dgvligneFraisForfait.Rows.RemoveAt(this.dgvligneFraisForfait.CurrentRow.Index);
            //Modele.MaConnexion.SaveChanges();
            //Pas idVisiteur, mais la ligne selectioné
         /* var filteredData = Modele.MaConnexion.LigneFraisForfait.ToList().Where(x => x.idVisiteur == (dgvligneFraisForfait.SelectedRows[0].Cells[0].Value.ToString()));

            BindingSource bsFrais = new BindingSource();
            bsFrais.DataSource = filteredData; // application du filtre
            bsFrais.MoveFirst();

            LigneFraisForfait monFrais = (LigneFraisForfait)bsFrais.Current;
            Modele.MaConnexion.LigneFraisForfait.DeleteObject(monFrais);
            Modele.MaConnexion.SaveChanges();
            MessageBox.Show("Frais supprimé", "Action");*/

        }
    }
}
