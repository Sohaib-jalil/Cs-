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
            this.prenom = add;
        }

        public void afficher()
        {
            Console.WriteLine("nom: "+this.nom);
            Console.WriteLine("prenom: "+ this.prenom);
            Console.WriteLine("adresse: "+ this.adresse);
        }

    }
}
