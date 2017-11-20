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
            this.dgvligneFraisForfait = new System.Windows.Forms.DataGridView();
            this.bsFrais = new System.Windows.Forms.BindingSource(this.components);
            //this.sIO2_GSB1_BJJDDataSet = new PPE3GSB.SIO2_GSB1_BJJDDataSet();
            this.idVisiteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbJustificatifsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantValideDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateModifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEtatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ligneFraisForfaitDataGridView)).BeginInit();
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
            this.idVisiteur,
            this.idFraisForfait,
            this.quantite});
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
            // sIO2_GSB1_BJJDDataSet
            // 
            //this.sIO2_GSB1_BJJDDataSet.DataSetName = "SIO2_GSB1_BJJDDataSet";
            //this.sIO2_GSB1_BJJDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
        //private SIO2_GSB1_BJJDDataSet sIO2_GSB1_BJJDDataSet;
    }
}