namespace PPE3GSB
{
    partial class frmMenuGestion
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnCompteRendus = new System.Windows.Forms.Button();
            this.btnVisiteurs = new System.Windows.Forms.Button();
            this.btnPracticiens = new System.Windows.Forms.Button();
            this.btnMedicaments = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(85, 47);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(322, 29);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Gestion des comptes-rendus";
            // 
            // btnCompteRendus
            // 
            this.btnCompteRendus.Location = new System.Drawing.Point(32, 115);
            this.btnCompteRendus.Name = "btnCompteRendus";
            this.btnCompteRendus.Size = new System.Drawing.Size(97, 23);
            this.btnCompteRendus.TabIndex = 1;
            this.btnCompteRendus.Text = "Compte-rendus";
            this.btnCompteRendus.UseVisualStyleBackColor = true;
            // 
            // btnVisiteurs
            // 
            this.btnVisiteurs.Location = new System.Drawing.Point(32, 160);
            this.btnVisiteurs.Name = "btnVisiteurs";
            this.btnVisiteurs.Size = new System.Drawing.Size(97, 23);
            this.btnVisiteurs.TabIndex = 2;
            this.btnVisiteurs.Text = "Visiteurs";
            this.btnVisiteurs.UseVisualStyleBackColor = true;
            this.btnVisiteurs.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnPracticiens
            // 
            this.btnPracticiens.Location = new System.Drawing.Point(32, 211);
            this.btnPracticiens.Name = "btnPracticiens";
            this.btnPracticiens.Size = new System.Drawing.Size(97, 23);
            this.btnPracticiens.TabIndex = 3;
            this.btnPracticiens.Text = "Practiciens";
            this.btnPracticiens.UseVisualStyleBackColor = true;
            // 
            // btnMedicaments
            // 
            this.btnMedicaments.Location = new System.Drawing.Point(32, 264);
            this.btnMedicaments.Name = "btnMedicaments";
            this.btnMedicaments.Size = new System.Drawing.Size(97, 23);
            this.btnMedicaments.TabIndex = 4;
            this.btnMedicaments.Text = "Médicaments";
            this.btnMedicaments.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(32, 316);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(97, 23);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmMenuGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 361);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnMedicaments);
            this.Controls.Add(this.btnPracticiens);
            this.Controls.Add(this.btnVisiteurs);
            this.Controls.Add(this.btnCompteRendus);
            this.Controls.Add(this.lblTitre);
            this.Name = "frmMenuGestion";
            this.Text = "frmMenuGestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnCompteRendus;
        private System.Windows.Forms.Button btnVisiteurs;
        private System.Windows.Forms.Button btnPracticiens;
        private System.Windows.Forms.Button btnMedicaments;
        private System.Windows.Forms.Button btnQuitter;
    }
}