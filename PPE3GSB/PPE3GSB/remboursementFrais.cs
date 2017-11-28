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
    public partial class remboursementFrais : Form
    {
        public remboursementFrais()
        {
            InitializeComponent();
        }

        private void butModifier_Click(object sender, EventArgs e)
        {
            modFrais frm = new modFrais();
            frm.Show();
        }

        private void butAjouter_Click(object sender, EventArgs e)
        {
            modFrais frm = new modFrais();
            frm.Show();
        }

        private void remboursementFrais_Load(object sender, EventArgs e)
        {

        }
    }
}
