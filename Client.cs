using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BnkProject
{
    class Client
    {
        private string Nom, Prenom, Adresse;
        public Client(string N, string P, string A)
        {
            this.Nom = N;
            this.Prenom = P;
            this.Adresse = A;

        }
        public void Afficher()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Nom : " + this.Nom);
            Console.WriteLine("Prénom : " + this.Prenom);
            Console.WriteLine("Adresse : " + this.Adresse);
            Console.WriteLine("-----------------------------------");
        }
    }
}
