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
            MAD M = new MAD(1000, "MAD");
            Dollar D = new Dollar(10, "Dollar");
            Euro E = new Euro(10, "Euro");
            MAD plaf = new MAD(100, "MAD");
            Client Cl = new Client("Jalil","Sohaib","somewhere");
            Compte Cmp = new Compte(Cl, M, plaf);

            Console.WriteLine(Cmp.ToString());
            Cmp.crediter(E);
            Console.WriteLine(Cmp.ToString());
            Cmp.Debiter(D);
            Console.WriteLine(Cmp.ToString());
        }
    }
}
