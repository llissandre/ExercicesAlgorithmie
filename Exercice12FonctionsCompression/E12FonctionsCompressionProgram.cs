//12.Compression
//Ecrire et tester une fonction de compression.
//On remplace plusieurs caractères consécutifs de la manière suivante :

//AAAaa-- > 3A2a
//ABC --> ABC
//AAAAABBBCC --> 5A3B2C


//Console.Write("Entrez une série de caractères : ");
//string Texte = Console.ReadLine();
//Compression(Texte);

////string Chaine1 = "AAaDDfffF";


Console.Write("Entrez une série de caractères : ");
string Texte = Console.ReadLine();

string Chaine2 = "";
int It2 = 1;

for (int It1 = 1; It1 < Texte.Length; It1++)
{
    if (Texte[It1] == Texte[It1 - 1])
    {
        It2++;
    }

    else if ((Texte[It1] != Texte[It1 - 1]) || (Texte.Length == 1))
    {
        Chaine2 += It2;
        Chaine2 += Texte[It1 - 1];
        It2 = 1;
    }
}
Console.WriteLine("La compression du texte saisi est : " + Chaine2);
