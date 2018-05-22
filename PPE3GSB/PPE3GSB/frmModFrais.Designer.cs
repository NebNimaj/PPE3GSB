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
            this.components = new System.ComponentModel.Container();
            this.butAccept = new System.Windows.Forms.Button();
            this.butAnnuler = new System.Windows.Forms.Button();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblLibellé = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.txtLibellé = new System.Windows.Forms.TextBox();
            this.dateTimeP = new System.Windows.Forms.DateTimePicker();
            this.bsTypeFrais = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsTypeFrais)).BeginInit();
            this.SuspendLayout();
            // 
            // butAccept
            // 
            this.butAccept.Location = new System.Drawing.Point(162, 90);
            this.butAccept.Name = "butAccept";
            this.butAccept.Size = new System.Drawing.Size(75, 23);
            this.butAccept.TabIndex = 0;
            this.butAccept.Text = "Accepter";
            this.butAccept.UseVisualStyleBackColor = true;
            this.butAccept.Click += new System.EventHandler(this.butAccept_Click);
            // 
            // butAnnuler
            // 
            this.butAnnuler.Location = new System.Drawing.Point(11, 90);
            this.butAnnuler.Name = "butAnnuler";
            this.butAnnuler.Size = new System.Drawing.Size(75, 23);
            this.butAnnuler.TabIndex = 1;
            this.butAnnuler.Text = "Annuler";
            this.butAnnuler.UseVisualStyleBackColor = true;
            this.butAnnuler.Click += new System.EventHandler(this.butAnnuler_Click);
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(9, 71);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(52, 13);
            this.lblMontant.TabIndex = 5;
            this.lblMontant.Text = "Montant :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(9, 19);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "Date :";
            // 
            // lblLibellé
            // 
            this.lblLibellé.AutoSize = true;
            this.lblLibellé.Location = new System.Drawing.Point(9, 45);
            this.lblLibellé.Name = "lblLibellé";
            this.lblLibellé.Size = new System.Drawing.Size(43, 13);
            this.lblLibellé.TabIndex = 11;
            this.lblLibellé.Text = "Libellé :";
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(117, 64);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(100, 20);
            this.txtMontant.TabIndex = 13;
            this.txtMontant.Text = "0\r\n";
            this.txtMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoLettre);
            // 
            // txtLibellé
            // 
            this.txtLibellé.Location = new System.Drawing.Point(117, 38);
            this.txtLibellé.Name = "txtLibellé";
            this.txtLibellé.Size = new System.Drawing.Size(100, 20);
            this.txtLibellé.TabIndex = 14;
            // 
            // dateTimeP
            // 
            this.dateTimeP.Location = new System.Drawing.Point(117, 12);
            this.dateTimeP.Name = "dateTimeP";
            this.dateTimeP.Size = new System.Drawing.Size(199, 20);
            this.dateTimeP.TabIndex = 19;
            this.dateTimeP.Value = new System.DateTime(2017, 10, 9, 15, 59, 11, 0);
            // 
            // bsTypeFrais
            // 
            this.bsTypeFrais.DataSource = typeof(PPE3GSB.FraisForfait);
            // 
            // frmModFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 133);
            this.Controls.Add(this.dateTimeP);
            this.Controls.Add(this.txtLibellé);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.lblLibellé);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.butAnnuler);
            this.Controls.Add(this.butAccept);
            this.Name = "frmModFrais";
            this.Text = "modFrais";
            ((System.ComponentModel.ISupportInitialize)(this.bsTypeFrais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAccept;
        private System.Windows.Forms.Button butAnnuler;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblLibellé;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.TextBox txtLibellé;
        private System.Windows.Forms.DateTimePicker dateTimeP;
        private System.Windows.Forms.BindingSource bsTypeFrais;
    }
}