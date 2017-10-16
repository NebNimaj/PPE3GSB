namespace PPE3GSB
{
    partial class frmVisiteur
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
            this.lblCp = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblDateEmbauche = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtDateEmbauche = new System.Windows.Forms.TextBox();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.lblLaboratoire = new System.Windows.Forms.Label();
            this.txtLaboratoire = new System.Windows.Forms.TextBox();
            this.bsLaboratoire = new System.Windows.Forms.BindingSource(this.components);
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.btnModification = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLaboratoire)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(26, 84);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(43, 16);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            this.lblNom.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(26, 114);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(61, 16);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRue.Location = new System.Drawing.Point(26, 151);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(39, 16);
            this.lblRue.TabIndex = 2;
            this.lblRue.Text = "Rue :";
            // 
            // lblCp
            // 
            this.lblCp.AutoSize = true;
            this.lblCp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCp.Location = new System.Drawing.Point(26, 191);
            this.lblCp.Name = "lblCp";
            this.lblCp.Size = new System.Drawing.Size(29, 16);
            this.lblCp.TabIndex = 3;
            this.lblCp.Text = "cp :";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.Location = new System.Drawing.Point(26, 231);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(40, 16);
            this.lblVille.TabIndex = 4;
            this.lblVille.Text = "Ville :";
            // 
            // lblDateEmbauche
            // 
            this.lblDateEmbauche.AutoSize = true;
            this.lblDateEmbauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateEmbauche.Location = new System.Drawing.Point(26, 266);
            this.lblDateEmbauche.Name = "lblDateEmbauche";
            this.lblDateEmbauche.Size = new System.Drawing.Size(121, 16);
            this.lblDateEmbauche.TabIndex = 5;
            this.lblDateEmbauche.Text = "Date d\'embauche :";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(89, 21);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(196, 29);
            this.lblTitre.TabIndex = 8;
            this.lblTitre.Text = "Mes informations";
            this.lblTitre.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // txtNom
            // 
            this.txtNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisiteur, "nom", true));
            this.txtNom.Location = new System.Drawing.Point(151, 85);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 9;
            // 
            // bsVisiteur
            // 
            this.bsVisiteur.CurrentChanged += new System.EventHandler(this.bsVisiteur_CurrentChanged);
            // 
            // txtPrenom
            // 
            this.txtPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisiteur, "prenom", true));
            this.txtPrenom.Location = new System.Drawing.Point(151, 111);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 10;
            this.txtPrenom.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtRue
            // 
            this.txtRue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisiteur, "rue", true));
            this.txtRue.Location = new System.Drawing.Point(151, 144);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(100, 20);
            this.txtRue.TabIndex = 11;
            // 
            // txtCp
            // 
            this.txtCp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisiteur, "cp", true));
            this.txtCp.Location = new System.Drawing.Point(151, 188);
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(100, 20);
            this.txtCp.TabIndex = 12;
            // 
            // txtVille
            // 
            this.txtVille.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisiteur, "ville", true));
            this.txtVille.Location = new System.Drawing.Point(151, 231);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(100, 20);
            this.txtVille.TabIndex = 13;
            // 
            // txtDateEmbauche
            // 
            this.txtDateEmbauche.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisiteur, "dateEmbauche", true));
            this.txtDateEmbauche.Location = new System.Drawing.Point(151, 263);
            this.txtDateEmbauche.Name = "txtDateEmbauche";
            this.txtDateEmbauche.Size = new System.Drawing.Size(100, 20);
            this.txtDateEmbauche.TabIndex = 14;
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisiteur, "identifiant", true));
            this.txtIdentifiant.Location = new System.Drawing.Point(151, 350);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(100, 20);
            this.txtIdentifiant.TabIndex = 15;
            // 
            // lblLaboratoire
            // 
            this.lblLaboratoire.AutoSize = true;
            this.lblLaboratoire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaboratoire.Location = new System.Drawing.Point(26, 313);
            this.lblLaboratoire.Name = "lblLaboratoire";
            this.lblLaboratoire.Size = new System.Drawing.Size(86, 16);
            this.lblLaboratoire.TabIndex = 17;
            this.lblLaboratoire.Text = "Laboratoire : ";
            // 
            // txtLaboratoire
            // 
            this.txtLaboratoire.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLaboratoire, "nomLabo", true));
            this.txtLaboratoire.Location = new System.Drawing.Point(151, 312);
            this.txtLaboratoire.Name = "txtLaboratoire";
            this.txtLaboratoire.Size = new System.Drawing.Size(100, 20);
            this.txtLaboratoire.TabIndex = 18;
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentifiant.Location = new System.Drawing.Point(26, 350);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(70, 16);
            this.lblIdentifiant.TabIndex = 6;
            this.lblIdentifiant.Text = "Identifiant :";
            // 
            // btnModification
            // 
            this.btnModification.Location = new System.Drawing.Point(419, 111);
            this.btnModification.Name = "btnModification";
            this.btnModification.Size = new System.Drawing.Size(142, 23);
            this.btnModification.TabIndex = 19;
            this.btnModification.Text = "Modifiez vos informations";
            this.btnModification.UseVisualStyleBackColor = true;
            this.btnModification.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 485);
            this.Controls.Add(this.btnModification);
            this.Controls.Add(this.txtLaboratoire);
            this.Controls.Add(this.lblLaboratoire);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.txtDateEmbauche);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtCp);
            this.Controls.Add(this.txtRue);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblIdentifiant);
            this.Controls.Add(this.lblDateEmbauche);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblCp);
            this.Controls.Add(this.lblRue);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Name = "frmVisiteur";
            this.Text = "Visiteur";
            this.Load += new System.EventHandler(this.frmVisiteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLaboratoire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Label lblCp;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblDateEmbauche;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.TextBox txtCp;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtDateEmbauche;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.Label lblLaboratoire;
        private System.Windows.Forms.TextBox txtLaboratoire;
        private System.Windows.Forms.BindingSource bsVisiteur;
        private System.Windows.Forms.BindingSource bsLaboratoire;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Button btnModification;
    }
}