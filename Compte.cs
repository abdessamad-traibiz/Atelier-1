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

        //un constructeur static ,pas niv de visblite(prive,pub) , pas d'argument , sans this
        //il sert a initialiser les attributs statics
        /*static Compte()
        {
            //Cpt = 0;
            //plafond = new MAD(2000);
        }*/

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
            else

                return false;
        }
        public bool Debiter(MAD Somme)
        {
            MAD NullVal = new MAD(0);
            if (this.Solde > Somme && Somme < plafond && Somme>NullVal)
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
            Console.Write("Solde du compte: "); this.Solde.Afficher();
            Console.WriteLine("Propriétaire du compte : "); this.Titulaire.Afficher();
            Console.WriteLine("*********************************************");
        }

    }
}
