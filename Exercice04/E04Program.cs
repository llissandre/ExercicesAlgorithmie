using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
    internal class E04Program
    {
        static void Main(string[] args)
        {
            //définition d'une valeur à n -> 5
            int n = 5;

            //calcul de la valeur 
            n = n + 1;

            //définition d'une valeur à n -> 10
            //la valeur de n est écrasée
            n = 10;

            //affiche sur la console la valeur de n
            Console.WriteLine("La valeur de n est : " + n);

            //permet de laisser la fenêtre de la console ouverte
            Console.ReadLine();
        }
    }
}
