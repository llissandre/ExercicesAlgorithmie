﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Exercice20
{
    internal class E20Program
    {
        static int DemanderNombre(String Phrase)
        {
            Console.Write(Phrase);
            int N = int.Parse(Console.ReadLine());

            return N;
        }

        static string FaireCalcul(String Phrase)
        {
            Console.WriteLine(Phrase);
            String Souhait = Console.ReadLine();

            return Souhait;
        }
        static int Calcul(int N)
        {
            //déclaration des entiers
            int Somme = 0;
            int Entiers = 2;

            //tant que le nombre d'entiers pairs trouvés est inférieur au N renseigné
            while (Entiers <= N * 2)
            {
                //ajout des entiers pairs à la somme des entiers pairs
                Somme += Entiers;
                Console.WriteLine(Entiers);

                //incrémentation des entiers
                Entiers += 2;
            }
            return Somme;
        }
        static void Main(string[] args)
        {
            //
            String Souhait = FaireCalcul("Voulez-vous faire le calcul ? O/N");


            while (Souhait == "O" || Souhait == "o")
            {
                ///on demande à l'utilisateur d'entrer la valeur de n
                int N = DemanderNombre("Entrez un nombre : ");
                int Somme = Calcul(N);

                //on calcule la somme des n entiers inférieurs ou égaux à n
                Console.WriteLine($"La somme des {N} entiers inférieurs ou égaux à n est : " + Somme + "\n");

                Souhait = FaireCalcul("Voulez-vous refaire le calcul ? O/N ");
            }




        }
    }
}

