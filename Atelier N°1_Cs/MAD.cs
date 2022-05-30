using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_N_1_Cs
{
    internal class MAD
    {
        private double montant;

        public MAD(double M)
        {
            this.montant = M;
        }

        public void afficher()
        {
            Console.WriteLine("solde: "+this.montant);

        }


        public static MAD operator+(MAD m1, MAD m2)
        {
            if (m2.montant > 0) 
            {
                m1.montant = m1.montant + m2.montant;
            }
            else
            {
                Console.WriteLine("Montant entre doit etre positif");
            }
            return m1;

        }

        public static MAD operator -(MAD m1, MAD m2)
        {
            if (m2.montant <= m1.montant)
            {
                m1.montant = m1.montant - m2.montant;
            }
            else
            {
                Console.WriteLine("Solde insuffisant");
            }
            return m1;

        }

        public static bool operator <=(MAD m1, MAD m2)
        {
            if (m1.montant <= m2.montant)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static bool operator >=(MAD m1, MAD m2)
        {
            if (m1.montant >= m2.montant)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
