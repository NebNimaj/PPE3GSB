namespace PPE3GSB
{
    partial class frmCptRendu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCptRendu));
            this.lblNumRap = new System.Windows.Forms.Label();
            this.lblPractic = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOffre = new System.Windows.Forms.Label();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.bsPracticien = new System.Windows.Forms.BindingSource(this.components);
            this.dgvEchantillons = new System.Windows.Forms.DataGridView();
            this.txtNumRapport = new System.Windows.Forms.TextBox();
            this.txtDateRapport = new System.Windows.Forms.TextBox();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.cboPracticiens = new System.Windows.Forms.ComboBox();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.bsOffreEchantillon = new System.Windows.Forms.BindingSource(this.components);
            this.bsRapport = new System.Windows.Forms.BindingSource(this.components);
            this.txtBilan = new System.Windows.Forms.TextBox();
            this.bnRapport = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.bsPracticien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEchantillons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOffreEchantillon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnRapport)).BeginInit();
            this.bnRapport.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumRap
            // 
            this.lblNumRap.AutoSize = true;
            this.lblNumRap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRap.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblNumRap.Location = new System.Drawing.Point(8, 88);
            this.lblNumRap.Name = "lblNumRap";
            this.lblNumRap.Size = new System.Drawing.Size(94, 13);
            this.lblNumRap.TabIndex = 0;
            this.lblNumRap.Text = "Numéro rapport";
            // 
            // lblPractic
            // 
            this.lblPractic.AutoSize = true;
            this.lblPractic.Location = new System.Drawing.Point(8, 121);
            this.lblPractic.Name = "lblPractic";
            this.lblPractic.Size = new System.Drawing.Size(54, 13);
            this.lblPractic.TabIndex = 1;
            this.lblPractic.Text = "Practicien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Rapport";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Motif Visite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "BILAN";
            // 
            // lblOffre
            // 
            this.lblOffre.AutoSize = true;
            this.lblOffre.BackColor = System.Drawing.Color.Transparent;
            this.lblOffre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffre.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblOffre.Location = new System.Drawing.Point(375, 140);
            this.lblOffre.Name = "lblOffre";
            this.lblOffre.Size = new System.Drawing.Size(130, 17);
            this.lblOffre.TabIndex = 5;
            this.lblOffre.Text = "Offre d\'échantillons";
            // 
            // btnDetails
            // 
            this.btnDetails.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDetails.Location = new System.Drawing.Point(320, 118);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(49, 23);
            this.btnDetails.TabIndex = 6;
            this.btnDetails.Text = "Détails";
            this.btnDetails.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            this.btnFermer.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnFermer.Location = new System.Drawing.Point(467, 328);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 10;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // dgvEchantillons
            // 
            this.dgvEchantillons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEchantillons.Location = new System.Drawing.Point(378, 163);
            this.dgvEchantillons.Name = "dgvEchantillons";
            this.dgvEchantillons.Size = new System.Drawing.Size(403, 159);
            this.dgvEchantillons.TabIndex = 12;
            // 
            // txtNumRapport
            // 
            this.txtNumRapport.Enabled = false;
            this.txtNumRapport.Location = new System.Drawing.Point(110, 85);
            this.txtNumRapport.Name = "txtNumRapport";
            this.txtNumRapport.Size = new System.Drawing.Size(100, 20);
            this.txtNumRapport.TabIndex = 13;
            // 
            // txtDateRapport
            // 
            this.txtDateRapport.Location = new System.Drawing.Point(110, 145);
            this.txtDateRapport.Name = "txtDateRapport";
            this.txtDateRapport.Size = new System.Drawing.Size(100, 20);
            this.txtDateRapport.TabIndex = 15;
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(110, 171);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(156, 20);
            this.txtMotif.TabIndex = 16;
            // 
            // cboPracticiens
            // 
            this.cboPracticiens.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cboPracticiens.FormattingEnabled = true;
            this.cboPracticiens.Location = new System.Drawing.Point(110, 118);
            this.cboPracticiens.Name = "cboPracticiens";
            this.cboPracticiens.Size = new System.Drawing.Size(204, 21);
            this.cboPracticiens.TabIndex = 18;
            // 
            // txtTitre
            // 
            this.txtTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitre.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtTitre.Location = new System.Drawing.Point(25, 37);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(593, 26);
            this.txtTitre.TabIndex = 20;
            this.txtTitre.Text = "RAPPORTS DE VISITE";
            this.txtTitre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bsRapport
            // 
            this.bsRapport.CurrentChanged += new System.EventHandler(this.bsRapport_CurrentChanged);
            // 
            // txtBilan
            // 
            this.txtBilan.Location = new System.Drawing.Point(110, 200);
            this.txtBilan.Multiline = true;
            this.txtBilan.Name = "txtBilan";
            this.txtBilan.Size = new System.Drawing.Size(183, 154);
            this.txtBilan.TabIndex = 17;
            // 
            // bnRapport
            // 
            this.bnRapport.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnRapport.BindingSource = this.bsRapport;
            this.bnRapport.CountItem = this.bindingNavigatorCountItem;
            this.bnRapport.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bnRapport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bnRapport.Location = new System.Drawing.Point(0, 0);
            this.bnRapport.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnRapport.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnRapport.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnRapport.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnRapport.Name = "bnRapport";
            this.bnRapport.PositionItem = this.bindingNavigatorPositionItem;
            this.bnRapport.Size = new System.Drawing.Size(844, 25);
            this.bnRapport.TabIndex = 21;
            this.bnRapport.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // frmCptRendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(844, 416);
            this.Controls.Add(this.bnRapport);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.cboPracticiens);
            this.Controls.Add(this.txtBilan);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.txtDateRapport);
            this.Controls.Add(this.txtNumRapport);
            this.Controls.Add(this.dgvEchantillons);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.lblOffre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPractic);
            this.Controls.Add(this.lblNumRap);
            this.Name = "frmCptRendu";
            this.Text = "frmCptRendu";
            this.Load += new System.EventHandler(this.frmCptRendu_Load);
            this.Controls.SetChildIndex(this.lblNumRap, 0);
            this.Controls.SetChildIndex(this.lblPractic, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.lblOffre, 0);
            this.Controls.SetChildIndex(this.btnDetails, 0);
            this.Controls.SetChildIndex(this.btnFermer, 0);
            this.Controls.SetChildIndex(this.dgvEchantillons, 0);
            this.Controls.SetChildIndex(this.txtNumRapport, 0);
            this.Controls.SetChildIndex(this.txtDateRapport, 0);
            this.Controls.SetChildIndex(this.txtMotif, 0);
            this.Controls.SetChildIndex(this.txtBilan, 0);
            this.Controls.SetChildIndex(this.cboPracticiens, 0);
            this.Controls.SetChildIndex(this.txtTitre, 0);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.Controls.SetChildIndex(this.bnRapport, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bsPracticien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEchantillons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOffreEchantillon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnRapport)).EndInit();
            this.bnRapport.ResumeLayout(false);
            this.bnRapport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumRap;
        private System.Windows.Forms.Label lblPractic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOffre;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.DataGridView dgvEchantillons;
        private System.Windows.Forms.TextBox txtNumRapport;
        private System.Windows.Forms.TextBox txtDateRapport;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.ComboBox cboPracticiens;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.BindingSource bsOffreEchantillon;
        private System.Windows.Forms.BindingSource bsPracticien;
        private System.Windows.Forms.BindingSource bsRapport;
        private System.Windows.Forms.TextBox txtBilan;
        private System.Windows.Forms.BindingNavigator bnRapport;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}