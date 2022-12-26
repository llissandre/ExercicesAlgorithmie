using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice19bouclefor
{
    internal class E19boucleforProgram
    {
        static int DemanderNombre(String Phrase)
        {
            Console.Write(Phrase);
            int N = int.Parse(Console.ReadLine());

            return N;
        }

        static long Fac(int N)
        {
            long Fac = 1;

            for (int Iterateur = 1; Iterateur <= N; Iterateur++)
            {
                Fac *= Iterateur;
            }
            return Fac;
        }
        static void Main(string[] args)
        {
            //on demande à l'utilisateur d'entrer la valeur de n
            int N = DemanderNombre("Entrez un nombre : ");
            long Fac1 = Fac(N);

            Console.WriteLine($"La factorielle de {N}! est : {Fac1}");

            // permet de laisser la fenêtre de la console ouverte
            Console.ReadLine();
        }
    }
}
