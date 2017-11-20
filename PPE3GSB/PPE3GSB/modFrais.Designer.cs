namespace PPE3GSB
{
    partial class modFrais
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
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblFrais = new System.Windows.Forms.Label();
            this.cboTypeFrais = new System.Windows.Forms.ComboBox();
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
            // 
            // butAnnuler
            // 
            this.butAnnuler.Location = new System.Drawing.Point(29, 172);
            this.butAnnuler.Name = "butAnnuler";
            this.butAnnuler.Size = new System.Drawing.Size(75, 23);
            this.butAnnuler.TabIndex = 1;
            this.butAnnuler.Text = "Annuler";
            this.butAnnuler.UseVisualStyleBackColor = true;
            // 
            // txtQuantité
            // 
            this.txtQuantité.Location = new System.Drawing.Point(155, 74);
            this.txtQuantité.Name = "txtQuantité";
            this.txtQuantité.Size = new System.Drawing.Size(100, 20);
            this.txtQuantité.TabIndex = 2;
            // 
            // txtMontantUnitaire
            // 
            this.txtMontantUnitaire.Location = new System.Drawing.Point(155, 100);
            this.txtMontantUnitaire.Name = "txtMontantUnitaire";
            this.txtMontantUnitaire.Size = new System.Drawing.Size(100, 20);
            this.txtMontantUnitaire.TabIndex = 3;
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
            this.cboTypeForfait.Size = new System.Drawing.Size(121, 21);
            this.cboTypeForfait.TabIndex = 4;
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(26, 294);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(52, 13);
            this.lblMontant.TabIndex = 5;
            this.lblMontant.Text = "Montant :";
            // 
            // lblTypeForfait
            // 
            this.lblTypeForfait.AutoSize = true;
            this.lblTypeForfait.Location = new System.Drawing.Point(26, 55);
            this.lblTypeForfait.Name = "lblTypeForfait";
            this.lblTypeForfait.Size = new System.Drawing.Size(86, 13);
            this.lblTypeForfait.TabIndex = 6;
            this.lblTypeForfait.Text = "Type de forfaits :";
            // 
            // lblQuantité
            // 
            this.lblQuantité.AutoSize = true;
            this.lblQuantité.Location = new System.Drawing.Point(26, 81);
            this.lblQuantité.Name = "lblQuantité";
            this.lblQuantité.Size = new System.Drawing.Size(53, 13);
            this.lblQuantité.TabIndex = 7;
            this.lblQuantité.Text = "Quantité :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(26, 133);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total :";
            // 
            // lblMontantUnitaire
            // 
            this.lblMontantUnitaire.AutoSize = true;
            this.lblMontantUnitaire.Location = new System.Drawing.Point(26, 107);
            this.lblMontantUnitaire.Name = "lblMontantUnitaire";
            this.lblMontantUnitaire.Size = new System.Drawing.Size(89, 13);
            this.lblMontantUnitaire.TabIndex = 9;
            this.lblMontantUnitaire.Text = "Montant unitaire :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(26, 242);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "Date :";
            // 
            // lblLibellé
            // 
            this.lblLibellé.AutoSize = true;
            this.lblLibellé.Location = new System.Drawing.Point(26, 268);
            this.lblLibellé.Name = "lblLibellé";
            this.lblLibellé.Size = new System.Drawing.Size(43, 13);
            this.lblLibellé.TabIndex = 11;
            this.lblLibellé.Text = "Libellé :";
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(155, 287);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(100, 20);
            this.txtMontant.TabIndex = 13;
            // 
            // txtLibellé
            // 
            this.txtLibellé.Location = new System.Drawing.Point(155, 261);
            this.txtLibellé.Name = "txtLibellé";
            this.txtLibellé.Size = new System.Drawing.Size(100, 20);
            this.txtLibellé.TabIndex = 14;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(155, 235);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 15;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(155, 126);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 16;
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
            this.cboTypeFrais.Size = new System.Drawing.Size(121, 21);
            this.cboTypeFrais.TabIndex = 18;
            this.cboTypeFrais.SelectedIndexChanged += new System.EventHandler(this.cboTypeFrais_SelectedIndexChanged);
            // 
            // modFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 410);
            this.Controls.Add(this.cboTypeFrais);
            this.Controls.Add(this.lblFrais);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDate);
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
            this.Name = "modFrais";
            this.Text = "modFrais";
            this.Load += new System.EventHandler(this.modFrais_Load);
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
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblFrais;
        private System.Windows.Forms.ComboBox cboTypeFrais;
    }
}