namespace PPE3GSB
{
    partial class frmRegionVisiteur
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboRegion = new System.Windows.Forms.ComboBox();
            this.dgvVisiteur = new System.Windows.Forms.DataGridView();
            this.idVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.lblDateEmbauche = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtCodePostal = new System.Windows.Forms.TextBox();
            this.txtDateEmbauche = new System.Windows.Forms.TextBox();
            this.bsRegion = new System.Windows.Forms.BindingSource(this.components);
            this.btnResponsable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Region :";
            // 
            // cboRegion
            // 
            this.cboRegion.FormattingEnabled = true;
            this.cboRegion.Location = new System.Drawing.Point(106, 41);
            this.cboRegion.Name = "cboRegion";
            this.cboRegion.Size = new System.Drawing.Size(121, 21);
            this.cboRegion.TabIndex = 1;
            this.cboRegion.SelectedIndexChanged += new System.EventHandler(this.cboRegion_SelectedIndexChanged);
            // 
            // dgvVisiteur
            // 
            this.dgvVisiteur.AutoGenerateColumns = false;
            this.dgvVisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVisiteur,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8});
            this.dgvVisiteur.DataSource = this.bsVisiteur;
            this.dgvVisiteur.Location = new System.Drawing.Point(74, 103);
            this.dgvVisiteur.Name = "dgvVisiteur";
            this.dgvVisiteur.Size = new System.Drawing.Size(750, 220);
            this.dgvVisiteur.TabIndex = 3;
            // 
            // idVisiteur
            // 
            this.idVisiteur.DataPropertyName = "idVisiteur";
            this.idVisiteur.HeaderText = "idVisiteur";
            this.idVisiteur.Name = "idVisiteur";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nom";
            this.dataGridViewTextBoxColumn3.HeaderText = "nom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "prenom";
            this.dataGridViewTextBoxColumn4.HeaderText = "prenom";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "rue";
            this.dataGridViewTextBoxColumn5.HeaderText = "rue";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ville";
            this.dataGridViewTextBoxColumn7.HeaderText = "ville";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "cp";
            this.dataGridViewTextBoxColumn6.HeaderText = "cp";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "dateEmbauche";
            this.dataGridViewTextBoxColumn8.HeaderText = "dateEmbauche";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // bsVisiteur
            // 
            this.bsVisiteur.DataSource = typeof(PPE3GSB.Visiteur);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(320, 360);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(181, 20);
            this.lblTitre.TabIndex = 5;
            this.lblTitre.Text = "Responsable de region :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(71, 410);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 6;
            this.lblNom.Text = "Nom :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(71, 446);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 7;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Location = new System.Drawing.Point(71, 486);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(33, 13);
            this.lblRue.TabIndex = 8;
            this.lblRue.Text = "Rue :";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(71, 523);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(32, 13);
            this.lblVille.TabIndex = 10;
            this.lblVille.Text = "Ville :";
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.AutoSize = true;
            this.lblCodePostal.Location = new System.Drawing.Point(71, 567);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(73, 13);
            this.lblCodePostal.TabIndex = 11;
            this.lblCodePostal.Text = " Code Postal :";
            // 
            // lblDateEmbauche
            // 
            this.lblDateEmbauche.AutoSize = true;
            this.lblDateEmbauche.Location = new System.Drawing.Point(71, 610);
            this.lblDateEmbauche.Name = "lblDateEmbauche";
            this.lblDateEmbauche.Size = new System.Drawing.Size(97, 13);
            this.lblDateEmbauche.TabIndex = 12;
            this.lblDateEmbauche.Text = "Date d\'embauche :";
            // 
            // txtNom
            // 
            this.txtNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisiteur, "nom", true));
            this.txtNom.Location = new System.Drawing.Point(190, 407);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 13;
            // 
            // txtPrenom
            // 
            this.txtPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisiteur, "prenom", true));
            this.txtPrenom.Location = new System.Drawing.Point(190, 443);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 14;
            // 
            // txtRue
            // 
            this.txtRue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisiteur, "rue", true));
            this.txtRue.Location = new System.Drawing.Point(190, 483);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(100, 20);
            this.txtRue.TabIndex = 15;
            // 
            // txtVille
            // 
            this.txtVille.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisiteur, "ville", true));
            this.txtVille.Location = new System.Drawing.Point(190, 520);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(100, 20);
            this.txtVille.TabIndex = 16;
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisiteur, "cp", true));
            this.txtCodePostal.Location = new System.Drawing.Point(190, 564);
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(100, 20);
            this.txtCodePostal.TabIndex = 17;
            // 
            // txtDateEmbauche
            // 
            this.txtDateEmbauche.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisiteur, "dateEmbauche", true));
            this.txtDateEmbauche.Location = new System.Drawing.Point(190, 607);
            this.txtDateEmbauche.Name = "txtDateEmbauche";
            this.txtDateEmbauche.Size = new System.Drawing.Size(100, 20);
            this.txtDateEmbauche.TabIndex = 18;
            // 
            // bsRegion
            // 
            this.bsRegion.DataSource = typeof(PPE3GSB.Region);
            // 
            // btnResponsable
            // 
            this.btnResponsable.Location = new System.Drawing.Point(578, 436);
            this.btnResponsable.Name = "btnResponsable";
            this.btnResponsable.Size = new System.Drawing.Size(136, 23);
            this.btnResponsable.TabIndex = 19;
            this.btnResponsable.Text = "Modifier responsable";
            this.btnResponsable.UseVisualStyleBackColor = true;
            // 
            // frmRegionVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 656);
            this.Controls.Add(this.btnResponsable);
            this.Controls.Add(this.txtDateEmbauche);
            this.Controls.Add(this.txtCodePostal);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtRue);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblDateEmbauche);
            this.Controls.Add(this.lblCodePostal);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblRue);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.dgvVisiteur);
            this.Controls.Add(this.cboRegion);
            this.Controls.Add(this.label1);
            this.Name = "frmRegionVisiteur";
            this.Text = "frmRegionVisiteur";
            this.Load += new System.EventHandler(this.frmRegionVisiteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboRegion;
        private System.Windows.Forms.BindingSource bsVisiteur;
        private System.Windows.Forms.DataGridView dgvVisiteur;
        private System.Windows.Forms.BindingSource bsRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblCodePostal;
        private System.Windows.Forms.Label lblDateEmbauche;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtCodePostal;
        private System.Windows.Forms.TextBox txtDateEmbauche;
        private System.Windows.Forms.Button btnResponsable;
    }
}