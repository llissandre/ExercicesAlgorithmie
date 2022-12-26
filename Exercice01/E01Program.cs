using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    internal class E01Program
    {
        static void Main(string[] args)
        {
            // affiche sur la console : "rentrer un nom"
            Console.WriteLine("Rentrez un nom :");

            // récupère le nom donné par l'utilisateur et le range dans la 
            // variable Nom
            String Nom = Console.ReadLine();

            // affiche sur la console : "Bonjour" suivi de la valeur de la 
            // variable Nom
            Console.WriteLine("Bonjour " + Nom);

            //permet de laisser la fenêtre de la console ouverte
            Console.ReadLine();
        }
    }
}
