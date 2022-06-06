using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_N_1_Cs
{
    class Client
    {
        private string nom;
        private string prenom;
        private string adresse;

        public Client(string n, string p, string add)
        {
            this.nom = n;
            this.prenom = p;
            this.adresse = add;
        }

        public override string ToString()
        {
            string s = "nom: " + this.nom + "\n" +
                       "prenom: " + this.prenom + "\n" +
                       "Addresse: " + this.adresse + "\n";
            return s;
        }

    }
}
