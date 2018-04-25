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
            this.bsLigneFraisForfait = new System.Windows.Forms.BindingSource(this.components);
            this.idVisiteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbJustificatifsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantValideDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateModifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEtatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFraisForfait = new System.Windows.Forms.BindingSource(this.components);
            this.dgvFraisHorsForfait = new System.Windows.Forms.DataGridView();
            this.libelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFraisHorsForfait = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.txtQteEtape = new System.Windows.Forms.NumericUpDown();
            this.txtQteNuite = new System.Windows.Forms.NumericUpDown();
            this.txtQteKm = new System.Windows.Forms.NumericUpDown();
            this.txtQteRepas = new System.Windows.Forms.NumericUpDown();
            this.txtPUniteEtape = new System.Windows.Forms.TextBox();
            this.txtPUniteNuite = new System.Windows.Forms.TextBox();
            this.txtPUniteRepas = new System.Windows.Forms.TextBox();
            this.txtPUniteKm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPTotalKm = new System.Windows.Forms.TextBox();
            this.txtPTotalRepas = new System.Windows.Forms.TextBox();
            this.txtPTotalNuite = new System.Windows.Forms.TextBox();
            this.txtPTotalEtape = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsLigneFraisForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFraisForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFraisHorsForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFraisHorsForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQteEtape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQteNuite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQteKm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQteRepas)).BeginInit();
            this.SuspendLayout();
            // 
            // butAjouter
            // 
            this.butAjouter.Location = new System.Drawing.Point(29, 355);
            this.butAjouter.Name = "butAjouter";
            this.butAjouter.Size = new System.Drawing.Size(91, 23);
            this.butAjouter.TabIndex = 2;
            this.butAjouter.Text = "Ajouter/Modifier";
            this.butAjouter.UseVisualStyleBackColor = true;
            this.butAjouter.Click += new System.EventHandler(this.butAjouter_Click);
            // 
            // butCloture
            // 
            this.butCloture.Location = new System.Drawing.Point(481, 355);
            this.butCloture.Name = "butCloture";
            this.butCloture.Size = new System.Drawing.Size(91, 23);
            this.butCloture.TabIndex = 3;
            this.butCloture.Text = "Clôturer";
            this.butCloture.UseVisualStyleBackColor = true;
            // 
            // butSuppr
            // 
            this.butSuppr.Location = new System.Drawing.Point(219, 355);
            this.butSuppr.Name = "butSuppr";
            this.butSuppr.Size = new System.Drawing.Size(91, 23);
            this.butSuppr.TabIndex = 4;
            this.butSuppr.Text = "Supprimer";
            this.butSuppr.UseVisualStyleBackColor = true;
            this.butSuppr.Click += new System.EventHandler(this.butSuppr_Click);
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
            this.dgvFraisHorsForfait.Location = new System.Drawing.Point(464, 12);
            this.dgvFraisHorsForfait.Name = "dgvFraisHorsForfait";
            this.dgvFraisHorsForfait.Size = new System.Drawing.Size(343, 177);
            this.dgvFraisHorsForfait.TabIndex = 5;
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
            // bsFraisHorsForfait
            // 
            this.bsFraisHorsForfait.DataSource = typeof(PPE3GSB.LigneFraisHorsForfait);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(701, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Actualiser";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtQteEtape
            // 
            this.txtQteEtape.Location = new System.Drawing.Point(132, 107);
            this.txtQteEtape.Name = "txtQteEtape";
            this.txtQteEtape.Size = new System.Drawing.Size(91, 20);
            this.txtQteEtape.TabIndex = 7;
            this.txtQteEtape.ValueChanged += new System.EventHandler(this.txtTotal_txtChanged);
            // 
            // txtQteNuite
            // 
            this.txtQteNuite.Location = new System.Drawing.Point(132, 154);
            this.txtQteNuite.Name = "txtQteNuite";
            this.txtQteNuite.Size = new System.Drawing.Size(91, 20);
            this.txtQteNuite.TabIndex = 8;
            this.txtQteNuite.ValueChanged += new System.EventHandler(this.txtTotal_txtChanged);
            // 
            // txtQteKm
            // 
            this.txtQteKm.Location = new System.Drawing.Point(132, 264);
            this.txtQteKm.Name = "txtQteKm";
            this.txtQteKm.Size = new System.Drawing.Size(91, 20);
            this.txtQteKm.TabIndex = 9;
            this.txtQteKm.ValueChanged += new System.EventHandler(this.txtTotal_txtChanged);
            // 
            // txtQteRepas
            // 
            this.txtQteRepas.Location = new System.Drawing.Point(132, 213);
            this.txtQteRepas.Name = "txtQteRepas";
            this.txtQteRepas.Size = new System.Drawing.Size(91, 20);
            this.txtQteRepas.TabIndex = 10;
            this.txtQteRepas.ValueChanged += new System.EventHandler(this.txtTotal_txtChanged);
            // 
            // txtPUniteEtape
            // 
            this.txtPUniteEtape.Enabled = false;
            this.txtPUniteEtape.Location = new System.Drawing.Point(231, 107);
            this.txtPUniteEtape.Name = "txtPUniteEtape";
            this.txtPUniteEtape.Size = new System.Drawing.Size(100, 20);
            this.txtPUniteEtape.TabIndex = 11;
            this.txtPUniteEtape.Text = "10";
            // 
            // txtPUniteNuite
            // 
            this.txtPUniteNuite.Enabled = false;
            this.txtPUniteNuite.Location = new System.Drawing.Point(231, 154);
            this.txtPUniteNuite.Name = "txtPUniteNuite";
            this.txtPUniteNuite.Size = new System.Drawing.Size(100, 20);
            this.txtPUniteNuite.TabIndex = 12;
            this.txtPUniteNuite.Text = "100";
            // 
            // txtPUniteRepas
            // 
            this.txtPUniteRepas.Enabled = false;
            this.txtPUniteRepas.Location = new System.Drawing.Point(231, 213);
            this.txtPUniteRepas.Name = "txtPUniteRepas";
            this.txtPUniteRepas.Size = new System.Drawing.Size(100, 20);
            this.txtPUniteRepas.TabIndex = 13;
            this.txtPUniteRepas.Text = "5";
            // 
            // txtPUniteKm
            // 
            this.txtPUniteKm.Enabled = false;
            this.txtPUniteKm.Location = new System.Drawing.Point(231, 264);
            this.txtPUniteKm.Name = "txtPUniteKm";
            this.txtPUniteKm.Size = new System.Drawing.Size(100, 20);
            this.txtPUniteKm.TabIndex = 14;
            this.txtPUniteKm.Text = "2,5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Quantité";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Prix unité";
            // 
            // txtPTotalKm
            // 
            this.txtPTotalKm.Enabled = false;
            this.txtPTotalKm.Location = new System.Drawing.Point(337, 264);
            this.txtPTotalKm.Name = "txtPTotalKm";
            this.txtPTotalKm.Size = new System.Drawing.Size(100, 20);
            this.txtPTotalKm.TabIndex = 20;
            this.txtPTotalKm.TextChanged += new System.EventHandler(this.txtTotal_txtChanged);
            // 
            // txtPTotalRepas
            // 
            this.txtPTotalRepas.Enabled = false;
            this.txtPTotalRepas.Location = new System.Drawing.Point(337, 213);
            this.txtPTotalRepas.Name = "txtPTotalRepas";
            this.txtPTotalRepas.Size = new System.Drawing.Size(100, 20);
            this.txtPTotalRepas.TabIndex = 19;
            this.txtPTotalRepas.TextChanged += new System.EventHandler(this.txtTotal_txtChanged);
            // 
            // txtPTotalNuite
            // 
            this.txtPTotalNuite.Enabled = false;
            this.txtPTotalNuite.Location = new System.Drawing.Point(337, 154);
            this.txtPTotalNuite.Name = "txtPTotalNuite";
            this.txtPTotalNuite.Size = new System.Drawing.Size(100, 20);
            this.txtPTotalNuite.TabIndex = 18;
            this.txtPTotalNuite.TextChanged += new System.EventHandler(this.txtTotal_txtChanged);
            // 
            // txtPTotalEtape
            // 
            this.txtPTotalEtape.Enabled = false;
            this.txtPTotalEtape.Location = new System.Drawing.Point(337, 107);
            this.txtPTotalEtape.Name = "txtPTotalEtape";
            this.txtPTotalEtape.Size = new System.Drawing.Size(100, 20);
            this.txtPTotalEtape.TabIndex = 17;
            this.txtPTotalEtape.TextChanged += new System.EventHandler(this.txtTotal_txtChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Prix Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Forfait Etape";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nuitée Hôtel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Repas Restaurant";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Frais Kilométrique";
            // 
            // frmRemboursementFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 390);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPTotalKm);
            this.Controls.Add(this.txtPTotalRepas);
            this.Controls.Add(this.txtPTotalNuite);
            this.Controls.Add(this.txtPTotalEtape);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPUniteKm);
            this.Controls.Add(this.txtPUniteRepas);
            this.Controls.Add(this.txtPUniteNuite);
            this.Controls.Add(this.txtPUniteEtape);
            this.Controls.Add(this.txtQteRepas);
            this.Controls.Add(this.txtQteKm);
            this.Controls.Add(this.txtQteNuite);
            this.Controls.Add(this.txtQteEtape);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvFraisHorsForfait);
            this.Controls.Add(this.butSuppr);
            this.Controls.Add(this.butCloture);
            this.Controls.Add(this.butAjouter);
            this.Name = "frmRemboursementFrais";
            this.Text = "remboursementFrais";
            this.Load += new System.EventHandler(this.frmRemboursementFrais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsLigneFraisForfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFraisForfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFraisHorsForfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFraisHorsForfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQteEtape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQteNuite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQteKm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQteRepas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butAjouter;
        private System.Windows.Forms.Button butCloture;
        private System.Windows.Forms.Button butSuppr;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown txtQteEtape;
        private System.Windows.Forms.NumericUpDown txtQteNuite;
        private System.Windows.Forms.NumericUpDown txtQteKm;
        private System.Windows.Forms.NumericUpDown txtQteRepas;
        private System.Windows.Forms.TextBox txtPUniteEtape;
        private System.Windows.Forms.TextBox txtPUniteNuite;
        private System.Windows.Forms.TextBox txtPUniteRepas;
        private System.Windows.Forms.TextBox txtPUniteKm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPTotalKm;
        private System.Windows.Forms.TextBox txtPTotalRepas;
        private System.Windows.Forms.TextBox txtPTotalNuite;
        private System.Windows.Forms.TextBox txtPTotalEtape;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        //private SIO2_GSB1_BJJDDataSet sIO2_GSB1_BJJDDataSet;
    }
}