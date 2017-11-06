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
            this.components = new System.ComponentModel.Container();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.lblCp = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.btnEnregistrement = new System.Windows.Forms.Button();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
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
            this.btnEnregistrement.Location = new System.Drawing.Point(232, 267);
            this.btnEnregistrement.Name = "btnEnregistrement";
            this.btnEnregistrement.Size = new System.Drawing.Size(154, 23);
            this.btnEnregistrement.TabIndex = 5;
            this.btnEnregistrement.Text = "Enregistrez les modifications";
            this.btnEnregistrement.UseVisualStyleBackColor = true;
            this.btnEnregistrement.Click += new System.EventHandler(this.btnEnregistrement_Click);
            // 
            // txtRue
            // 
            this.txtRue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisiteur, "rue", true));
            this.txtRue.Location = new System.Drawing.Point(264, 56);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(100, 20);
            this.txtRue.TabIndex = 7;
            // 
            // txtCP
            // 
            this.txtCP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisiteur, "cp", true));
            this.txtCP.Location = new System.Drawing.Point(264, 95);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(100, 20);
            this.txtCP.TabIndex = 8;
            // 
            // txtVille
            // 
            this.txtVille.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisiteur, "ville", true));
            this.txtVille.Location = new System.Drawing.Point(264, 131);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(100, 20);
            this.txtVille.TabIndex = 9;
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisiteur, "identifiant", true));
            this.txtIdentifiant.Location = new System.Drawing.Point(264, 170);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(100, 20);
            this.txtIdentifiant.TabIndex = 10;
            // 
            // bsVisiteur
            // 
            this.bsVisiteur.DataSource = typeof(PPE3GSB.Visiteur);
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisiteur, "password", true));
            this.txtMotDePasse.Location = new System.Drawing.Point(264, 221);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.Size = new System.Drawing.Size(100, 20);
            this.txtMotDePasse.TabIndex = 13;
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Location = new System.Drawing.Point(143, 224);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(77, 13);
            this.lblMotDePasse.TabIndex = 11;
            this.lblMotDePasse.Text = "Mot de passe :";
            // 
            // frmModification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 314);
            this.Controls.Add(this.txtMotDePasse);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtRue);
            this.Controls.Add(this.btnEnregistrement);
            this.Controls.Add(this.lblIdentifiant);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblCp);
            this.Controls.Add(this.lblRue);
            this.Controls.Add(this.lblTitre);
            this.Name = "frmModification";
            this.Text = "frmModification";
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
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
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.BindingSource bsVisiteur;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Label lblMotDePasse;
    }
}