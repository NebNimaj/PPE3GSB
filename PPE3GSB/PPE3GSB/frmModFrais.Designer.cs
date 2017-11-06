namespace PPE3GSB
{
    partial class frmModFrais
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
            this.butAccept = new System.Windows.Forms.Button();
            this.butAnnuler = new System.Windows.Forms.Button();
            this.txtQuantité = new System.Windows.Forms.TextBox();
            this.txtMontantUnitaire = new System.Windows.Forms.TextBox();
            this.cboTypeForfait = new System.Windows.Forms.ComboBox();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblTypeForfait = new System.Windows.Forms.Label();
            this.lblQuantité = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMontantUnitaire = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblLibellé = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.txtLibellé = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblFrais = new System.Windows.Forms.Label();
            this.cboTypeFrais = new System.Windows.Forms.ComboBox();
            this.dateTimeP = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // butAccept
            // 
            this.butAccept.Location = new System.Drawing.Point(180, 172);
            this.butAccept.Name = "butAccept";
            this.butAccept.Size = new System.Drawing.Size(75, 23);
            this.butAccept.TabIndex = 0;
            this.butAccept.Text = "Accepter";
            this.butAccept.UseVisualStyleBackColor = true;
            this.butAccept.Click += new System.EventHandler(this.butAccept_Click);
            // 
            // butAnnuler
            // 
            this.butAnnuler.Location = new System.Drawing.Point(29, 172);
            this.butAnnuler.Name = "butAnnuler";
            this.butAnnuler.Size = new System.Drawing.Size(75, 23);
            this.butAnnuler.TabIndex = 1;
            this.butAnnuler.Text = "Annuler";
            this.butAnnuler.UseVisualStyleBackColor = true;
            this.butAnnuler.Click += new System.EventHandler(this.butAnnuler_Click);
            // 
            // txtQuantité
            // 
            this.txtQuantité.Location = new System.Drawing.Point(134, 74);
            this.txtQuantité.Name = "txtQuantité";
            this.txtQuantité.Size = new System.Drawing.Size(100, 20);
            this.txtQuantité.TabIndex = 2;
            this.txtQuantité.Text = "0";
            this.txtQuantité.Visible = false;
            this.txtQuantité.TextChanged += new System.EventHandler(this.txtForfaitisés_TextChanged);
            this.txtQuantité.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoLettre_NoVirgule);
            // 
            // txtMontantUnitaire
            // 
            this.txtMontantUnitaire.Location = new System.Drawing.Point(134, 100);
            this.txtMontantUnitaire.Name = "txtMontantUnitaire";
            this.txtMontantUnitaire.Size = new System.Drawing.Size(100, 20);
            this.txtMontantUnitaire.TabIndex = 3;
            this.txtMontantUnitaire.Text = "0";
            this.txtMontantUnitaire.Visible = false;
            this.txtMontantUnitaire.TextChanged += new System.EventHandler(this.txtForfaitisés_TextChanged);
            this.txtMontantUnitaire.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoLettre);
            // 
            // cboTypeForfait
            // 
            this.cboTypeForfait.FormattingEnabled = true;
            this.cboTypeForfait.Items.AddRange(new object[] {
            "Forfait étape",
            "Frais kilométrique",
            "Nuitée hôtel",
            "Repas restaurant"});
            this.cboTypeForfait.Location = new System.Drawing.Point(134, 47);
            this.cboTypeForfait.Name = "cboTypeForfait";
            this.cboTypeForfait.Size = new System.Drawing.Size(199, 21);
            this.cboTypeForfait.TabIndex = 4;
            this.cboTypeForfait.Visible = false;
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(26, 294);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(52, 13);
            this.lblMontant.TabIndex = 5;
            this.lblMontant.Text = "Montant :";
            this.lblMontant.Visible = false;
            // 
            // lblTypeForfait
            // 
            this.lblTypeForfait.AutoSize = true;
            this.lblTypeForfait.Location = new System.Drawing.Point(26, 55);
            this.lblTypeForfait.Name = "lblTypeForfait";
            this.lblTypeForfait.Size = new System.Drawing.Size(86, 13);
            this.lblTypeForfait.TabIndex = 6;
            this.lblTypeForfait.Text = "Type de forfaits :";
            this.lblTypeForfait.Visible = false;
            // 
            // lblQuantité
            // 
            this.lblQuantité.AutoSize = true;
            this.lblQuantité.Location = new System.Drawing.Point(26, 81);
            this.lblQuantité.Name = "lblQuantité";
            this.lblQuantité.Size = new System.Drawing.Size(53, 13);
            this.lblQuantité.TabIndex = 7;
            this.lblQuantité.Text = "Quantité :";
            this.lblQuantité.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(26, 133);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total :";
            this.lblTotal.Visible = false;
            // 
            // lblMontantUnitaire
            // 
            this.lblMontantUnitaire.AutoSize = true;
            this.lblMontantUnitaire.Location = new System.Drawing.Point(26, 107);
            this.lblMontantUnitaire.Name = "lblMontantUnitaire";
            this.lblMontantUnitaire.Size = new System.Drawing.Size(89, 13);
            this.lblMontantUnitaire.TabIndex = 9;
            this.lblMontantUnitaire.Text = "Montant unitaire :";
            this.lblMontantUnitaire.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(26, 242);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "Date :";
            this.lblDate.Visible = false;
            // 
            // lblLibellé
            // 
            this.lblLibellé.AutoSize = true;
            this.lblLibellé.Location = new System.Drawing.Point(26, 268);
            this.lblLibellé.Name = "lblLibellé";
            this.lblLibellé.Size = new System.Drawing.Size(43, 13);
            this.lblLibellé.TabIndex = 11;
            this.lblLibellé.Text = "Libellé :";
            this.lblLibellé.Visible = false;
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(134, 287);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(100, 20);
            this.txtMontant.TabIndex = 13;
            this.txtMontant.Text = "0\r\n";
            this.txtMontant.Visible = false;
            this.txtMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoLettre);
            // 
            // txtLibellé
            // 
            this.txtLibellé.Location = new System.Drawing.Point(134, 261);
            this.txtLibellé.Name = "txtLibellé";
            this.txtLibellé.Size = new System.Drawing.Size(100, 20);
            this.txtLibellé.TabIndex = 14;
            this.txtLibellé.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(134, 126);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 16;
            this.txtTotal.Text = "0";
            this.txtTotal.Visible = false;
            // 
            // lblFrais
            // 
            this.lblFrais.AutoSize = true;
            this.lblFrais.Location = new System.Drawing.Point(26, 28);
            this.lblFrais.Name = "lblFrais";
            this.lblFrais.Size = new System.Drawing.Size(74, 13);
            this.lblFrais.TabIndex = 17;
            this.lblFrais.Text = "Type de frais :";
            // 
            // cboTypeFrais
            // 
            this.cboTypeFrais.FormattingEnabled = true;
            this.cboTypeFrais.Items.AddRange(new object[] {
            "Forfaitisés",
            "Hors forfait"});
            this.cboTypeFrais.Location = new System.Drawing.Point(134, 20);
            this.cboTypeFrais.Name = "cboTypeFrais";
            this.cboTypeFrais.Size = new System.Drawing.Size(199, 21);
            this.cboTypeFrais.TabIndex = 18;
            this.cboTypeFrais.SelectedIndexChanged += new System.EventHandler(this.cboTypeFrais_SelectedIndexChanged);
            // 
            // dateTimeP
            // 
            this.dateTimeP.Location = new System.Drawing.Point(134, 235);
            this.dateTimeP.Name = "dateTimeP";
            this.dateTimeP.Size = new System.Drawing.Size(199, 20);
            this.dateTimeP.TabIndex = 19;
            this.dateTimeP.Value = new System.DateTime(2017, 10, 9, 15, 59, 11, 0);
            this.dateTimeP.Visible = false;
            // 
            // frmModFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 410);
            this.Controls.Add(this.dateTimeP);
            this.Controls.Add(this.cboTypeFrais);
            this.Controls.Add(this.lblFrais);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtLibellé);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.lblLibellé);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblMontantUnitaire);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblQuantité);
            this.Controls.Add(this.lblTypeForfait);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.cboTypeForfait);
            this.Controls.Add(this.txtMontantUnitaire);
            this.Controls.Add(this.txtQuantité);
            this.Controls.Add(this.butAnnuler);
            this.Controls.Add(this.butAccept);
            this.Name = "frmModFrais";
            this.Text = "modFrais";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAccept;
        private System.Windows.Forms.Button butAnnuler;
        private System.Windows.Forms.TextBox txtQuantité;
        private System.Windows.Forms.TextBox txtMontantUnitaire;
        private System.Windows.Forms.ComboBox cboTypeForfait;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblTypeForfait;
        private System.Windows.Forms.Label lblQuantité;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMontantUnitaire;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblLibellé;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.TextBox txtLibellé;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblFrais;
        private System.Windows.Forms.ComboBox cboTypeFrais;
        private System.Windows.Forms.DateTimePicker dateTimeP;
    }
}