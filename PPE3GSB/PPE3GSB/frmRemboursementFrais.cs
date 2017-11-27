﻿using System;
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
            dgvLigneFraisForfait.DataSource = bsLigneFraisForfait;
            bsFraisHorsForfait.DataSource = Modele.MaConnexion.LigneFraisHorsForfait.ToList();
            dgvFraisHorsForfait.DataSource = bsFraisHorsForfait;

        }

        private void frmRemboursementFrais_Load(object sender, EventArgs e)
        {
            loadBS();
        }

        private void butSuppr_Click(object sender, EventArgs e)
        {
            try
            {
                LigneFraisHorsForfait monLigneFraisHorsForfait = (LigneFraisHorsForfait)bsFraisHorsForfait.Current;
                Modele.MaConnexion.LigneFraisHorsForfait.DeleteObject(monLigneFraisHorsForfait);
                Modele.MaConnexion.SaveChanges();
                MessageBox.Show("Frais supprimé", "Action");
            }
            catch
            {
                try
                {
                    LigneFraisHorsForfait monLigneHorsFrais = (LigneFraisHorsForfait)bsLigneFraisForfait.Current;
                    Modele.MaConnexion.LigneFraisHorsForfait.DeleteObject(monLigneHorsFrais);
                    Modele.MaConnexion.SaveChanges();
                    MessageBox.Show("Frais supprimé", "Action");
                }
                catch
                {
                    MessageBox.Show("Erreur lors de la suppréssion", "Action");
                }
            }
            loadBS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadBS();
        }
    }
}
