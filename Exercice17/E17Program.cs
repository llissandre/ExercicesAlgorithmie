﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice17
{
    internal class E17Program
    {
        //fonction pour demander le nombre souhaité
        static int DemanderNombre(String Phrase)
        {
            Console.Write(Phrase);
            int N = int.Parse(Console.ReadLine());

            return N;
        }

        static int SommeEntiersPairs(int N)
        {
            //déclaration des entiers
            int Somme = 0;
            int Entierspairstrouves = 0;
            int Entiers = 2;

            //tant que le nombre d'entiers pairs trouvés est inférieur au N renseigné
            while (Entierspairstrouves <= N)
            {
                if (Entiers % 2 == 0)
                {
                    //ajout des entiers pairs à la somme des entiers pairs
                    Somme += Entiers;
                    Entierspairstrouves++;
                    Console.WriteLine(Entiers);
                }
                //incrémentation des entiers
                Entiers += 2;
            }
            return Somme;
        }
        static void Main(string[] args)
        {
            //on demande à l'utilisateur d'entrer la valeur de n
            int N = DemanderNombre("Entrez un nombre : ");
            int SommeEntiersPairs1 = SommeEntiersPairs(N);

            //on écrit la somme des entiers pairs
            Console.WriteLine($"\nLa somme des {N} entiers inférieurs ou égaux à n pairs est : " + SommeEntiersPairs1 + " !");

            // permet de laisser la fenêtre de la console ouverte
            Console.ReadLine();
        }
    }
}

