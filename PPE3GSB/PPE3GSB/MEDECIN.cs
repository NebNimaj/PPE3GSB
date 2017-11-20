using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3GSB
{
    public partial class MEDECIN
    {
        public string NP
        {
            get
            {
                return this.nom + " " + this.prenom;
            }
        }
    }
}
