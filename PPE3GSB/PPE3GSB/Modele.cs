using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3GSB
{
    static public class Modele
    {
        private static connectGSB maConnexion;
        private static int vAction;
        private static Visiteur visiteurConnecte;

        public static connectGSB MaConnexion
        {
            get
            {
                return maConnexion;
            }

            set
            {
                maConnexion = value;
            }
        }

        public static int VAction
        {
            get
            {
                return vAction;
            }

            set
            {
                vAction = value;
            }
        }

        public static Visiteur VisiteurConnecte
        {
            get
            {
                return visiteurConnecte;
            }

            set
            {
                visiteurConnecte = value;
            }
        }

        public static void initConnex()
        {
            maConnexion = new connectGSB();
        }
    }
}

