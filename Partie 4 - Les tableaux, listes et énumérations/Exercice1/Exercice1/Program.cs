using System;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = new string[] { "Lundi", "Mardi", "Mercredi", "Jedi", "Vendredi", "Samedi" };
            Console.WriteLine("Affichage de l'indice 1 : " + week[1] + "\nAffichage de l'indice 4 " + week[4]);
            Console.WriteLine("Affichage du 1er jour : " + week[0] + "\nAffichage du 4e jour : " + week[3]);
            week[3] = "Jeudi";
            Console.WriteLine("Affichage de la correction du 4e jour : " + week[3]);
            Array.Resize<string>(ref week, 7);
            week[6] = "Dimanche";
            Console.WriteLine("Ajout du 7e jour de la semaine : " + week[6]);
            foreach(string day in week) // Parcours le tableau sans prendre en compte la taille
            {
                Console.WriteLine(day);
            }
           /* for (int i = 0; i < week.Length ; i++)
            { Console.WriteLine("\n" + week[i]); } */
        }
    }
}
/*
Créer un tableau week contenant les jours :
Lundi
Mardi
Mercredi
Jedi (garder la faute)
Vendredi
Samedi
Afficher le contenu de l’indice 1 et 4 du tableau dans la console sur 2 lignes différentes. 
Afficher le contenu du 1er et du 4ᵉ élément du tableau dans la console sur 2 lignes différentes.
Corriger le 4ème jour.
Ajouter le 7ème jour.
Afficher le tableau dans la console. */