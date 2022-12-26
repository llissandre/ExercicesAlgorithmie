using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice16
{
    internal class E16Program
    {
        static void Main(string[] args)
        {
            //n est fixé à 5
            int n = 5;

            int Somme = 0;
            int Iterateur = 1;

            while (Iterateur <= n)
            {
                Somme += Iterateur;
                Iterateur++;
            }

            Console.WriteLine("La somme des n entiers inférieurs ou égaux à n est : " + Somme);

            // permet de laisser la fenêtre de la console ouverte
            Console.ReadLine();
        }

    }
}
