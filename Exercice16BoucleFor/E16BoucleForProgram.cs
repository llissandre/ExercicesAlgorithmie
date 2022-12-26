using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice16bouclefor
{
    internal class E16boucleforProgram
    {
        static void Main(string[] args)
        {
            //on demande à l'utilisateur d'entrer la valeur de n
            Console.Write("Entrez la valeur de n : ");
            int n = int.Parse(Console.ReadLine());

            int Somme = 0;

            for (int Iterateur = 1; Iterateur <= n; Iterateur++)
            {
                Somme += Iterateur;
            }

            Console.WriteLine("La somme des n entiers inférieurs ou égaux à n est : " + Somme);

            // permet de laisser la fenêtre de la console ouverte
            Console.ReadLine();
        }
    }
}