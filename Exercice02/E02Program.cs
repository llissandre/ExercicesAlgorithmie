using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    internal class E02Program
    {
        static void Main(string[] args)
        {
            //affiche sur la console : "Rentrer un nombre:"
            Console.WriteLine("Rentrez un nombre :");

            //récupère le nombre donné par l'utilisateur et le range dans
            //la variable N
            String N = Console.ReadLine();

            //parse la chaine de caractère "N" en un entier "Nombre"
            int Nombre = int.Parse(N);

            //affiche sur la console : "Le résultat du calcul est : " suivi
            //de l'opération de la variable multipliée trois fois par elle-
            //même
            Console.WriteLine("Le résultat du calcul est : " + Nombre * Nombre * Nombre);

            //permet de laisser la fenêtre de la console ouverte
            Console.ReadLine();
        }
    }
}
