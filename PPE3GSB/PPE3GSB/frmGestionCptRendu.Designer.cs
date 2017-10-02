namespace PPE3GSB
{
    partial class frmGestionCptRendu
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
            this.btnCptRendu = new System.Windows.Forms.Button();
            this.btnVisiteur = new System.Windows.Forms.Button();
            this.btnPracticiens = new System.Windows.Forms.Button();
            this.btnMedicament = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblCptRendus = new System.Windows.Forms.Label();
            this.lblVisiteur = new System.Windows.Forms.Label();
            this.lblPracticiens = new System.Windows.Forms.Label();
            this.lblMedicament = new System.Windows.Forms.Label();
            this.lblQuitter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCptRendu
            // 
            this.btnCptRendu.Location = new System.Drawing.Point(342, 176);
            this.btnCptRendu.Name = "btnCptRendu";
            this.btnCptRendu.Size = new System.Drawing.Size(20, 23);
            this.btnCptRendu.TabIndex = 0;
            this.btnCptRendu.UseVisualStyleBackColor = true;
            this.btnCptRendu.Click += new System.EventHandler(this.btnCptRendu_Click);
            // 
            // btnVisiteur
            // 
            this.btnVisiteur.Location = new System.Drawing.Point(342, 205);
            this.btnVisiteur.Name = "btnVisiteur";
            this.btnVisiteur.Size = new System.Drawing.Size(20, 23);
            this.btnVisiteur.TabIndex = 1;
            this.btnVisiteur.UseVisualStyleBackColor = true;
            // 
            // btnPracticiens
            // 
            this.btnPracticiens.Location = new System.Drawing.Point(342, 234);
            this.btnPracticiens.Name = "btnPracticiens";
            this.btnPracticiens.Size = new System.Drawing.Size(20, 23);
            this.btnPracticiens.TabIndex = 2;
            this.btnPracticiens.UseVisualStyleBackColor = true;
            // 
            // btnMedicament
            // 
            this.btnMedicament.Location = new System.Drawing.Point(342, 263);
            this.btnMedicament.Name = "btnMedicament";
            this.btnMedicament.Size = new System.Drawing.Size(20, 23);
            this.btnMedicament.TabIndex = 3;
            this.btnMedicament.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(342, 292);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(20, 23);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // lblCptRendus
            // 
            this.lblCptRendus.AutoSize = true;
            this.lblCptRendus.BackColor = System.Drawing.Color.Transparent;
            this.lblCptRendus.Location = new System.Drawing.Point(382, 181);
            this.lblCptRendus.Name = "lblCptRendus";
            this.lblCptRendus.Size = new System.Drawing.Size(88, 13);
            this.lblCptRendus.TabIndex = 5;
            this.lblCptRendus.Text = "Comptes-Rendus";
            // 
            // lblVisiteur
            // 
            this.lblVisiteur.AutoSize = true;
            this.lblVisiteur.BackColor = System.Drawing.Color.Transparent;
            this.lblVisiteur.Location = new System.Drawing.Point(382, 210);
            this.lblVisiteur.Name = "lblVisiteur";
            this.lblVisiteur.Size = new System.Drawing.Size(41, 13);
            this.lblVisiteur.TabIndex = 6;
            this.lblVisiteur.Text = "Visiteur";
            // 
            // lblPracticiens
            // 
            this.lblPracticiens.AutoSize = true;
            this.lblPracticiens.BackColor = System.Drawing.Color.Transparent;
            this.lblPracticiens.Location = new System.Drawing.Point(382, 239);
            this.lblPracticiens.Name = "lblPracticiens";
            this.lblPracticiens.Size = new System.Drawing.Size(59, 13);
            this.lblPracticiens.TabIndex = 7;
            this.lblPracticiens.Text = "Practiciens";
            // 
            // lblMedicament
            // 
            this.lblMedicament.AutoSize = true;
            this.lblMedicament.BackColor = System.Drawing.Color.Transparent;
            this.lblMedicament.Location = new System.Drawing.Point(382, 268);
            this.lblMedicament.Name = "lblMedicament";
            this.lblMedicament.Size = new System.Drawing.Size(65, 13);
            this.lblMedicament.TabIndex = 8;
            this.lblMedicament.Text = "Medicament";
            // 
            // lblQuitter
            // 
            this.lblQuitter.AutoSize = true;
            this.lblQuitter.BackColor = System.Drawing.Color.Transparent;
            this.lblQuitter.Location = new System.Drawing.Point(382, 297);
            this.lblQuitter.Name = "lblQuitter";
            this.lblQuitter.Size = new System.Drawing.Size(38, 13);
            this.lblQuitter.TabIndex = 9;
            this.lblQuitter.Text = "Quitter";
            // 
            // frmGestionCptRendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(709, 396);
            this.Controls.Add(this.lblQuitter);
            this.Controls.Add(this.lblMedicament);
            this.Controls.Add(this.lblPracticiens);
            this.Controls.Add(this.lblVisiteur);
            this.Controls.Add(this.lblCptRendus);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnMedicament);
            this.Controls.Add(this.btnPracticiens);
            this.Controls.Add(this.btnVisiteur);
            this.Controls.Add(this.btnCptRendu);
            this.Name = "frmGestionCptRendu";
            this.Text = "Gestion des comptes rendus";
            this.Controls.SetChildIndex(this.btnCptRendu, 0);
            this.Controls.SetChildIndex(this.btnVisiteur, 0);
            this.Controls.SetChildIndex(this.btnPracticiens, 0);
            this.Controls.SetChildIndex(this.btnMedicament, 0);
            this.Controls.SetChildIndex(this.btnQuitter, 0);
            this.Controls.SetChildIndex(this.lblCptRendus, 0);
            this.Controls.SetChildIndex(this.lblVisiteur, 0);
            this.Controls.SetChildIndex(this.lblPracticiens, 0);
            this.Controls.SetChildIndex(this.lblMedicament, 0);
            this.Controls.SetChildIndex(this.lblQuitter, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCptRendu;
        private System.Windows.Forms.Button btnVisiteur;
        private System.Windows.Forms.Button btnPracticiens;
        private System.Windows.Forms.Button btnMedicament;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblCptRendus;
        private System.Windows.Forms.Label lblVisiteur;
        private System.Windows.Forms.Label lblPracticiens;
        private System.Windows.Forms.Label lblMedicament;
        private System.Windows.Forms.Label lblQuitter;
    }
}