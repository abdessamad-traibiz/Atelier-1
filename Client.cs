using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BnkProject
{
    class Client
    {
        private string Nom;
        private string Prenom;
        private string Adresse;
        public Client(string N, string P, string A)
        {
            this.Nom = N;
            this.Prenom = P;
            this.Adresse = A;

        }
        public void AfficherClient()
        {
            Console.WriteLine($"Les infos du client: Nom: {this.Nom} Prénom: {this.Prenom} Adresse: {this.Adresse}");
            /*
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Nom : " + this.Nom);
            Console.WriteLine("Prénom : " + this.Prenom);
            Console.WriteLine("Adresse : " + this.Adresse);
            Console.WriteLine("-----------------------------------");*/
        }
    }
}
