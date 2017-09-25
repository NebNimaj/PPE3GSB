namespace PPE3GSB
{
    partial class frmRapport
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRapport));
            this.btnOK = new System.Windows.Forms.Button();
            this.txtIdent = new System.Windows.Forms.TextBox();
            this.txtMDP = new System.Windows.Forms.TextBox();
            this.lblIdent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnOK.Location = new System.Drawing.Point(407, 140);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(61, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // txtIdent
            // 
            this.txtIdent.Location = new System.Drawing.Point(285, 103);
            this.txtIdent.Name = "txtIdent";
            this.txtIdent.Size = new System.Drawing.Size(100, 20);
            this.txtIdent.TabIndex = 1;
            // 
            // txtMDP
            // 
            this.txtMDP.Location = new System.Drawing.Point(285, 142);
            this.txtMDP.Name = "txtMDP";
            this.txtMDP.Size = new System.Drawing.Size(100, 20);
            this.txtMDP.TabIndex = 2;
            // 
            // lblIdent
            // 
            this.lblIdent.AutoSize = true;
            this.lblIdent.BackColor = System.Drawing.Color.Transparent;
            this.lblIdent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdent.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblIdent.Location = new System.Drawing.Point(258, 60);
            this.lblIdent.Name = "lblIdent";
            this.lblIdent.Size = new System.Drawing.Size(163, 20);
            this.lblIdent.TabIndex = 3;
            this.lblIdent.Text = "IDENTIFIEZ VOUS";
            this.lblIdent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(687, 388);
            this.Controls.Add(this.lblIdent);
            this.Controls.Add(this.txtMDP);
            this.Controls.Add(this.txtIdent);
            this.Controls.Add(this.btnOK);
            this.Name = "frmRapport";
            this.Text = "Rapport_Visite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtIdent;
        private System.Windows.Forms.TextBox txtMDP;
        private System.Windows.Forms.Label lblIdent;
    }
}

