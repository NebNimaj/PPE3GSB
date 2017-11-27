namespace PPE3GSB
{
    partial class frmRemboursementFrais
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
            this.butAjouter = new System.Windows.Forms.Button();
            this.butCloture = new System.Windows.Forms.Button();
            this.butSuppr = new System.Windows.Forms.Button();
            this.dgvLigneFraisForfait = new System.Windows.Forms.DataGridView();
            this.bsLigneFraisForfait = new System.Windows.Forms.BindingSource(this.components);
            this.idVisiteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbJustificatifsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantValideDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateModifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEtatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFraisForfait = new System.Windows.Forms.BindingSource(this.components);
            this.dgvFraisHorsForfait = new System.Windows.Forms.DataGridView();
            this.bsFraisHorsForfait = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.idFraisForfait = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLigneFraisForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLigneFraisForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFraisForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFraisHorsForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFraisHorsForfait)).BeginInit();
            this.SuspendLayout();
            // 
            // butAjouter
            // 
            this.butAjouter.Location = new System.Drawing.Point(12, 209);
            this.butAjouter.Name = "butAjouter";
            this.butAjouter.Size = new System.Drawing.Size(91, 23);
            this.butAjouter.TabIndex = 2;
            this.butAjouter.Text = "Ajouter/Modifier";
            this.butAjouter.UseVisualStyleBackColor = true;
            this.butAjouter.Click += new System.EventHandler(this.butAjouter_Click);
            // 
            // butCloture
            // 
            this.butCloture.Location = new System.Drawing.Point(314, 209);
            this.butCloture.Name = "butCloture";
            this.butCloture.Size = new System.Drawing.Size(91, 23);
            this.butCloture.TabIndex = 3;
            this.butCloture.Text = "Clôturer";
            this.butCloture.UseVisualStyleBackColor = true;
            // 
            // butSuppr
            // 
            this.butSuppr.Location = new System.Drawing.Point(162, 209);
            this.butSuppr.Name = "butSuppr";
            this.butSuppr.Size = new System.Drawing.Size(91, 23);
            this.butSuppr.TabIndex = 4;
            this.butSuppr.Text = "Supprimer";
            this.butSuppr.UseVisualStyleBackColor = true;
            this.butSuppr.Click += new System.EventHandler(this.butSuppr_Click);
            // 
            // dgvLigneFraisForfait
            // 
            this.dgvLigneFraisForfait.AutoGenerateColumns = false;
            this.dgvLigneFraisForfait.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLigneFraisForfait.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFraisForfait,
            this.quantite});
            this.dgvLigneFraisForfait.DataSource = this.bsLigneFraisForfait;
            this.dgvLigneFraisForfait.Location = new System.Drawing.Point(12, 12);
            this.dgvLigneFraisForfait.Name = "dgvLigneFraisForfait";
            this.dgvLigneFraisForfait.Size = new System.Drawing.Size(243, 177);
            this.dgvLigneFraisForfait.TabIndex = 4;
            // 
            // bsLigneFraisForfait
            // 
            this.bsLigneFraisForfait.DataSource = typeof(PPE3GSB.LigneFraisForfait);
            // 
            // idVisiteurDataGridViewTextBoxColumn
            // 
            this.idVisiteurDataGridViewTextBoxColumn.DataPropertyName = "idVisiteur";
            this.idVisiteurDataGridViewTextBoxColumn.HeaderText = "idVisiteur";
            this.idVisiteurDataGridViewTextBoxColumn.Name = "idVisiteurDataGridViewTextBoxColumn";
            // 
            // moisDataGridViewTextBoxColumn
            // 
            this.moisDataGridViewTextBoxColumn.DataPropertyName = "mois";
            this.moisDataGridViewTextBoxColumn.HeaderText = "mois";
            this.moisDataGridViewTextBoxColumn.Name = "moisDataGridViewTextBoxColumn";
            // 
            // nbJustificatifsDataGridViewTextBoxColumn
            // 
            this.nbJustificatifsDataGridViewTextBoxColumn.DataPropertyName = "nbJustificatifs";
            this.nbJustificatifsDataGridViewTextBoxColumn.HeaderText = "nbJustificatifs";
            this.nbJustificatifsDataGridViewTextBoxColumn.Name = "nbJustificatifsDataGridViewTextBoxColumn";
            // 
            // montantValideDataGridViewTextBoxColumn
            // 
            this.montantValideDataGridViewTextBoxColumn.DataPropertyName = "montantValide";
            this.montantValideDataGridViewTextBoxColumn.HeaderText = "montantValide";
            this.montantValideDataGridViewTextBoxColumn.Name = "montantValideDataGridViewTextBoxColumn";
            // 
            // dateModifDataGridViewTextBoxColumn
            // 
            this.dateModifDataGridViewTextBoxColumn.Name = "dateModifDataGridViewTextBoxColumn";
            // 
            // idEtatDataGridViewTextBoxColumn
            // 
            this.idEtatDataGridViewTextBoxColumn.Name = "idEtatDataGridViewTextBoxColumn";
            // 
            // bsFraisForfait
            // 
            this.bsFraisForfait.DataSource = typeof(PPE3GSB.FraisForfait);
            // 
            // dgvFraisHorsForfait
            // 
            this.dgvFraisHorsForfait.AutoGenerateColumns = false;
            this.dgvFraisHorsForfait.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFraisHorsForfait.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.libelleDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.montantDataGridViewTextBoxColumn});
            this.dgvFraisHorsForfait.DataSource = this.bsFraisHorsForfait;
            this.dgvFraisHorsForfait.Location = new System.Drawing.Point(261, 12);
            this.dgvFraisHorsForfait.Name = "dgvFraisHorsForfait";
            this.dgvFraisHorsForfait.Size = new System.Drawing.Size(343, 177);
            this.dgvFraisHorsForfait.TabIndex = 5;
            // 
            // bsFraisHorsForfait
            // 
            this.bsFraisHorsForfait.DataSource = typeof(PPE3GSB.LigneFraisHorsForfait);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Actualiser";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idFraisForfait
            // 
            this.idFraisForfait.DataPropertyName = "idFraisForfait";
            this.idFraisForfait.HeaderText = "Type Forfait";
            this.idFraisForfait.Name = "idFraisForfait";
            // 
            // quantite
            // 
            this.quantite.DataPropertyName = "quantite";
            this.quantite.HeaderText = "Quantité";
            this.quantite.Name = "quantite";
            // 
            // libelleDataGridViewTextBoxColumn
            // 
            this.libelleDataGridViewTextBoxColumn.DataPropertyName = "libelle";
            this.libelleDataGridViewTextBoxColumn.HeaderText = "Libellé";
            this.libelleDataGridViewTextBoxColumn.Name = "libelleDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // montantDataGridViewTextBoxColumn
            // 
            this.montantDataGridViewTextBoxColumn.DataPropertyName = "montant";
            this.montantDataGridViewTextBoxColumn.HeaderText = "Montant";
            this.montantDataGridViewTextBoxColumn.Name = "montantDataGridViewTextBoxColumn";
            // 
            // frmRemboursementFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 244);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvFraisHorsForfait);
            this.Controls.Add(this.dgvLigneFraisForfait);
            this.Controls.Add(this.butSuppr);
            this.Controls.Add(this.butCloture);
            this.Controls.Add(this.butAjouter);
            this.Name = "frmRemboursementFrais";
            this.Text = "remboursementFrais";
            this.Load += new System.EventHandler(this.frmRemboursementFrais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLigneFraisForfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLigneFraisForfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFraisForfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFraisHorsForfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFraisHorsForfait)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button butAjouter;
        private System.Windows.Forms.Button butCloture;
        private System.Windows.Forms.Button butSuppr;
        private System.Windows.Forms.DataGridView dgvLigneFraisForfait;
        private System.Windows.Forms.BindingSource bsLigneFraisForfait;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVisiteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbJustificatifsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantValideDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateModifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEtatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn montant;
        private System.Windows.Forms.BindingSource bsFraisForfait;
        private System.Windows.Forms.DataGridView dgvFraisHorsForfait;
        private System.Windows.Forms.BindingSource bsFraisHorsForfait;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFraisForfait;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantDataGridViewTextBoxColumn;
        //private SIO2_GSB1_BJJDDataSet sIO2_GSB1_BJJDDataSet;
    }
}