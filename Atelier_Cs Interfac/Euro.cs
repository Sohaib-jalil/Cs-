using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_N_1_Cs
{
    internal class Euro : Devise
    {
        private static double taux_MAD = 10;
        private static double taux_Dollar = 1.1;

        public Euro(double M, string symbole) : base(M, symbole)
        {

        }


        public override Devise ConverTo(string symbole)
        {
            if (symbole == "MAD")
            {
                return this.conv_dev(taux_MAD);
            }
            else if (symbole == "Dollar")
            {
                return this.conv_dev(taux_Dollar);
            }
            return this;
        }

        
    }
}
