using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_N_1_Cs
{
    class Compte
    {
        private readonly int num_cmp;
        private static int cpt = 0;
        private readonly Client C;
        private MAD solde;
        private MAD plafond;

        public Compte(Client c, MAD montant, MAD plafond)
        {
            this.num_cmp = ++cpt;
            this.C = c;
            this.solde = montant;
            this.plafond = plafond;
        }

        public void afficher()
        {
            Console.WriteLine("NUM: "+this.num_cmp);
            this.C.afficher();
            this.solde.afficher();
            Console.WriteLine("");
        }

        public void crediter(MAD montant)
        {
            this.solde = this.solde + montant;
        }

        public void Debiter(MAD montant)
        {
            if (montant <= this.plafond)
            this.solde = this.solde - montant;
        }
    }

}
