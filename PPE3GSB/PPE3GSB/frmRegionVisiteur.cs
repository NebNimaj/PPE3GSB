﻿using System;
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

            var LQuery = Modele.MaConnexion.Region.ToList().Where(x => x.idRegion == int.Parse(cboRegion.SelectedValue.ToString()));
            Region maregion = (Region)LQuery.First();
            bsVisiteur.DataSource = maregion.Visiteur1;

            dgvVisiteur.Columns[0].HeaderText = "Id";
            dgvVisiteur.Columns[0].Visible = false;
            dgvVisiteur.Columns[1].HeaderText = "Nom";
            dgvVisiteur.Columns[2].HeaderText = "Prenom";
            dgvVisiteur.Columns[3].HeaderText = "Rue";
            dgvVisiteur.Columns[4].HeaderText = "Ville";
            dgvVisiteur.Columns[5].HeaderText = "CP";
            dgvVisiteur.Columns[6].HeaderText = "Date d'embauche";

            var filteredData = Modele.MaConnexion.Region.ToList()
                .Where(x => x.idRegion == int.Parse(cboRegion.SelectedValue.ToString()));
            bsRegion.DataSource = filteredData;
            bsRegion.MoveFirst();

            var LQuery1 = Modele.MaConnexion.Region.ToList()
                .Where(x => x.idVisiteur == x.Visiteur.idVisiteur);
            bsRegion.DataSource = LQuery1;
            bsRegion.MoveFirst();
            Region maregion1 = (Region)bsRegion.Current;
            txtNom.Text = maregion.Visiteur.nom;
            txtPrenom.Text = maregion.Visiteur.prenom;
            txtRue.Text = maregion.Visiteur.rue;
            txtVille.Text = maregion.Visiteur.ville;
            txtCodePostal.Text = maregion.Visiteur.cp;
            txtDateEmbauche.Text = maregion.Visiteur.dateEmbauche;

        }
        private void btnResponsable_Click(object sender, EventArgs e)
        {
            var filteredData = Modele.MaConnexion.Region.ToList()
               .Where(x => x.idRegion == int.Parse(cboRegion.SelectedValue.ToString()));
            bsRegion.DataSource = filteredData;
            bsRegion.MoveFirst();

            var LQuery1 = Modele.MaConnexion.Region.ToList()
                .Where(x => x.idVisiteur == x.Visiteur.idVisiteur);
            Region maregion1 = (Region)bsRegion.Current;

            maregion1.Visiteur.nom = txtNom.Text;
            maregion1.Visiteur.prenom = txtPrenom.Text;
            maregion1.Visiteur.rue = txtRue.Text;
            maregion1.Visiteur.ville = txtVille.Text;
            maregion1.Visiteur.cp = txtCodePostal.Text;
            maregion1.Visiteur.dateEmbauche = txtDateEmbauche.Text;
            Modele.MaConnexion.SaveChanges();
            MessageBox.Show("Enregistrement ok", "Action");
            this.Close();
        }
    }
}
