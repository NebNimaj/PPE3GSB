﻿namespace PPE3GSB
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
            this.dgvligneFraisForfait = new System.Windows.Forms.DataGridView();
            this.bsFrais = new System.Windows.Forms.BindingSource(this.components);
            this.idVisiteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbJustificatifsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantValideDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateModifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEtatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mois = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fichefrais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVisiteurDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moisDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFraisForfaitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fichefraisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fraisForfaitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvligneFraisForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFrais)).BeginInit();
            this.SuspendLayout();
            // 
            // butAjouter
            // 
            this.butAjouter.Location = new System.Drawing.Point(205, 143);
            this.butAjouter.Name = "butAjouter";
            this.butAjouter.Size = new System.Drawing.Size(75, 23);
            this.butAjouter.TabIndex = 2;
            this.butAjouter.Text = "Ajouter";
            this.butAjouter.UseVisualStyleBackColor = true;
            this.butAjouter.Click += new System.EventHandler(this.butAjouter_Click);
            // 
            // butCloture
            // 
            this.butCloture.Location = new System.Drawing.Point(205, 257);
            this.butCloture.Name = "butCloture";
            this.butCloture.Size = new System.Drawing.Size(75, 23);
            this.butCloture.TabIndex = 3;
            this.butCloture.Text = "Clôturer";
            this.butCloture.UseVisualStyleBackColor = true;
            // 
            // butSuppr
            // 
            this.butSuppr.Location = new System.Drawing.Point(205, 199);
            this.butSuppr.Name = "butSuppr";
            this.butSuppr.Size = new System.Drawing.Size(75, 23);
            this.butSuppr.TabIndex = 4;
            this.butSuppr.Text = "Supprimer";
            this.butSuppr.UseVisualStyleBackColor = true;
            this.butSuppr.Click += new System.EventHandler(this.butSuppr_Click);
            // 
            // dgvligneFraisForfait
            // 
            this.dgvligneFraisForfait.AutoGenerateColumns = false;
            this.dgvligneFraisForfait.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvligneFraisForfait.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mois,
            this.libelle,
            this.montant,
            this.fichefrais,
            this.idVisiteurDataGridViewTextBoxColumn1,
            this.moisDataGridViewTextBoxColumn1,
            this.idFraisForfaitDataGridViewTextBoxColumn,
            this.quantiteDataGridViewTextBoxColumn,
            this.fichefraisDataGridViewTextBoxColumn,
            this.fraisForfaitDataGridViewTextBoxColumn});
            this.dgvligneFraisForfait.DataSource = this.bsFrais;
            this.dgvligneFraisForfait.Location = new System.Drawing.Point(313, 56);
            this.dgvligneFraisForfait.Name = "dgvligneFraisForfait";
            this.dgvligneFraisForfait.Size = new System.Drawing.Size(320, 315);
            this.dgvligneFraisForfait.TabIndex = 4;
            // 
            // bsFrais
            // 
            this.bsFrais.DataSource = typeof(PPE3GSB.LigneFraisForfait);
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
            // mois
            // 
            this.mois.DataPropertyName = "mois";
            this.mois.HeaderText = "mois";
            this.mois.Name = "mois";
            // 
            // libelle
            // 
            this.libelle.DataPropertyName = "libelle";
            this.libelle.HeaderText = "libelle";
            this.libelle.Name = "libelle";
            // 
            // montant
            // 
            this.montant.DataPropertyName = "montant";
            this.montant.HeaderText = "montant";
            this.montant.Name = "montant";
            // 
            // fichefrais
            // 
            this.fichefrais.DataPropertyName = "fichefrais";
            this.fichefrais.HeaderText = "fichefrais";
            this.fichefrais.Name = "fichefrais";
            // 
            // idVisiteurDataGridViewTextBoxColumn1
            // 
            this.idVisiteurDataGridViewTextBoxColumn1.DataPropertyName = "idVisiteur";
            this.idVisiteurDataGridViewTextBoxColumn1.HeaderText = "idVisiteur";
            this.idVisiteurDataGridViewTextBoxColumn1.Name = "idVisiteurDataGridViewTextBoxColumn1";
            // 
            // moisDataGridViewTextBoxColumn1
            // 
            this.moisDataGridViewTextBoxColumn1.DataPropertyName = "mois";
            this.moisDataGridViewTextBoxColumn1.HeaderText = "mois";
            this.moisDataGridViewTextBoxColumn1.Name = "moisDataGridViewTextBoxColumn1";
            // 
            // idFraisForfaitDataGridViewTextBoxColumn
            // 
            this.idFraisForfaitDataGridViewTextBoxColumn.DataPropertyName = "idFraisForfait";
            this.idFraisForfaitDataGridViewTextBoxColumn.HeaderText = "idFraisForfait";
            this.idFraisForfaitDataGridViewTextBoxColumn.Name = "idFraisForfaitDataGridViewTextBoxColumn";
            // 
            // quantiteDataGridViewTextBoxColumn
            // 
            this.quantiteDataGridViewTextBoxColumn.DataPropertyName = "quantite";
            this.quantiteDataGridViewTextBoxColumn.HeaderText = "quantite";
            this.quantiteDataGridViewTextBoxColumn.Name = "quantiteDataGridViewTextBoxColumn";
            // 
            // fichefraisDataGridViewTextBoxColumn
            // 
            this.fichefraisDataGridViewTextBoxColumn.DataPropertyName = "fichefrais";
            this.fichefraisDataGridViewTextBoxColumn.HeaderText = "fichefrais";
            this.fichefraisDataGridViewTextBoxColumn.Name = "fichefraisDataGridViewTextBoxColumn";
            // 
            // fraisForfaitDataGridViewTextBoxColumn
            // 
            this.fraisForfaitDataGridViewTextBoxColumn.DataPropertyName = "FraisForfait";
            this.fraisForfaitDataGridViewTextBoxColumn.HeaderText = "FraisForfait";
            this.fraisForfaitDataGridViewTextBoxColumn.Name = "fraisForfaitDataGridViewTextBoxColumn";
            // 
            // frmRemboursementFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 424);
            this.Controls.Add(this.dgvligneFraisForfait);
            this.Controls.Add(this.butSuppr);
            this.Controls.Add(this.butCloture);
            this.Controls.Add(this.butAjouter);
            this.Name = "frmRemboursementFrais";
            this.Text = "remboursementFrais";
            this.Load += new System.EventHandler(this.frmRemboursementFrais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvligneFraisForfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFrais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button butAjouter;
        private System.Windows.Forms.Button butCloture;
        private System.Windows.Forms.Button butSuppr;
        private System.Windows.Forms.DataGridView dgvligneFraisForfait;
        private System.Windows.Forms.BindingSource bsFrais;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVisiteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbJustificatifsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantValideDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateModifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEtatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mois;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn montant;
        private System.Windows.Forms.DataGridViewTextBoxColumn fichefrais;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVisiteurDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn moisDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFraisForfaitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fichefraisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fraisForfaitDataGridViewTextBoxColumn;
        //private SIO2_GSB1_BJJDDataSet sIO2_GSB1_BJJDDataSet;
    }
}