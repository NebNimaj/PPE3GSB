﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PPE3GSB
{
    public partial class frmCptRendu : frmBase
    {
        public frmCptRendu() : base()
        {
            InitializeComponent();
        bsPracticien.DataSource = Modele.MaConnexion.MEDECIN.ToList();
        }
    }
}
