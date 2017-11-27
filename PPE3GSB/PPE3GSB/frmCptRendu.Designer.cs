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
            this.lblDateRapport = new System.Windows.Forms.Label();
            this.lblBilan = new System.Windows.Forms.Label();
            this.lblOffre = new System.Windows.Forms.Label();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.txtNumRapport = new System.Windows.Forms.TextBox();
            this.cboPracticiens = new System.Windows.Forms.ComboBox();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.txtBilan = new System.Windows.Forms.TextBox();
            this.bnRapport = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bsRapport = new System.Windows.Forms.BindingSource(this.components);
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
            this.bindingNavigatorModifyItem = new System.Windows.Forms.ToolStripButton();
            this.btnModifier = new System.Windows.Forms.Button();
            this.dtpRapport = new System.Windows.Forms.DateTimePicker();
            this.btnAjout = new System.Windows.Forms.Button();
            this.bsPracticien = new System.Windows.Forms.BindingSource(this.components);
            this.bsPresentation = new System.Windows.Forms.BindingSource(this.components);
            this.lblMotif = new System.Windows.Forms.Label();
            this.bsMotif = new System.Windows.Forms.BindingSource(this.components);
            this.cboIdMotif = new System.Windows.Forms.ComboBox();
            this.cboMedicament = new System.Windows.Forms.ComboBox();
            this.bsOffrir = new System.Windows.Forms.BindingSource(this.components);
            this.lblMedicament = new System.Windows.Forms.Label();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.btnAjoutMedicament = new System.Windows.Forms.Button();
            this.bsMedicament = new System.Windows.Forms.BindingSource(this.components);
            this.nupQuantite = new System.Windows.Forms.NumericUpDown();
            this.dgvEchantillons = new System.Windows.Forms.DataGridView();
            this.lblAjoutEchantillons = new System.Windows.Forms.Label();
            this.dgvAjoutEchantillons = new System.Windows.Forms.DataGridView();
            this.btnRemplacant = new System.Windows.Forms.Button();
            this.lblRemplacantNom = new System.Windows.Forms.Label();
            this.txtRemplacant = new System.Windows.Forms.TextBox();
            this.btnPresentation = new System.Windows.Forms.Button();
            this.btnOffert = new System.Windows.Forms.Button();
            this.lblChoixAffichage = new System.Windows.Forms.Label();
            this.nupNote = new System.Windows.Forms.NumericUpDown();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblRemplacantPrenom = new System.Windows.Forms.Label();
            this.txtRemplacantPrenom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bnRapport)).BeginInit();
            this.bnRapport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPracticien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPresentation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOffrir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedicament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEchantillons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAjoutEchantillons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNote)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumRap
            // 
            this.lblNumRap.AutoSize = true;
            this.lblNumRap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNumRap.Location = new System.Drawing.Point(8, 95);
            this.lblNumRap.Name = "lblNumRap";
            this.lblNumRap.Size = new System.Drawing.Size(80, 13);
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
            // lblDateRapport
            // 
            this.lblDateRapport.AutoSize = true;
            this.lblDateRapport.Location = new System.Drawing.Point(8, 203);
            this.lblDateRapport.Name = "lblDateRapport";
            this.lblDateRapport.Size = new System.Drawing.Size(71, 13);
            this.lblDateRapport.TabIndex = 2;
            this.lblDateRapport.Text = "Date Rapport";
            // 
            // lblBilan
            // 
            this.lblBilan.AutoSize = true;
            this.lblBilan.Location = new System.Drawing.Point(8, 250);
            this.lblBilan.Name = "lblBilan";
            this.lblBilan.Size = new System.Drawing.Size(38, 13);
            this.lblBilan.TabIndex = 4;
            this.lblBilan.Text = "BILAN";
            // 
            // lblOffre
            // 
            this.lblOffre.AutoSize = true;
            this.lblOffre.BackColor = System.Drawing.Color.Transparent;
            this.lblOffre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffre.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblOffre.Location = new System.Drawing.Point(386, 66);
            this.lblOffre.Name = "lblOffre";
            this.lblOffre.Size = new System.Drawing.Size(151, 17);
            this.lblOffre.TabIndex = 5;
            this.lblOffre.Text = "Echantillons présentés";
            this.lblOffre.Visible = false;
            // 
            // btnDetails
            // 
            this.btnDetails.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDetails.Location = new System.Drawing.Point(295, 119);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(49, 23);
            this.btnDetails.TabIndex = 6;
            this.btnDetails.Text = "Détails";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnFermer.Location = new System.Drawing.Point(692, 388);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 10;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // txtNumRapport
            // 
            this.txtNumRapport.Enabled = false;
            this.txtNumRapport.Location = new System.Drawing.Point(106, 92);
            this.txtNumRapport.Name = "txtNumRapport";
            this.txtNumRapport.Size = new System.Drawing.Size(100, 20);
            this.txtNumRapport.TabIndex = 13;
            // 
            // cboPracticiens
            // 
            this.cboPracticiens.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cboPracticiens.FormattingEnabled = true;
            this.cboPracticiens.Location = new System.Drawing.Point(106, 118);
            this.cboPracticiens.Name = "cboPracticiens";
            this.cboPracticiens.Size = new System.Drawing.Size(183, 21);
            this.cboPracticiens.TabIndex = 18;
            // 
            // txtTitre
            // 
            this.txtTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitre.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtTitre.Location = new System.Drawing.Point(4, 34);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(593, 26);
            this.txtTitre.TabIndex = 20;
            this.txtTitre.Text = "RAPPORTS DE VISITE";
            this.txtTitre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBilan
            // 
            this.txtBilan.Enabled = false;
            this.txtBilan.Location = new System.Drawing.Point(106, 247);
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
            this.bindingNavigatorModifyItem,
            this.bindingNavigatorDeleteItem});
            this.bnRapport.Location = new System.Drawing.Point(0, 0);
            this.bnRapport.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnRapport.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnRapport.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnRapport.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnRapport.Name = "bnRapport";
            this.bnRapport.PositionItem = this.bindingNavigatorPositionItem;
            this.bnRapport.Size = new System.Drawing.Size(930, 25);
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
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bsRapport
            // 
            this.bsRapport.CurrentChanged += new System.EventHandler(this.bsRapport_CurrentChanged);
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
            // bindingNavigatorModifyItem
            // 
            this.bindingNavigatorModifyItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorModifyItem.Image = global::PPE3GSB.Properties.Resources.bouton_modifier_318_77528;
            this.bindingNavigatorModifyItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorModifyItem.Name = "bindingNavigatorModifyItem";
            this.bindingNavigatorModifyItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorModifyItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorModifyItem.Text = "Modifier";
            this.bindingNavigatorModifyItem.Click += new System.EventHandler(this.bindingNavigatorModifyItem_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnModifier.Location = new System.Drawing.Point(378, 388);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 22;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Visible = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // dtpRapport
            // 
            this.dtpRapport.Enabled = false;
            this.dtpRapport.Location = new System.Drawing.Point(106, 197);
            this.dtpRapport.Name = "dtpRapport";
            this.dtpRapport.Size = new System.Drawing.Size(183, 20);
            this.dtpRapport.TabIndex = 23;
            // 
            // btnAjout
            // 
            this.btnAjout.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAjout.Location = new System.Drawing.Point(378, 388);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(75, 23);
            this.btnAjout.TabIndex = 24;
            this.btnAjout.Text = "Ajout";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Visible = false;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // bsPresentation
            // 
            this.bsPresentation.DataSource = typeof(PPE3GSB.MEDICAMENT);
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(8, 228);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(58, 13);
            this.lblMotif.TabIndex = 3;
            this.lblMotif.Text = "Motif Visite";
            // 
            // bsMotif
            // 
            this.bsMotif.DataSource = typeof(PPE3GSB.MOTIF);
            // 
            // cboIdMotif
            // 
            this.cboIdMotif.FormattingEnabled = true;
            this.cboIdMotif.Location = new System.Drawing.Point(106, 223);
            this.cboIdMotif.Name = "cboIdMotif";
            this.cboIdMotif.Size = new System.Drawing.Size(183, 21);
            this.cboIdMotif.TabIndex = 25;
            // 
            // cboMedicament
            // 
            this.cboMedicament.DataSource = this.bsOffrir;
            this.cboMedicament.FormattingEnabled = true;
            this.cboMedicament.Location = new System.Drawing.Point(476, 308);
            this.cboMedicament.Name = "cboMedicament";
            this.cboMedicament.Size = new System.Drawing.Size(121, 21);
            this.cboMedicament.TabIndex = 26;
            this.cboMedicament.Visible = false;
            // 
            // bsOffrir
            // 
            this.bsOffrir.DataSource = typeof(PPE3GSB.OFFRIR);
            // 
            // lblMedicament
            // 
            this.lblMedicament.AutoSize = true;
            this.lblMedicament.Location = new System.Drawing.Point(405, 316);
            this.lblMedicament.Name = "lblMedicament";
            this.lblMedicament.Size = new System.Drawing.Size(65, 13);
            this.lblMedicament.TabIndex = 27;
            this.lblMedicament.Text = "Médicament";
            this.lblMedicament.Visible = false;
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Location = new System.Drawing.Point(637, 316);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(47, 13);
            this.lblQuantite.TabIndex = 28;
            this.lblQuantite.Text = "Quantité";
            this.lblQuantite.Visible = false;
            // 
            // btnAjoutMedicament
            // 
            this.btnAjoutMedicament.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAjoutMedicament.Location = new System.Drawing.Point(569, 348);
            this.btnAjoutMedicament.Name = "btnAjoutMedicament";
            this.btnAjoutMedicament.Size = new System.Drawing.Size(118, 23);
            this.btnAjoutMedicament.TabIndex = 30;
            this.btnAjoutMedicament.Text = "Ajout medicament";
            this.btnAjoutMedicament.UseVisualStyleBackColor = true;
            this.btnAjoutMedicament.Visible = false;
            this.btnAjoutMedicament.Click += new System.EventHandler(this.btnAjoutMedicament_Click);
            // 
            // nupQuantite
            // 
            this.nupQuantite.Location = new System.Drawing.Point(711, 309);
            this.nupQuantite.Name = "nupQuantite";
            this.nupQuantite.Size = new System.Drawing.Size(100, 20);
            this.nupQuantite.TabIndex = 31;
            this.nupQuantite.Visible = false;
            // 
            // dgvEchantillons
            // 
            this.dgvEchantillons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEchantillons.Location = new System.Drawing.Point(385, 85);
            this.dgvEchantillons.Name = "dgvEchantillons";
            this.dgvEchantillons.Size = new System.Drawing.Size(246, 178);
            this.dgvEchantillons.TabIndex = 31;
            this.dgvEchantillons.Visible = false;
            // 
            // lblAjoutEchantillons
            // 
            this.lblAjoutEchantillons.AutoSize = true;
            this.lblAjoutEchantillons.BackColor = System.Drawing.Color.Transparent;
            this.lblAjoutEchantillons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjoutEchantillons.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblAjoutEchantillons.Location = new System.Drawing.Point(637, 66);
            this.lblAjoutEchantillons.Name = "lblAjoutEchantillons";
            this.lblAjoutEchantillons.Size = new System.Drawing.Size(150, 17);
            this.lblAjoutEchantillons.TabIndex = 32;
            this.lblAjoutEchantillons.Text = "Echantillons a modifier";
            this.lblAjoutEchantillons.Visible = false;
            // 
            // dgvAjoutEchantillons
            // 
            this.dgvAjoutEchantillons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAjoutEchantillons.Location = new System.Drawing.Point(640, 85);
            this.dgvAjoutEchantillons.Name = "dgvAjoutEchantillons";
            this.dgvAjoutEchantillons.Size = new System.Drawing.Size(246, 178);
            this.dgvAjoutEchantillons.TabIndex = 33;
            this.dgvAjoutEchantillons.Visible = false;
            // 
            // btnRemplacant
            // 
            this.btnRemplacant.Location = new System.Drawing.Point(350, 118);
            this.btnRemplacant.Name = "btnRemplacant";
            this.btnRemplacant.Size = new System.Drawing.Size(19, 23);
            this.btnRemplacant.TabIndex = 34;
            this.btnRemplacant.Text = "X";
            this.btnRemplacant.UseVisualStyleBackColor = true;
            this.btnRemplacant.Visible = false;
            this.btnRemplacant.Click += new System.EventHandler(this.btnRemplacant_Click);
            // 
            // lblRemplacantNom
            // 
            this.lblRemplacantNom.AutoSize = true;
            this.lblRemplacantNom.Location = new System.Drawing.Point(8, 148);
            this.lblRemplacantNom.Name = "lblRemplacantNom";
            this.lblRemplacantNom.Size = new System.Drawing.Size(98, 13);
            this.lblRemplacantNom.TabIndex = 35;
            this.lblRemplacantNom.Text = "Remplacant :  Nom";
            this.lblRemplacantNom.Visible = false;
            // 
            // txtRemplacant
            // 
            this.txtRemplacant.Enabled = false;
            this.txtRemplacant.Location = new System.Drawing.Point(106, 145);
            this.txtRemplacant.Name = "txtRemplacant";
            this.txtRemplacant.Size = new System.Drawing.Size(100, 20);
            this.txtRemplacant.TabIndex = 36;
            this.txtRemplacant.Visible = false;
            // 
            // btnPresentation
            // 
            this.btnPresentation.Location = new System.Drawing.Point(85, 66);
            this.btnPresentation.Name = "btnPresentation";
            this.btnPresentation.Size = new System.Drawing.Size(83, 23);
            this.btnPresentation.TabIndex = 37;
            this.btnPresentation.Text = "Presentation";
            this.btnPresentation.UseVisualStyleBackColor = true;
            this.btnPresentation.Click += new System.EventHandler(this.btnPresentation_Click);
            // 
            // btnOffert
            // 
            this.btnOffert.Location = new System.Drawing.Point(199, 65);
            this.btnOffert.Name = "btnOffert";
            this.btnOffert.Size = new System.Drawing.Size(75, 23);
            this.btnOffert.TabIndex = 38;
            this.btnOffert.Text = "Offert";
            this.btnOffert.UseVisualStyleBackColor = true;
            this.btnOffert.Click += new System.EventHandler(this.btnOffert_Click);
            // 
            // lblChoixAffichage
            // 
            this.lblChoixAffichage.AutoSize = true;
            this.lblChoixAffichage.Location = new System.Drawing.Point(8, 70);
            this.lblChoixAffichage.Name = "lblChoixAffichage";
            this.lblChoixAffichage.Size = new System.Drawing.Size(71, 13);
            this.lblChoixAffichage.TabIndex = 39;
            this.lblChoixAffichage.Text = "Medicament :";
            // 
            // nupNote
            // 
            this.nupNote.Location = new System.Drawing.Point(106, 171);
            this.nupNote.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nupNote.Name = "nupNote";
            this.nupNote.Size = new System.Drawing.Size(100, 20);
            this.nupNote.TabIndex = 40;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(8, 173);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(69, 13);
            this.lblNote.TabIndex = 41;
            this.lblNote.Text = "Note (1 à 10)";
            // 
            // lblRemplacantPrenom
            // 
            this.lblRemplacantPrenom.AutoSize = true;
            this.lblRemplacantPrenom.Location = new System.Drawing.Point(210, 148);
            this.lblRemplacantPrenom.Name = "lblRemplacantPrenom";
            this.lblRemplacantPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblRemplacantPrenom.TabIndex = 42;
            this.lblRemplacantPrenom.Text = "Prenom";
            this.lblRemplacantPrenom.Visible = false;
            // 
            // txtRemplacantPrenom
            // 
            this.txtRemplacantPrenom.Enabled = false;
            this.txtRemplacantPrenom.Location = new System.Drawing.Point(259, 145);
            this.txtRemplacantPrenom.Name = "txtRemplacantPrenom";
            this.txtRemplacantPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtRemplacantPrenom.TabIndex = 43;
            this.txtRemplacantPrenom.Visible = false;
            // 
            // frmCptRendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(930, 416);
            this.Controls.Add(this.txtRemplacantPrenom);
            this.Controls.Add(this.lblRemplacantPrenom);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.nupNote);
            this.Controls.Add(this.lblChoixAffichage);
            this.Controls.Add(this.btnOffert);
            this.Controls.Add(this.btnPresentation);
            this.Controls.Add(this.txtRemplacant);
            this.Controls.Add(this.lblRemplacantNom);
            this.Controls.Add(this.btnRemplacant);
            this.Controls.Add(this.dgvAjoutEchantillons);
            this.Controls.Add(this.lblAjoutEchantillons);
            this.Controls.Add(this.dgvEchantillons);
            this.Controls.Add(this.nupQuantite);
            this.Controls.Add(this.btnAjoutMedicament);
            this.Controls.Add(this.lblQuantite);
            this.Controls.Add(this.lblMedicament);
            this.Controls.Add(this.cboMedicament);
            this.Controls.Add(this.cboIdMotif);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.dtpRapport);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.bnRapport);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.cboPracticiens);
            this.Controls.Add(this.txtBilan);
            this.Controls.Add(this.txtNumRapport);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.lblOffre);
            this.Controls.Add(this.lblBilan);
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.lblDateRapport);
            this.Controls.Add(this.lblPractic);
            this.Controls.Add(this.lblNumRap);
            this.Name = "frmCptRendu";
            this.Text = "frmCptRendu";
            this.Load += new System.EventHandler(this.frmCptRendu_Load);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.Controls.SetChildIndex(this.lblNumRap, 0);
            this.Controls.SetChildIndex(this.lblPractic, 0);
            this.Controls.SetChildIndex(this.lblDateRapport, 0);
            this.Controls.SetChildIndex(this.lblMotif, 0);
            this.Controls.SetChildIndex(this.lblBilan, 0);
            this.Controls.SetChildIndex(this.lblOffre, 0);
            this.Controls.SetChildIndex(this.btnDetails, 0);
            this.Controls.SetChildIndex(this.btnFermer, 0);
            this.Controls.SetChildIndex(this.txtNumRapport, 0);
            this.Controls.SetChildIndex(this.txtBilan, 0);
            this.Controls.SetChildIndex(this.cboPracticiens, 0);
            this.Controls.SetChildIndex(this.txtTitre, 0);
            this.Controls.SetChildIndex(this.bnRapport, 0);
            this.Controls.SetChildIndex(this.btnModifier, 0);
            this.Controls.SetChildIndex(this.dtpRapport, 0);
            this.Controls.SetChildIndex(this.btnAjout, 0);
            this.Controls.SetChildIndex(this.cboIdMotif, 0);
            this.Controls.SetChildIndex(this.cboMedicament, 0);
            this.Controls.SetChildIndex(this.lblMedicament, 0);
            this.Controls.SetChildIndex(this.lblQuantite, 0);
            this.Controls.SetChildIndex(this.btnAjoutMedicament, 0);
            this.Controls.SetChildIndex(this.nupQuantite, 0);
            this.Controls.SetChildIndex(this.dgvEchantillons, 0);
            this.Controls.SetChildIndex(this.lblAjoutEchantillons, 0);
            this.Controls.SetChildIndex(this.dgvAjoutEchantillons, 0);
            this.Controls.SetChildIndex(this.btnRemplacant, 0);
            this.Controls.SetChildIndex(this.lblRemplacantNom, 0);
            this.Controls.SetChildIndex(this.txtRemplacant, 0);
            this.Controls.SetChildIndex(this.btnPresentation, 0);
            this.Controls.SetChildIndex(this.btnOffert, 0);
            this.Controls.SetChildIndex(this.lblChoixAffichage, 0);
            this.Controls.SetChildIndex(this.nupNote, 0);
            this.Controls.SetChildIndex(this.lblNote, 0);
            this.Controls.SetChildIndex(this.lblRemplacantPrenom, 0);
            this.Controls.SetChildIndex(this.txtRemplacantPrenom, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bnRapport)).EndInit();
            this.bnRapport.ResumeLayout(false);
            this.bnRapport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPracticien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPresentation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOffrir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedicament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEchantillons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAjoutEchantillons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumRap;
        private System.Windows.Forms.Label lblPractic;
        private System.Windows.Forms.Label lblDateRapport;
        private System.Windows.Forms.Label lblBilan;
        private System.Windows.Forms.Label lblOffre;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.TextBox txtNumRapport;
        private System.Windows.Forms.ComboBox cboPracticiens;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.BindingSource bsPresentation;
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
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.DateTimePicker dtpRapport;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.ToolStripButton bindingNavigatorModifyItem;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.BindingSource bsMotif;
        private System.Windows.Forms.ComboBox cboIdMotif;
        private System.Windows.Forms.ComboBox cboMedicament;
        private System.Windows.Forms.Label lblMedicament;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.Button btnAjoutMedicament;
        private System.Windows.Forms.BindingSource bsMedicament;
        private System.Windows.Forms.NumericUpDown nupQuantite;
        private System.Windows.Forms.DataGridView dgvEchantillons;
        private System.Windows.Forms.Label lblAjoutEchantillons;
        private System.Windows.Forms.DataGridView dgvAjoutEchantillons;
        private System.Windows.Forms.BindingSource bsOffrir;
        private System.Windows.Forms.Button btnRemplacant;
        private System.Windows.Forms.Label lblRemplacantNom;
        private System.Windows.Forms.TextBox txtRemplacant;
        private System.Windows.Forms.Button btnPresentation;
        private System.Windows.Forms.Button btnOffert;
        private System.Windows.Forms.Label lblChoixAffichage;
        private System.Windows.Forms.NumericUpDown nupNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblRemplacantPrenom;
        private System.Windows.Forms.TextBox txtRemplacantPrenom;
    }
}