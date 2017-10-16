namespace PPE3GSB
{
    partial class frmDetailsMedecin
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
            System.Windows.Forms.Label lblAdresse;
            System.Windows.Forms.Label lblDepartement;
            System.Windows.Forms.Label lblIdMedecin;
            System.Windows.Forms.Label lblIdSpecialite;
            System.Windows.Forms.Label lblNom;
            System.Windows.Forms.Label lblPrenom;
            System.Windows.Forms.Label lblTel;
            System.Windows.Forms.Label lblLibSpecialite;
            this.mEDECINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtDepartement = new System.Windows.Forms.TextBox();
            this.txtIdMedecin = new System.Windows.Forms.TextBox();
            this.txtIdSpecialite = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtLibSpecialite = new System.Windows.Forms.TextBox();
            this.btnFermer = new System.Windows.Forms.Button();
            lblAdresse = new System.Windows.Forms.Label();
            lblDepartement = new System.Windows.Forms.Label();
            lblIdMedecin = new System.Windows.Forms.Label();
            lblIdSpecialite = new System.Windows.Forms.Label();
            lblNom = new System.Windows.Forms.Label();
            lblPrenom = new System.Windows.Forms.Label();
            lblTel = new System.Windows.Forms.Label();
            lblLibSpecialite = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mEDECINBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Location = new System.Drawing.Point(208, 9);
            this.lblTitre.Visible = false;
            // 
            // lblAdresse
            // 
            lblAdresse.AutoSize = true;
            lblAdresse.BackColor = System.Drawing.Color.Transparent;
            lblAdresse.Location = new System.Drawing.Point(30, 52);
            lblAdresse.Name = "lblAdresse";
            lblAdresse.Size = new System.Drawing.Size(47, 13);
            lblAdresse.TabIndex = 1;
            lblAdresse.Text = "adresse:";
            // 
            // lblDepartement
            // 
            lblDepartement.AutoSize = true;
            lblDepartement.BackColor = System.Drawing.Color.Transparent;
            lblDepartement.Location = new System.Drawing.Point(30, 78);
            lblDepartement.Name = "lblDepartement";
            lblDepartement.Size = new System.Drawing.Size(69, 13);
            lblDepartement.TabIndex = 3;
            lblDepartement.Text = "departement:";
            // 
            // lblIdMedecin
            // 
            lblIdMedecin.AutoSize = true;
            lblIdMedecin.BackColor = System.Drawing.Color.Transparent;
            lblIdMedecin.Location = new System.Drawing.Point(30, 168);
            lblIdMedecin.Name = "lblIdMedecin";
            lblIdMedecin.Size = new System.Drawing.Size(62, 13);
            lblIdMedecin.TabIndex = 5;
            lblIdMedecin.Text = "id Medecin:";
            // 
            // lblIdSpecialite
            // 
            lblIdSpecialite.AutoSize = true;
            lblIdSpecialite.BackColor = System.Drawing.Color.Transparent;
            lblIdSpecialite.Location = new System.Drawing.Point(30, 194);
            lblIdSpecialite.Name = "lblIdSpecialite";
            lblIdSpecialite.Size = new System.Drawing.Size(67, 13);
            lblIdSpecialite.TabIndex = 7;
            lblIdSpecialite.Text = "id Specialite:";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.BackColor = System.Drawing.Color.Transparent;
            lblNom.Location = new System.Drawing.Point(30, 107);
            lblNom.Name = "lblNom";
            lblNom.Size = new System.Drawing.Size(30, 13);
            lblNom.TabIndex = 9;
            lblNom.Text = "nom:";
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.BackColor = System.Drawing.Color.Transparent;
            lblPrenom.Location = new System.Drawing.Point(30, 133);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new System.Drawing.Size(45, 13);
            lblPrenom.TabIndex = 11;
            lblPrenom.Text = "prenom:";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.BackColor = System.Drawing.Color.Transparent;
            lblTel.Location = new System.Drawing.Point(30, 220);
            lblTel.Name = "lblTel";
            lblTel.Size = new System.Drawing.Size(21, 13);
            lblTel.TabIndex = 13;
            lblTel.Text = "tel:";
            // 
            // lblLibSpecialite
            // 
            lblLibSpecialite.AutoSize = true;
            lblLibSpecialite.BackColor = System.Drawing.Color.Transparent;
            lblLibSpecialite.Location = new System.Drawing.Point(30, 249);
            lblLibSpecialite.Name = "lblLibSpecialite";
            lblLibSpecialite.Size = new System.Drawing.Size(69, 13);
            lblLibSpecialite.TabIndex = 17;
            lblLibSpecialite.Text = "lib Specialite:";
            // 
            // mEDECINBindingSource
            // 
            this.mEDECINBindingSource.DataSource = typeof(PPE3GSB.MEDECIN);
            // 
            // txtAdresse
            // 
            this.txtAdresse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mEDECINBindingSource, "adresse", true));
            this.txtAdresse.Location = new System.Drawing.Point(98, 49);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.ReadOnly = true;
            this.txtAdresse.Size = new System.Drawing.Size(255, 20);
            this.txtAdresse.TabIndex = 2;
            // 
            // txtDepartement
            // 
            this.txtDepartement.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mEDECINBindingSource, "departement", true));
            this.txtDepartement.Location = new System.Drawing.Point(98, 75);
            this.txtDepartement.Name = "txtDepartement";
            this.txtDepartement.ReadOnly = true;
            this.txtDepartement.Size = new System.Drawing.Size(255, 20);
            this.txtDepartement.TabIndex = 4;
            // 
            // txtIdMedecin
            // 
            this.txtIdMedecin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mEDECINBindingSource, "idMedecin", true));
            this.txtIdMedecin.Location = new System.Drawing.Point(98, 165);
            this.txtIdMedecin.Name = "txtIdMedecin";
            this.txtIdMedecin.ReadOnly = true;
            this.txtIdMedecin.Size = new System.Drawing.Size(255, 20);
            this.txtIdMedecin.TabIndex = 6;
            // 
            // txtIdSpecialite
            // 
            this.txtIdSpecialite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mEDECINBindingSource, "idSpecialite", true));
            this.txtIdSpecialite.Location = new System.Drawing.Point(98, 191);
            this.txtIdSpecialite.Name = "txtIdSpecialite";
            this.txtIdSpecialite.ReadOnly = true;
            this.txtIdSpecialite.Size = new System.Drawing.Size(255, 20);
            this.txtIdSpecialite.TabIndex = 8;
            // 
            // txtNom
            // 
            this.txtNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mEDECINBindingSource, "nom", true));
            this.txtNom.Location = new System.Drawing.Point(98, 104);
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(255, 20);
            this.txtNom.TabIndex = 10;
            // 
            // txtPrenom
            // 
            this.txtPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mEDECINBindingSource, "prenom", true));
            this.txtPrenom.Location = new System.Drawing.Point(98, 130);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.ReadOnly = true;
            this.txtPrenom.Size = new System.Drawing.Size(255, 20);
            this.txtPrenom.TabIndex = 12;
            // 
            // txtTel
            // 
            this.txtTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mEDECINBindingSource, "tel", true));
            this.txtTel.Location = new System.Drawing.Point(98, 217);
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(255, 20);
            this.txtTel.TabIndex = 14;
            // 
            // txtLibSpecialite
            // 
            this.txtLibSpecialite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mEDECINBindingSource, "SPECIALITE.libSpecialite", true));
            this.txtLibSpecialite.Location = new System.Drawing.Point(98, 246);
            this.txtLibSpecialite.Name = "txtLibSpecialite";
            this.txtLibSpecialite.ReadOnly = true;
            this.txtLibSpecialite.Size = new System.Drawing.Size(255, 20);
            this.txtLibSpecialite.TabIndex = 18;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(469, 158);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 19;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // frmDetailsMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 375);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(lblLibSpecialite);
            this.Controls.Add(this.txtLibSpecialite);
            this.Controls.Add(lblAdresse);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(lblDepartement);
            this.Controls.Add(this.txtDepartement);
            this.Controls.Add(lblIdMedecin);
            this.Controls.Add(this.txtIdMedecin);
            this.Controls.Add(lblIdSpecialite);
            this.Controls.Add(this.txtIdSpecialite);
            this.Controls.Add(lblNom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(lblPrenom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(lblTel);
            this.Controls.Add(this.txtTel);
            this.Name = "frmDetailsMedecin";
            this.Text = "frmDetailsMedecin";
            this.Load += new System.EventHandler(this.frmDetailsMedecin_Load);
            this.Controls.SetChildIndex(this.txtTel, 0);
            this.Controls.SetChildIndex(lblTel, 0);
            this.Controls.SetChildIndex(this.txtPrenom, 0);
            this.Controls.SetChildIndex(lblPrenom, 0);
            this.Controls.SetChildIndex(this.txtNom, 0);
            this.Controls.SetChildIndex(lblNom, 0);
            this.Controls.SetChildIndex(this.txtIdSpecialite, 0);
            this.Controls.SetChildIndex(lblIdSpecialite, 0);
            this.Controls.SetChildIndex(this.txtIdMedecin, 0);
            this.Controls.SetChildIndex(lblIdMedecin, 0);
            this.Controls.SetChildIndex(this.txtDepartement, 0);
            this.Controls.SetChildIndex(lblDepartement, 0);
            this.Controls.SetChildIndex(this.txtAdresse, 0);
            this.Controls.SetChildIndex(lblAdresse, 0);
            this.Controls.SetChildIndex(this.txtLibSpecialite, 0);
            this.Controls.SetChildIndex(lblLibSpecialite, 0);
            this.Controls.SetChildIndex(this.btnFermer, 0);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            ((System.ComponentModel.ISupportInitialize)(this.mEDECINBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource mEDECINBindingSource;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtDepartement;
        private System.Windows.Forms.TextBox txtIdMedecin;
        private System.Windows.Forms.TextBox txtIdSpecialite;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtLibSpecialite;
        private System.Windows.Forms.Button btnFermer;
    }
}