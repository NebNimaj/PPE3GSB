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
    public partial class frmAjoutVisiteur : Form
    {
        public frmAjoutVisiteur()
        {
            InitializeComponent();
           // dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

            Visiteur monVisiteur = new Visiteur();
            int i = Modele.MaConnexion.Visiteur.ToList().Count();
            monVisiteur.idVisiteur = i.ToString("x3");
            monVisiteur.nom = txtNom.Text;
            monVisiteur.prenom = txtPrenom.Text;
            monVisiteur.rue = txtRue.Text;
            monVisiteur.ville = txtVille.Text;
            monVisiteur.cp = txtCP.Text;
            monVisiteur.dateEmbauche = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            monVisiteur.identifiant = txtIdentifiant.Text;
            monVisiteur.password = txtMotDePasse.Text;
            monVisiteur.idLabo = int.Parse(cboLaboratoire.SelectedValue.ToString());
            Modele.MaConnexion.Visiteur.AddObject(monVisiteur);
            Modele.MaConnexion.SaveChanges();
            MessageBox.Show("Enregistrement ok", "Action");
            this.Close();
        }

        private void frmAjoutVisiteur_Load(object sender, EventArgs e)
        {
            
            cboLaboratoire.ValueMember = "idLabo"; // permet de stocker l'identifiant
            cboLaboratoire.DisplayMember = "nomLabo";
            bsLaboratoire.DataSource = Modele.MaConnexion.Laboratoire.ToList();
            cboLaboratoire.DataSource = bsLaboratoire;
 
        }

      

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
                e.Handled = true;

        }

        private void txtPrenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
                e.Handled = true;

        }

        private void txtVille_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
                e.Handled = true;

        }

   
    }
}
