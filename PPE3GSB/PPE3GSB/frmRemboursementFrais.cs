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
            try
            {
                LigneFraisForfait monLigneFrais = (LigneFraisForfait)bsFrais.Current;
                Modele.MaConnexion.LigneFraisForfait.DeleteObject(monLigneFrais);
                Modele.MaConnexion.SaveChanges();
                MessageBox.Show("Frais supprimé", "Action");
            }
            catch
            {
                try
                {
                    LigneFraisHorsForfait monLigneHorsFrais = (LigneFraisHorsForfait)bsFrais.Current;
                    Modele.MaConnexion.LigneFraisHorsForfait.DeleteObject(monLigneHorsFrais);
                    Modele.MaConnexion.SaveChanges();
                    MessageBox.Show("Frais supprimé", "Action");
                }
                catch
                {
                    MessageBox.Show("Erreur lors de la suppréssion", "Action");
                }
            }
        }
    }
}
