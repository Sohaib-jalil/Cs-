using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_N_1_Cs
{
    internal class MAD : Devise
    {
        private static double taux_Euro = 0.1;
        private static double taux_Dollar = 0.09;

        public MAD(double M, string symbole) : base(M, symbole)
        {

        }


        public override Devise ConverTo(string symbole)
        {
            if (symbole == "Euro")
            {
                return this.conv_dev(taux_Euro);
            }
            else if (symbole == "Dollar")
            {
                return this.conv_dev(taux_Dollar);
            }
            return this;
        }

       
        
    }
}
