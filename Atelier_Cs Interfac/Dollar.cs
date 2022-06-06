using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_N_1_Cs
{
    internal class Dollar : Devise
    {
        private static double taux_Euro = 0.9;
        private static double taux_MAD = 9;

        public Dollar(double M, string symbole) : base(M, symbole)
        {

        }


        public override Devise ConverTo(string symbole)
        {
            if (symbole == "Euro")
            {
                return this.conv_dev(taux_Euro);
            }
            else if (symbole == "MAD")
            {
                return this.conv_dev(taux_MAD);
            }
            return this;
        }

        public override string ToString()
        {
            string s = "solde: " + "" + "\n";
            return s;
        }
    }
}
