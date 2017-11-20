namespace PPE3GSB
{
    partial class frmLaboratoireVisiteur
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
            this.lblLaboratoire = new System.Windows.Forms.Label();
            this.cboLaboratoire = new System.Windows.Forms.ComboBox();
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.dgvVisiteur = new System.Windows.Forms.DataGridView();
            this.bsLaboratoire = new System.Windows.Forms.BindingSource(this.components);
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEmbaucheDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLaboratoire)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLaboratoire
            // 
            this.lblLaboratoire.AutoSize = true;
            this.lblLaboratoire.Location = new System.Drawing.Point(37, 34);
            this.lblLaboratoire.Name = "lblLaboratoire";
            this.lblLaboratoire.Size = new System.Drawing.Size(66, 13);
            this.lblLaboratoire.TabIndex = 0;
            this.lblLaboratoire.Text = "Laboratoire :";
            // 
            // cboLaboratoire
            // 
            this.cboLaboratoire.FormattingEnabled = true;
            this.cboLaboratoire.Location = new System.Drawing.Point(132, 31);
            this.cboLaboratoire.Name = "cboLaboratoire";
            this.cboLaboratoire.Size = new System.Drawing.Size(121, 21);
            this.cboLaboratoire.TabIndex = 1;
            this.cboLaboratoire.SelectedIndexChanged += new System.EventHandler(this.cboLaboratoire_SelectedIndexChanged);
            // 
            // bsVisiteur
            // 
            this.bsVisiteur.DataSource = typeof(PPE3GSB.Visiteur);
            // 
            // dgvVisiteur
            // 
            this.dgvVisiteur.AutoGenerateColumns = false;
            this.dgvVisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.prenom,
            this.rue,
            this.villeDataGridViewTextBoxColumn,
            this.cpDataGridViewTextBoxColumn,
            this.dateEmbaucheDataGridViewTextBoxColumn});
            this.dgvVisiteur.DataSource = this.bsVisiteur;
            this.dgvVisiteur.Location = new System.Drawing.Point(25, 102);
            this.dgvVisiteur.Name = "dgvVisiteur";
            this.dgvVisiteur.Size = new System.Drawing.Size(645, 220);
            this.dgvVisiteur.TabIndex = 3;
            // 
            // bsLaboratoire
            // 
            this.bsLaboratoire.DataSource = typeof(PPE3GSB.Laboratoire);
            // 
            // nom
            // 
            this.nom.DataPropertyName = "nom";
            this.nom.HeaderText = "nom";
            this.nom.Name = "nom";
            // 
            // prenom
            // 
            this.prenom.DataPropertyName = "prenom";
            this.prenom.HeaderText = "prenom";
            this.prenom.Name = "prenom";
            // 
            // rue
            // 
            this.rue.DataPropertyName = "rue";
            this.rue.HeaderText = "rue";
            this.rue.Name = "rue";
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "ville";
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            // 
            // cpDataGridViewTextBoxColumn
            // 
            this.cpDataGridViewTextBoxColumn.DataPropertyName = "cp";
            this.cpDataGridViewTextBoxColumn.HeaderText = "cp";
            this.cpDataGridViewTextBoxColumn.Name = "cpDataGridViewTextBoxColumn";
            // 
            // dateEmbaucheDataGridViewTextBoxColumn
            // 
            this.dateEmbaucheDataGridViewTextBoxColumn.DataPropertyName = "dateEmbauche";
            this.dateEmbaucheDataGridViewTextBoxColumn.HeaderText = "dateEmbauche";
            this.dateEmbaucheDataGridViewTextBoxColumn.Name = "dateEmbaucheDataGridViewTextBoxColumn";
            // 
            // frmLaboratoireVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 424);
            this.Controls.Add(this.dgvVisiteur);
            this.Controls.Add(this.cboLaboratoire);
            this.Controls.Add(this.lblLaboratoire);
            this.Name = "frmLaboratoireVisiteur";
            this.Text = "frmLaboratoireVisiteur";
            this.Load += new System.EventHandler(this.frmLaboratoireVisiteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLaboratoire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLaboratoire;
        private System.Windows.Forms.ComboBox cboLaboratoire;
        private System.Windows.Forms.BindingSource bsVisiteur;
        private System.Windows.Forms.DataGridView dgvVisiteur;
        private System.Windows.Forms.BindingSource bsLaboratoire;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn rue;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEmbaucheDataGridViewTextBoxColumn;
    }
}