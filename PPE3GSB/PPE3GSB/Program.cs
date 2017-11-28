using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient; 
using System.Windows.Forms;

namespace PPE3GSB
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Modele.initConnex();
            Application.Run(new frmRapport());
            Application.Run(new frmRegionVisiteur());

        }
    }
}
