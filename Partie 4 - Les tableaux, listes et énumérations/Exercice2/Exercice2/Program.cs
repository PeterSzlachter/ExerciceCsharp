using System;
using System.Collections.Generic;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
           List<string> languages = new List<string> { "HTML", "CSS", "Javacrit", "jQuery", "PHP", "Bootstrap", "Java" };
            Console.WriteLine("Affichage de la liste de départ : ");

            for (int i = 0; i < languages.Count; i++)
            {
                Console.WriteLine(languages[i]);
            }

            /*foreach (string lang in languages)
            {
                Console.WriteLine(lang);
            } */

            Console.WriteLine("Affichage du 4e élément de la liste : " + languages[3]);
            Console.WriteLine("Affichage de l'index 4 de la liste : " + languages[4]);
            languages.Remove("Bootstrap");
            // languages[2] = "Javascript";
            int index = languages.IndexOf("Javacrit");
            languages[index] = "Javascript";
            languages.Add("C");
            Console.WriteLine("Affichage de la liste de fin : ");
            for (int i = 0; i < languages.Count; i++)
            {
                
                Console.WriteLine(languages[i]);
            }
        }
    }
}

/*
Créer une liste languages contenant les éléments suivants :
HTML
CSS
Javacrit
jQuery
PHP
Bootstrap
Java
Afficher toute la liste.
Afficher le 4ème élément de la liste.
Afficher l’élément à l’index 4 de la liste.
Supprimer Bootstrap de la liste.
Modifier Javacrit en Javascript.
Ajouter C dans la liste.
Afficher la liste */ 