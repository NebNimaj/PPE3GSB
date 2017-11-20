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
    public partial class frmMenuGestion : Form
    {
        public frmMenuGestion()
        {
            InitializeComponent();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            frmVisiteur f1 = new frmVisiteur();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMenuGestion_Load(object sender, EventArgs e)
        {

        }
    }
}
