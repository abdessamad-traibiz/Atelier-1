using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BnkProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Donner les infos du client 1--- ");
            Console.Write("    Nom :  "); string Nom1 = Console.ReadLine();
            Console.Write("    Prénom :  "); string Prenom1 = Console.ReadLine();
            Console.Write("    Adresse :  "); string Adresse1 = Console.ReadLine();
            Client client1 = new Client(Nom1, Prenom1, Adresse1);//ajouter client 1
            //-----------------------------------------------------------------------
            Console.WriteLine("Donner les infos du client 2 : ");
            Console.Write("    Nom :  "); string Nom2 = Console.ReadLine();
            Console.Write("    Prénom :  "); string Prenom2 = Console.ReadLine();
            Console.Write("    Adresse :  "); string Adresse2 = Console.ReadLine();
            Client client2 = new Client(Nom2, Prenom2, Adresse2);//ajouter client 2

            Console.WriteLine("--------------------------------------------------------");
            Console.Write("Donnez une valeur du MAD pour le client 1 : "); double valeur1 = double.Parse(Console.ReadLine());
            Console.Write("Donnez une valeur du MAD pour le client 2 : "); double valeur2 = double.Parse(Console.ReadLine());

            MAD MAD1 = new MAD(valeur1);
            MAD MAD2 = new MAD(valeur2);
            Compte compte1 = new Compte(client1, MAD1);//création du compte 1
            Compte compte2 = new Compte(client2, MAD2);//création du compte 2
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("*****Affichage du client 1*****");
            client1.AfficherClient();
            Console.WriteLine("*****Affichage du client 2*****");
            client2.AfficherClient();
            Console.WriteLine("--------------------------------------------------------");
            //-------------------------------consulter------------------------------------
            Console.WriteLine("*****Consultation du compte 1 avant de débiter*****");
            compte1.Consulter();
            Console.WriteLine("--------------------------------------------------------");
            //-------------------------------débiter------------------------------------
            Console.Write("Donnez une valeur à débiter : "); double val = double.Parse(Console.ReadLine());
            MAD deb = new MAD(val);//plafond=2000 
            if (compte1.Debiter(deb))
            {
                Console.WriteLine("Compte 1 débiter avec succé!!");
            }
            else
                Console.WriteLine("Compte 1 n'est pas débiter!!");
            Console.WriteLine("--------------------------------------------------------");
            //-------------------------------consulter------------------------------------
            Console.WriteLine("*****Consultation du compte 1 après le débit*****");
            compte1.Consulter();
            Console.WriteLine("--------------------------------------------------------");
            //-------------------------------créditer------------------------------------
            Console.Write("Donnez une valeur à créditer : "); double val1 = double.Parse(Console.ReadLine());
            MAD cred = new MAD(val1);
            if (compte2.Crediter(cred))
            {
                Console.WriteLine("Compte 2 Créditer avec succé!!");

            }
            else
                Console.WriteLine("Compte 1 n'est pas créditer!!");
            Console.WriteLine("--------------------------------------------------------");
            //-------------------------------consulter------------------------------------
            Console.WriteLine("*****Consultation du compte 2 du client 2*****");
            compte2.Consulter();
            Console.WriteLine("--------------------------------------------------------");
            //-------------------------------verser------------------------------------
            Console.WriteLine("*****Versement*****");
            Console.Write("Donnez une somme à verser : "); double S = double.Parse(Console.ReadLine());
            MAD somme = new MAD(S);
            if (compte1.Verser(compte2, somme))
            {
                Console.WriteLine("Virement bien passé !!");
            }
            else
                Console.WriteLine("Virement échoué !!");
            Console.WriteLine("--------------------------------------------------------");
            //------------------------------------------------------
            Console.WriteLine("*****Consultation du compte 1 *****");
            compte1.Consulter();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("*****Consultation du compte 2 *****");
            compte2.Consulter();
            Console.ReadKey();
        }
    }
}
