﻿namespace PPE3GSB
{
    partial class frmContainer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionRapportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionFraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Location = new System.Drawing.Point(498, 0);
            this.lblTitre.Size = new System.Drawing.Size(58, 13);
            this.lblTitre.Text = "Bienvenue";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionRapportsToolStripMenuItem,
            this.gestionFraisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(636, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionRapportsToolStripMenuItem
            // 
            this.gestionRapportsToolStripMenuItem.Name = "gestionRapportsToolStripMenuItem";
            this.gestionRapportsToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.gestionRapportsToolStripMenuItem.Text = "Gestion Rapports";
            this.gestionRapportsToolStripMenuItem.Click += new System.EventHandler(this.gestionRapportsToolStripMenuItem_Click);
            // 
            // gestionFraisToolStripMenuItem
            // 
            this.gestionFraisToolStripMenuItem.Name = "gestionFraisToolStripMenuItem";
            this.gestionFraisToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.gestionFraisToolStripMenuItem.Text = "Gestion Frais";
            // 
            // frmContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 382);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmContainer";
            this.Text = "frmContainer";
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionRapportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionFraisToolStripMenuItem;
    }
}