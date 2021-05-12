using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
          // int sum = 0;
          // int number = 0;
            List<int> numbers = new List<int> { 1, 2, 3, 4 };

            /* for (int i = 0; i < numbers.Count; i++)
             {
                 sum += numbers[i];                               
                 Console.WriteLine($"Affichage de la somme boucle {i} : {number} + {numbers[i]} = {sum}" );
                 number = sum;
             }   */
            int sum = numbers.Sum();
            Console.WriteLine($"La somme est {sum}");

            string usedNumbers = String.Join(" + ", numbers);
            Console.WriteLine($"{usedNumbers} = {sum}");
        }
    }
}
/* Créer une liste numbers et la remplir de nombres au choix.

À l’aide d’une boucle, calculer la somme de tous les nombres de la liste.

Afficher le résultat dans une phrase.

Bonus : rappelez tous les nombres dans le calcul. */