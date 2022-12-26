﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice10
{
    internal class E10Program
    {
        static void Main(string[] args)
        {
            //affiche sur la console : "Rentrer un premier nombre entier:"
            Console.WriteLine("Rentrez un nombre entier :");
            //récupère le premier entier donné par l'utilisateur et
            //le range dans la variable E1
            String E1 = Console.ReadLine();

            //affiche sur la console : "Rentrer un second nombre entier:"
            Console.WriteLine("Rentrez un nombre entier :");
            //récupère le second entier donné par l'utilisateur et
            //le range dans la variable E2
            String E2 = Console.ReadLine();

            //parse la chaine de caractère "E1" en un entier "Entier1"
            int Entier1 = int.Parse(E1);
            //parse la chaine de caractère "E2" en un entier "Entier2"
            int Entier2 = int.Parse(E2);

            //si l'un des deux entiers est égal à zéro on ne doit pas effectuer
            //le calcul
            //alors
            if (Entier1 != 0 && Entier2 != 0)
            {

                //calcul du produit
                int Entier3 = Entier1 * Entier2;

                //comparaison des deux entiers
                //si le produit des deux entiers est positif
                //alors
                if (Entier3 > 0)
                {
                    Console.WriteLine("Le produit des deux entiers est positif");
                }
                //sinon
                else
                {
                    Console.WriteLine("Le produit des deux entiers est négatif");
                }
            }

            //sinon
            else
            {
                {
                    Console.WriteLine("Le calcul n'est pas possible");
                }

            }
            // permet de laisser la fenêtre de la console ouverte
            Console.ReadLine();
        }
    }
}
