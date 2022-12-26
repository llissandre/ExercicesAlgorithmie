using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice14switch
{
    internal class E14switchProgram
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                int Calcul = 0;
                double Prix = 0;

                //affiche sur la console : "Entrer le nombre de factures effectuées" 
                Console.Write("Entrer le nombre de Copies effectuées : ");
                //parse la chaine de caractère saisie en un entier "Entier"
                double NombreCopies = int.Parse(Console.ReadLine());

                if (NombreCopies <= 10)
                {
                    Calcul++;
                }

                if (NombreCopies > 10 && NombreCopies <= 30)
                {
                    Calcul++;
                    Calcul++;
                }

                switch (Calcul)
                {
                    case 1:
                        Prix = NombreCopies * 0.1;
                        Console.Write("Vous devez : " + Prix + "€ \n");
                        break;

                    case 2:
                        Prix = 1 + ((NombreCopies - 10) * 0.09);
                        Console.Write("Vous devez : " + Prix + "€\n");
                        break;

                    default:
                        Prix = 2.8 + ((NombreCopies - 30) * 0.08);
                        Console.Write("Vous devez: " + Prix + "€\n");
                        break;
                }

                // permet de laisser la fenêtre de la console ouverte
                Console.ReadLine();
            }
        }
    }
}
