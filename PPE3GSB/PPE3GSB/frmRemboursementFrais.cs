using System;
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
    public partial class frmRemboursementFrais : Form
    {
        public frmRemboursementFrais()
        {
            InitializeComponent();
        }

        private void butModifier_Click(object sender, EventArgs e)
        {
            frmModFrais frm = new frmModFrais();
            frm.Show();
        }

        private void butAjouter_Click(object sender, EventArgs e)
        {
            frmModFrais frm = new frmModFrais();
            frm.Show();
        }
    }
}
