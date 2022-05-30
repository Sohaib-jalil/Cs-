using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_N_1_Cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MAD M = new MAD(1000);
            MAD plaf = new MAD(100);
            Client Cl = new Client("Jalil","Sohaib","somewhere");
            Compte Cmp = new Compte(Cl, M, plaf);

            Cmp.afficher();
            Cmp.crediter(M);
            Cmp.afficher();
            Cmp.Debiter(plaf);
            Cmp.afficher();
        }
    }
}
