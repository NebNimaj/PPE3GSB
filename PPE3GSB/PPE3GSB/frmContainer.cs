﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3GSB
{
    public partial class frmContainer : frmBase
    {
        public frmContainer() :base()
        {
            InitializeComponent();
        }

        private void gestionRapportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionCptRendu frapport = new frmGestionCptRendu();
            frapport.MdiParent = this;
            frapport.Show();
        }

        private void frmContainer_Load(object sender, EventArgs e)
        {

        }
    }
}
