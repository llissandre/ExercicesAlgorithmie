const int Nombredevaleur1 = 4;
const int Nombredevaleur2 = 2;

int[] Tableau1 = { 4, 8, 7, 12 };
int[] Tableau2 = { 3, 6 };
int Produit = 0;
int Schtroumpf = 0;

for (int Iterateur1 = 0; Iterateur1 < Nombredevaleur1; Iterateur1++)
{
    int Iterateur2 = 0;
    if (Iterateur1 == Nombredevaleur1)
    {
        Iterateur2++;
    }
    Produit = Tableau1[Iterateur1] * Tableau2[Iterateur2];
    Schtroumpf += Produit;
}

Console.WriteLine(Schtroumpf);