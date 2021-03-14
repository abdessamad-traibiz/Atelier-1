using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BnkProject
{
    class Compte
    {
        private readonly int NumCpt;
        private static int Cpt = 0;
        private readonly Client Titulaire;
        private MAD Solde;
        private static MAD plafond = new MAD(2000);

        public Compte(Client cl, MAD md)
        {
            this.Titulaire = cl;
            this.Solde = md;
            this.NumCpt = ++Cpt;
        }

        public bool Crediter(MAD Somme)
        {
            if (Somme > 0)
            {
                this.Solde += Somme;
                return true;
            }
            else

                return false;
        }
        public bool Debiter(MAD Somme)
        {
            if (this.Solde > Somme && Somme <= plafond)
            {
                this.Solde -= Somme;
                return true;
            }
            return false;
        }
        public bool Verser(Compte Cmpt, MAD Somme)
        {
            if (this.Debiter(Somme) == true)
            {
                Cmpt.Crediter(Somme);
                return true;
            }
            return false;
        }
        public void Consulter()
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("Numéro du Compte: " + this.NumCpt);
            Console.Write("Solde du compte: "); Solde.Afficher();
            Console.WriteLine("Propriétaire du compte : "); Titulaire.Afficher();
            Console.WriteLine("*********************************************");
        }

    }
}
