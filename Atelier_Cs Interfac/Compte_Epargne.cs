using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_N_1_Cs
{
    internal class Compte_Epargne : Compte
    {
        private double TauxInteret;

        public Compte_Epargne(Devise s, Client c, Devise fp, double t) : base(c, s, fp)
        {
            while (t > 100 || t < 0)
            {
                Console.WriteLine("donner un taux valide");
                t = double.Parse(Console.ReadLine());//pour convertir string à un double
            }
            this.TauxInteret = t;

        }
    }
}
