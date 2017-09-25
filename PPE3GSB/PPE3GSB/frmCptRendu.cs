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
    public partial class frmCptRendu : Form
    {
        public frmCptRendu()
        {
            InitializeComponent();
        bsPracticien.DataSource = Modele.MaConnexion.MEDECIN.ToList();
        }
    }
}
