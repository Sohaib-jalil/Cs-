using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_N_1_Cs
{
    abstract class Devise : IDevise
    {
        private double montant;
        private string symbole;

        public Devise(double M, string symbole)
        {
            this.montant = M;
            this.symbole = symbole;
        }

        public abstract Devise ConverTo(string symbole);

        public Devise conv_dev(double taux)
        {
            this.montant *= taux;
            return this;
        }
        
        public override string ToString()
        {
            string s = "solde: " + this.montant + this.symbole + "\n";
            return s;
        }

        public string symboleToString()
        {
            string s = this.symbole;
            return s;
        }

        public static Devise operator +(Devise m1, Devise m2)
        {
            m1.montant = m1.montant + m2.montant;
            return m1;

        }

        public static Devise operator -(Devise m1, Devise m2)
        {
            m1.montant = m1.montant - m2.montant;
            return m1;
        }

        public static bool operator <=(Devise m1, Devise m2)
        {
            return (m1.montant <= m2.montant);
        }

        public static bool operator >=(Devise m1, Devise m2)
        {
            return !(m1 <= m2);
        }
        
        public static bool operator >(Devise m1, double n)
        {
            return (m1.montant > n);
        }
        
        public static bool operator <(Devise m1, double n)
        {
            return (m1.montant < n);
        }
    }
}
