namespace PPE3GSB
{
    partial class frmModification
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.lblCp = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.btnEnregistrement = new System.Windows.Forms.Button();
            this.lblTitreMotDePasse = new System.Windows.Forms.Label();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.lblMotDePasseActuel = new System.Windows.Forms.Label();
            this.lblNouveauMotDePasse = new System.Windows.Forms.Label();
            this.txtMotDePasseActuel = new System.Windows.Forms.TextBox();
            this.txtNouveauMotDePasse = new System.Windows.Forms.TextBox();
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.txtConfirmation = new System.Windows.Forms.TextBox();
            this.btnEnregistrerMotDePasse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(290, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(116, 24);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Mon compte";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Location = new System.Drawing.Point(187, 59);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(33, 13);
            this.lblRue.TabIndex = 1;
            this.lblRue.Text = "Rue :";
            // 
            // lblCp
            // 
            this.lblCp.AutoSize = true;
            this.lblCp.Location = new System.Drawing.Point(188, 98);
            this.lblCp.Name = "lblCp";
            this.lblCp.Size = new System.Drawing.Size(25, 13);
            this.lblCp.TabIndex = 2;
            this.lblCp.Text = "cp :";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(188, 134);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(32, 13);
            this.lblVille.TabIndex = 3;
            this.lblVille.Text = "Ville :";
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(169, 173);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(59, 13);
            this.lblIdentifiant.TabIndex = 4;
            this.lblIdentifiant.Text = "Identifiant :";
            // 
            // btnEnregistrement
            // 
            this.btnEnregistrement.Location = new System.Drawing.Point(264, 206);
            this.btnEnregistrement.Name = "btnEnregistrement";
            this.btnEnregistrement.Size = new System.Drawing.Size(154, 23);
            this.btnEnregistrement.TabIndex = 5;
            this.btnEnregistrement.Text = "Enregistrez les modifications";
            this.btnEnregistrement.UseVisualStyleBackColor = true;
            // 
            // lblTitreMotDePasse
            // 
            this.lblTitreMotDePasse.AutoSize = true;
            this.lblTitreMotDePasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreMotDePasse.Location = new System.Drawing.Point(187, 250);
            this.lblTitreMotDePasse.Name = "lblTitreMotDePasse";
            this.lblTitreMotDePasse.Size = new System.Drawing.Size(241, 24);
            this.lblTitreMotDePasse.TabIndex = 6;
            this.lblTitreMotDePasse.Text = "Modifiez mon mot de passe";
            this.lblTitreMotDePasse.Click += new System.EventHandler(this.lblTitreMotDePasse_Click);
            // 
            // txtRue
            // 
            this.txtRue.Location = new System.Drawing.Point(264, 56);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(100, 20);
            this.txtRue.TabIndex = 7;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(264, 95);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(100, 20);
            this.txtCP.TabIndex = 8;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(264, 131);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(100, 20);
            this.txtVille.TabIndex = 9;
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(264, 170);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(100, 20);
            this.txtIdentifiant.TabIndex = 10;
            // 
            // lblMotDePasseActuel
            // 
            this.lblMotDePasseActuel.AutoSize = true;
            this.lblMotDePasseActuel.Location = new System.Drawing.Point(119, 336);
            this.lblMotDePasseActuel.Name = "lblMotDePasseActuel";
            this.lblMotDePasseActuel.Size = new System.Drawing.Size(109, 13);
            this.lblMotDePasseActuel.TabIndex = 11;
            this.lblMotDePasseActuel.Text = "Mot de passe actuel :";
            // 
            // lblNouveauMotDePasse
            // 
            this.lblNouveauMotDePasse.AutoSize = true;
            this.lblNouveauMotDePasse.Location = new System.Drawing.Point(105, 378);
            this.lblNouveauMotDePasse.Name = "lblNouveauMotDePasse";
            this.lblNouveauMotDePasse.Size = new System.Drawing.Size(123, 13);
            this.lblNouveauMotDePasse.TabIndex = 12;
            this.lblNouveauMotDePasse.Text = "Nouveau mot de passe :";
            // 
            // txtMotDePasseActuel
            // 
            this.txtMotDePasseActuel.Location = new System.Drawing.Point(264, 333);
            this.txtMotDePasseActuel.Name = "txtMotDePasseActuel";
            this.txtMotDePasseActuel.Size = new System.Drawing.Size(100, 20);
            this.txtMotDePasseActuel.TabIndex = 13;
            // 
            // txtNouveauMotDePasse
            // 
            this.txtNouveauMotDePasse.Location = new System.Drawing.Point(264, 371);
            this.txtNouveauMotDePasse.Name = "txtNouveauMotDePasse";
            this.txtNouveauMotDePasse.Size = new System.Drawing.Size(100, 20);
            this.txtNouveauMotDePasse.TabIndex = 14;
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.AutoSize = true;
            this.lblConfirmation.Location = new System.Drawing.Point(31, 417);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(197, 13);
            this.lblConfirmation.TabIndex = 15;
            this.lblConfirmation.Text = "Confirmation du nouveau mot de passe :";
            // 
            // txtConfirmation
            // 
            this.txtConfirmation.Location = new System.Drawing.Point(264, 414);
            this.txtConfirmation.Name = "txtConfirmation";
            this.txtConfirmation.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmation.TabIndex = 16;
            // 
            // btnEnregistrerMotDePasse
            // 
            this.btnEnregistrerMotDePasse.Location = new System.Drawing.Point(255, 458);
            this.btnEnregistrerMotDePasse.Name = "btnEnregistrerMotDePasse";
            this.btnEnregistrerMotDePasse.Size = new System.Drawing.Size(151, 23);
            this.btnEnregistrerMotDePasse.TabIndex = 17;
            this.btnEnregistrerMotDePasse.Text = "Enregistrer les modifications";
            this.btnEnregistrerMotDePasse.UseVisualStyleBackColor = true;
            // 
            // frmModification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 493);
            this.Controls.Add(this.btnEnregistrerMotDePasse);
            this.Controls.Add(this.txtConfirmation);
            this.Controls.Add(this.lblConfirmation);
            this.Controls.Add(this.txtNouveauMotDePasse);
            this.Controls.Add(this.txtMotDePasseActuel);
            this.Controls.Add(this.lblNouveauMotDePasse);
            this.Controls.Add(this.lblMotDePasseActuel);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtRue);
            this.Controls.Add(this.lblTitreMotDePasse);
            this.Controls.Add(this.btnEnregistrement);
            this.Controls.Add(this.lblIdentifiant);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblCp);
            this.Controls.Add(this.lblRue);
            this.Controls.Add(this.lblTitre);
            this.Name = "frmModification";
            this.Text = "frmModification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Label lblCp;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Button btnEnregistrement;
        private System.Windows.Forms.Label lblTitreMotDePasse;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.Label lblMotDePasseActuel;
        private System.Windows.Forms.Label lblNouveauMotDePasse;
        private System.Windows.Forms.TextBox txtMotDePasseActuel;
        private System.Windows.Forms.TextBox txtNouveauMotDePasse;
        private System.Windows.Forms.Label lblConfirmation;
        private System.Windows.Forms.TextBox txtConfirmation;
        private System.Windows.Forms.Button btnEnregistrerMotDePasse;
    }
}