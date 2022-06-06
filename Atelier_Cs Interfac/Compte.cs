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
        private Devise solde;
        private static Devise plafond;
        private List<Operation> Historique;

        public Compte(Client c, Devise montant, Devise plaf)
        {
            this.num_cmp = ++cpt;
            this.C = c;
            this.solde = montant;
            plafond = plaf;
            this.Historique = new List<Operation>();
        }

        public Compte()
        {

        }

        public override string ToString()
        {
            string s = "NUM: " + this.num_cmp + "\n" + this.solde.ToString() + this.C.ToString();
            return s;
        }

        public bool crediter(Devise montant)
        {
            montant = montant.ConverTo(this.solde.symboleToString());
            if (montant > 0)
            {
                this.solde = this.solde + montant;
                Operation op = new Operation("+", montant);
                this.Historique.Add(op);
                return true;
            }
            return false;
        }

        public bool Debiter(Devise montant)
        {
            montant = montant.ConverTo(this.solde.symboleToString());
            if (montant <= plafond && this.solde >= montant)
            {
                this.solde = this.solde - montant;
                Operation op = new Operation("-", montant);
                this.Historique.Add(op);
                return true;
            }
            return false;
            
        }

        public bool versement(Devise montant, Compte c)
        {
            if (this.Debiter(montant))
            {
                c.crediter(montant);
                return true;
            }
            return false;
        }

        public void afficher_historique()
        {
            Console.WriteLine(this.ToString());
            foreach (Operation o in this.Historique)
            {
                Console.WriteLine(o.ToString());
            }
        }
    }
}
