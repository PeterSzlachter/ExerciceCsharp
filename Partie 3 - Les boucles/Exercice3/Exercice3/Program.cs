using System;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            int number1;
            string wish;
         
                Console.WriteLine("Entrer un premier nombre :");
                result = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Voulez-vous entrer un deuxième nombre qui va s'ajouter au premier ?\noui\nnon");
                wish = Console.ReadLine();
            
            while (wish == "oui")
            { 
                Console.WriteLine("Entrer un nombre qui va s'additionner avec le précédent : ");
                number1 = Convert.ToInt32(Console.ReadLine());
                result = result + number1;
                Console.WriteLine($"Le résultat est {result}");
                Console.WriteLine("Voulez-vous continuer ?\noui\nnon");
                wish = Console.ReadLine();
            }                
        }
    }
}

/* Créer une variable result. Demander à l’utilisateur un nombre à additionner puis s’il veut ajouter un nombre. Tant que l’utilisateur ne répond pas non, redemander un nombre et l’ajouter au résultat.

Afficher le résultat dans une phrase. */