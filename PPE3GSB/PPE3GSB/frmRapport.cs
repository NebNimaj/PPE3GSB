using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace PPE3GSB
{
    public partial class frmRapport : frmBase
    {
        public frmRapport() :base()
        {
            InitializeComponent();
            lblTitre.ForeColor = System.Drawing.Color.DarkBlue;
            lblTitre.Text= "IDENTIFIEZ VOUS";
        }

        public bool Validation()
        {
            var filteredData = Modele.MaConnexion.Visiteur.ToList()
                         .Where(x => x.identifiant.Equals(txtIdent.Text));
            if (filteredData.ToList().Count == 0)
            {
                MessageBox.Show("Identifiant non valide");
                return false;
            }
            else
            {
                bsVisiteur.DataSource = filteredData; // application du filtre
                bsVisiteur.MoveFirst();
                Visiteur monVisiteur = (Visiteur)bsVisiteur.Current;
                MD5 monMD5 = MD5.Create();
                string passwdCrypte = GetMd5Hash(monMD5, txtMDP.Text);
                string pswdc = monVisiteur.password.Substring(2); // Pbs de l'hexa 0x sur sqlserver
                if (pswdc.Equals(passwdCrypte) || monVisiteur.password.Equals(passwdCrypte))
                {
                    Modele.VisiteurConnecte = monVisiteur;
                    return true;
                }
                else
                {
                    MessageBox.Show("PSWD non valide");
                    return false;
                }
            }

        }
    
    static string GetMd5Hash(MD5 MonMD5, string PasswdSaisi)
    {
        // step 1, calculate MD5 hash from input

        byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
        byte[] hash = MonMD5.ComputeHash(inputBytes);
        // step 2, convert byte array to hex string
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < hash.Length; i++)
        {
            sb.Append(hash[i].ToString("x2"));
        }
        return sb.ToString();

    }
    public static void ThreadProc()
    {
        Application.Run(new frmContainer());
    }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                this.Close();
                //

                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));

                //
                t.Start();

            }
        }
    }
}
