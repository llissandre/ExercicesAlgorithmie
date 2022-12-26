//Ecrire une procédure pour dire bonjour à une personne.
//Le nom de la personne sera passé en paramètre.
//L'affichage se fera à la console.

//Tester l'appel de la procédure dans un Main.

string DireBonjour(string Prenom, string Nom)
{
    Console.WriteLine($"Bonjour {Prenom} {Nom} !");
    return Console.ReadLine();
}

string DemanderPrenomNom(string Phrase)
{
    Console.Write(Phrase);
    return Console.ReadLine();
}

string Prenom = DemanderPrenomNom("Écris ton Prénom : ");
string Nom = DemanderPrenomNom("Écris ton Nom : ");

DireBonjour(Prenom, Nom);