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
           // maConnexion = new connectFrais();
            //bsFrais.DataSource = maConnexion.FICHEFRAIS.ToList();
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
            // TODO: cette ligne de code charge les données dans la table 'sIO2_GSB1_BJJDDataSet.fichefrais'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            //this.fichefraisTableAdapter.Fill(this.sIO2_GSB1_BJJDDataSet.fichefrais);
            // TODO: cette ligne de code charge les données dans la table 'sIO2_GSB1_BJJDDataSet.LigneFraisForfait'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            //this.ligneFraisForfaitTableAdapter.Fill(this.sIO2_GSB1_BJJDDataSet.LigneFraisForfait);
            // TODO: cette ligne de code charge les données dans la table 'sIO2_GSB1_BJJDDataSet.LigneFraisForfait'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            //this.ligneFraisForfaitTableAdapter.Fill(this.sIO2_GSB1_BJJDDataSet.LigneFraisForfait);
            // TODO: cette ligne de code charge les données dans la table 'sIO2_GSB1_BJJDDataSet.FraisForfait'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            //this.fraisForfaitTableAdapter.Fill(this.sIO2_GSB1_BJJDDataSet.FraisForfait);
            // TODO: cette ligne de code charge les données dans la table 'sIO2_GSB1_BJJDDataSet.LigneFraisHorsForfait'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            //this.ligneFraisHorsForfaitTableAdapter.Fill(this.sIO2_GSB1_BJJDDataSet.LigneFraisHorsForfait);
            // TODO: cette ligne de code charge les données dans la table 'sIO2_GSB1_BJJDDataSet.LigneFraisHorsForfait'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            //this.ligneFraisHorsForfaitTableAdapter.Fill(this.sIO2_GSB1_BJJDDataSet.LigneFraisHorsForfait);

        }

        private void ligneFraisForfaitDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
