﻿
int DemanderNombre(String Phrase)
{
    Console.Write(Phrase);
    int N = int.Parse(Console.ReadLine());
    return N;
}

long Factorielle(int N)
{
    if (N == 0 || N == 1) { return 1; }
    else { return N * Factorielle(N - 1); }
}

//on demande à l'utilisateur d'entrer la valeur de n
int N = DemanderNombre("Entrez un nombre : ");
long Fac1 = Factorielle(N);

Console.WriteLine($"La factorielle de {N}! est : {Fac1}");

// permet de laisser la fenêtre de la console ouverte
Console.ReadLine();