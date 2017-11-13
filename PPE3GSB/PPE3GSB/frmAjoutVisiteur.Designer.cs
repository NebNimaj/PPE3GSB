namespace PPE3GSB
{
    partial class frmAjoutVisiteur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblDateEmbauche = new System.Windows.Forms.Label();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.lblLaboratoire = new System.Windows.Forms.Label();
            this.cboLaboratoire = new System.Windows.Forms.ComboBox();
            this.bsLaboratoire = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsLaboratoire)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(37, 91);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(35, 153);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prenom :";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Location = new System.Drawing.Point(37, 204);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(33, 13);
            this.lblRue.TabIndex = 2;
            this.lblRue.Text = "Rue :";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(37, 306);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(27, 13);
            this.lblCP.TabIndex = 3;
            this.lblCP.Text = "CP :";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(37, 258);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(32, 13);
            this.lblVille.TabIndex = 4;
            this.lblVille.Text = "Ville :";
            // 
            // lblDateEmbauche
            // 
            this.lblDateEmbauche.AutoSize = true;
            this.lblDateEmbauche.Location = new System.Drawing.Point(35, 364);
            this.lblDateEmbauche.Name = "lblDateEmbauche";
            this.lblDateEmbauche.Size = new System.Drawing.Size(95, 13);
            this.lblDateEmbauche.TabIndex = 5;
            this.lblDateEmbauche.Text = "date d\'embauche :";
            this.lblDateEmbauche.Click += new System.EventHandler(this.lblDateEmbauche_Click);
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(37, 411);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(39, 13);
            this.lblIdentifiant.TabIndex = 6;
            this.lblIdentifiant.Text = "Login :";
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Location = new System.Drawing.Point(37, 456);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(78, 13);
            this.lblMotDePasse.TabIndex = 7;
            this.lblMotDePasse.Text = "Mot de Passe :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(151, 88);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 8;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(151, 150);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 9;
            // 
            // txtRue
            // 
            this.txtRue.Location = new System.Drawing.Point(151, 201);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(100, 20);
            this.txtRue.TabIndex = 10;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(151, 299);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(100, 20);
            this.txtCP.TabIndex = 11;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(151, 251);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(100, 20);
            this.txtVille.TabIndex = 12;
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.Location = new System.Drawing.Point(151, 456);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.Size = new System.Drawing.Size(100, 20);
            this.txtMotDePasse.TabIndex = 15;
            this.txtMotDePasse.TextChanged += new System.EventHandler(this.txtMotDePasse_TextChanged);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(151, 578);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 16;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(133, 21);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(271, 25);
            this.lblTitre.TabIndex = 17;
            this.lblTitre.Text = "Ajout d\'un nouveau visiteur";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "YYYY-MM-dd";
            this.dateTimePicker1.Location = new System.Drawing.Point(151, 358);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(151, 408);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(100, 20);
            this.txtIdentifiant.TabIndex = 14;
            // 
            // lblLaboratoire
            // 
            this.lblLaboratoire.AutoSize = true;
            this.lblLaboratoire.Location = new System.Drawing.Point(37, 511);
            this.lblLaboratoire.Name = "lblLaboratoire";
            this.lblLaboratoire.Size = new System.Drawing.Size(66, 13);
            this.lblLaboratoire.TabIndex = 19;
            this.lblLaboratoire.Text = "Laboratoire :";
            // 
            // cboLaboratoire
            // 
            this.cboLaboratoire.FormattingEnabled = true;
            this.cboLaboratoire.Location = new System.Drawing.Point(151, 508);
            this.cboLaboratoire.Name = "cboLaboratoire";
            this.cboLaboratoire.Size = new System.Drawing.Size(121, 21);
            this.cboLaboratoire.TabIndex = 20;
            // 
            // bsLaboratoire
            // 
            this.bsLaboratoire.DataSource = typeof(PPE3GSB.Laboratoire);
            // 
            // frmAjoutVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 635);
            this.Controls.Add(this.cboLaboratoire);
            this.Controls.Add(this.lblLaboratoire);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.txtMotDePasse);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtRue);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.lblIdentifiant);
            this.Controls.Add(this.lblDateEmbauche);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.lblRue);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Name = "frmAjoutVisiteur";
            this.Text = "frmAjoutVisiteur";
            this.Load += new System.EventHandler(this.frmAjoutVisiteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsLaboratoire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblDateEmbauche;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.Label lblLaboratoire;
        private System.Windows.Forms.ComboBox cboLaboratoire;
        private System.Windows.Forms.BindingSource bsLaboratoire;
    }
}