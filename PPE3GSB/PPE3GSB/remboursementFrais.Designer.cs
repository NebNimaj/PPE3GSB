namespace PPE3GSB
{
    partial class remboursementFrais
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.butAjouter = new System.Windows.Forms.Button();
            this.butCloture = new System.Windows.Forms.Button();
            this.butSuppr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(313, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(257, 319);
            this.dataGridView1.TabIndex = 0;
            // 
            // butAjouter
            // 
            this.butAjouter.Location = new System.Drawing.Point(205, 143);
            this.butAjouter.Name = "butAjouter";
            this.butAjouter.Size = new System.Drawing.Size(75, 23);
            this.butAjouter.TabIndex = 2;
            this.butAjouter.Text = "Ajouter";
            this.butAjouter.UseVisualStyleBackColor = true;
            this.butAjouter.Click += new System.EventHandler(this.butAjouter_Click);
            // 
            // butCloture
            // 
            this.butCloture.Location = new System.Drawing.Point(205, 257);
            this.butCloture.Name = "butCloture";
            this.butCloture.Size = new System.Drawing.Size(75, 23);
            this.butCloture.TabIndex = 3;
            this.butCloture.Text = "Clôturer";
            this.butCloture.UseVisualStyleBackColor = true;
            // 
            // butSuppr
            // 
            this.butSuppr.Location = new System.Drawing.Point(205, 199);
            this.butSuppr.Name = "butSuppr";
            this.butSuppr.Size = new System.Drawing.Size(75, 23);
            this.butSuppr.TabIndex = 4;
            this.butSuppr.Text = "Supprimer";
            this.butSuppr.UseVisualStyleBackColor = true;
            // 
            // remboursementFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 424);
            this.Controls.Add(this.butSuppr);
            this.Controls.Add(this.butCloture);
            this.Controls.Add(this.butAjouter);
            this.Controls.Add(this.dataGridView1);
            this.Name = "remboursementFrais";
            this.Text = "remboursementFrais";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.Button butAjouter;
        private System.Windows.Forms.Button butCloture;
        private System.Windows.Forms.Button butSuppr;
    }
}
