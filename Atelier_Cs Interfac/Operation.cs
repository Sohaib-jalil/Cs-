using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_N_1_Cs
{
    internal class Operation
    {
        private readonly int num;
        private static int cpt=0;
        private string libelle;
        private Devise montant;
        private DateTime date;
        private List<Operation> Historique;

        public Operation(string lib, Devise montant)
        {
            this.num = ++cpt;
            this.libelle=lib;
            this.montant=montant;
            this.date = DateTime.Now;
            this.Historique = new List<Operation>();
        }

        public override string ToString()
        {
            string s = this.date + "|" + this.num + "|" + this.libelle + this.montant;
            return s;
        }
    }
}
