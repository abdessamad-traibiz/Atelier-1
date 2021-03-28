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
        private static int Cpt = 18007;
        private readonly Client Titulaire;
        private MAD Solde;
        private static MAD plafond = new MAD(2000);

        /*un constructeur static ,pas niv de visblite(prive,pub) , pas d'argument , sans this
        il sert a initialiser les attributs statics
        static Compte()
        {
            //Cpt = 0;
            //plafond = new MAD(2000);
        }*/
        public Compte(Client cl)
        {
            this.Titulaire = cl;
            this.Solde = new MAD(0.00);
            this.NumCpt = ++Cpt;
        }
         public Compte(Client cl, MAD md)
        {
            this.Titulaire = cl;
            this.Solde = md;
            this.NumCpt = ++Cpt;
            
        }

        public bool Crediter(MAD Somme)
        {
            MAD ValNull = new MAD(0);
            if (Somme > ValNull)
            {
                this.Solde += Somme;
                return true;
            }
            Console.WriteLine("impossible somme negatif !!!");
            return false;
        }
        public bool Debiter(MAD Somme)
        {
            MAD NullVal = new MAD(0);
            if (Somme > NullVal)
            {
                if (Solde >= Somme && Somme<=plafond)
                {
                    this.Solde -= Somme;
                    return true;
                }
                else if (Somme > plafond)
                {
                    Console.WriteLine("Valeur supérieur au plafond");
                    return false;
                }
                else
                {
                    Console.WriteLine("Impossible solde insuffisant");
                    return false;
                }
            }
            Console.WriteLine("Impossible somme negatif !!");
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
            Console.Write("Solde du compte: "); this.Solde.AfficherSolde();
            Console.WriteLine("Propriétaire du compte : "); this.Titulaire.AfficherClient();
            Console.WriteLine("*********************************************");
        }

    }
}
