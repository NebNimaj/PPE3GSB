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
    
    public partial class frmVisiteurLaboratoire : Form
    {
        bool fermeture = false;
        public frmVisiteurLaboratoire()
        {
            InitializeComponent();
        }


        private void frmVisiteurLaboratoire_Load(object sender, EventArgs e)
        {
            cboLaboratoire.ValueMember = "idLabo";//permet de stocker l'identifiant
            cboLaboratoire.DisplayMember = "nomLabo";
            bsLaboratoire.DataSource = Modele.MaConnexion.Laboratoire.ToList();
            cboLaboratoire.DataSource = bsLaboratoire;
        }

        private void cboLaboratoire_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fermeture) return;
            var LQuery = Modele.MaConnexion.Visiteur.ToList()
                           .Where(x => x.idLabo == int.Parse(cboLaboratoire.SelectedValue.ToString()))
                           .Select(x => new { x.nom, x.prenom, x.rue, x.ville, x.dateEmbauche})
                           .OrderBy(x => x.nom);


            bsVisiteur.DataSource = LQuery;
            dgvVisiteur.DataSource = bsVisiteur;
            dgvVisiteur.Columns[0].HeaderText = "Nom";
            dgvVisiteur.Columns[1].HeaderText = "Prenom";
            dgvVisiteur.Columns[2].HeaderText = "Rue";
            dgvVisiteur.Columns[3].HeaderText = "Ville";
            dgvVisiteur.Columns[4].HeaderText = "Date d'embauche";
            

        }

    }
}
