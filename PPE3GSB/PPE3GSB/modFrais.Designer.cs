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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labMontant = new System.Windows.Forms.Label();
            this.labForfait = new System.Windows.Forms.Label();
            this.labQuant = new System.Windows.Forms.Label();
            this.labTot = new System.Windows.Forms.Label();
            this.labMontUnit = new System.Windows.Forms.Label();
            this.labDate = new System.Windows.Forms.Label();
            this.labLibellé = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.labFrais = new System.Windows.Forms.Label();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Forfait étape",
            "Frais kilométrique",
            "Nuitée hôtel",
            "Repas restaurant"});
            this.comboBox1.Location = new System.Drawing.Point(134, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // labMontant
            // 
            this.labMontant.AutoSize = true;
            this.labMontant.Location = new System.Drawing.Point(26, 294);
            this.labMontant.Name = "labMontant";
            this.labMontant.Size = new System.Drawing.Size(52, 13);
            this.labMontant.TabIndex = 5;
            this.labMontant.Text = "Montant :";
            // 
            // labForfait
            // 
            this.labForfait.AutoSize = true;
            this.labForfait.Location = new System.Drawing.Point(26, 55);
            this.labForfait.Name = "labForfait";
            this.labForfait.Size = new System.Drawing.Size(86, 13);
            this.labForfait.TabIndex = 6;
            this.labForfait.Text = "Type de forfaits :";
            // 
            // labQuant
            // 
            this.labQuant.AutoSize = true;
            this.labQuant.Location = new System.Drawing.Point(26, 81);
            this.labQuant.Name = "labQuant";
            this.labQuant.Size = new System.Drawing.Size(53, 13);
            this.labQuant.TabIndex = 7;
            this.labQuant.Text = "Quantité :";
            // 
            // labTot
            // 
            this.labTot.AutoSize = true;
            this.labTot.Location = new System.Drawing.Point(26, 133);
            this.labTot.Name = "labTot";
            this.labTot.Size = new System.Drawing.Size(37, 13);
            this.labTot.TabIndex = 8;
            this.labTot.Text = "Total :";
            // 
            // labMontUnit
            // 
            this.labMontUnit.AutoSize = true;
            this.labMontUnit.Location = new System.Drawing.Point(26, 107);
            this.labMontUnit.Name = "labMontUnit";
            this.labMontUnit.Size = new System.Drawing.Size(89, 13);
            this.labMontUnit.TabIndex = 9;
            this.labMontUnit.Text = "Montant unitaire :";
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Location = new System.Drawing.Point(26, 242);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(36, 13);
            this.labDate.TabIndex = 10;
            this.labDate.Text = "Date :";
            // 
            // labLibellé
            // 
            this.labLibellé.AutoSize = true;
            this.labLibellé.Location = new System.Drawing.Point(26, 268);
            this.labLibellé.Name = "labLibellé";
            this.labLibellé.Size = new System.Drawing.Size(43, 13);
            this.labLibellé.TabIndex = 11;
            this.labLibellé.Text = "Libellé :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(155, 287);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(155, 261);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(155, 235);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(155, 126);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 16;
            // 
            // labFrais
            // 
            this.labFrais.AutoSize = true;
            this.labFrais.Location = new System.Drawing.Point(26, 28);
            this.labFrais.Name = "labFrais";
            this.labFrais.Size = new System.Drawing.Size(74, 13);
            this.labFrais.TabIndex = 17;
            this.labFrais.Text = "Type de frais :";
            // 
            // cboTypeFrais
            // 
            this.cboTypeFrais.FormattingEnabled = true;
            this.cboTypeFrais.Items.AddRange(new object[] {
            "Frais forfaitisés ",
            "Frais hors forfait "});
            this.cboTypeFrais.Location = new System.Drawing.Point(134, 20);
            this.cboTypeFrais.Name = "cboTypeFrais";
            this.cboTypeFrais.Size = new System.Drawing.Size(121, 21);
            this.cboTypeFrais.TabIndex = 18;
            // 
            // modFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 410);
            this.Controls.Add(this.cboTypeFrais);
            this.Controls.Add(this.labFrais);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labLibellé);
            this.Controls.Add(this.labDate);
            this.Controls.Add(this.labMontUnit);
            this.Controls.Add(this.labTot);
            this.Controls.Add(this.labQuant);
            this.Controls.Add(this.labForfait);
            this.Controls.Add(this.labMontant);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.butAnnuler);
            this.Controls.Add(this.butAccept);
            this.Name = "modFrais";
            this.Text = "modFrais";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAccept;
        private System.Windows.Forms.Button butAnnuler;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labMontant;
        private System.Windows.Forms.Label labForfait;
        private System.Windows.Forms.Label labQuant;
        private System.Windows.Forms.Label labTot;
        private System.Windows.Forms.Label labMontUnit;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.Label labLibellé;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label labFrais;
        private System.Windows.Forms.ComboBox cboTypeFrais;
    }
}