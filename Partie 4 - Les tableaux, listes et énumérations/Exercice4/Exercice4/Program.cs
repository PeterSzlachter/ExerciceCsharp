using System;
using System.Linq;
using System.Collections.Generic;

namespace CollecEX4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int number, result;
            string resp = "o";

            while (resp == "o")
            {
                Console.WriteLine("ajouter un nombre à multiplier : ");
                number = Convert.ToInt32(Console.ReadLine());
                numbers.Add(number);

                Console.WriteLine("voulez-vous ajouter un autre nombre à multipier ? O/N");
                resp = Console.ReadLine().ToLowerInvariant();

            }

            result = numbers.Aggregate(1, (x, y) => x * y);
            Console.WriteLine("le résultat est {0}", result);

            string usednb = string.Join("*", numbers);
            Console.WriteLine(usednb);
        }
    }
}



/* using System;
using System.Collections.Generic;

namespace Exercice4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> productList = new List<int>();
            int number = 0;
            int product = 1;
            int numberbis = 1;

            Console.WriteLine("Voulez-vous multiplier les nombres de votre choix ?\noui\nnon");
            string wish = Console.ReadLine();

            while (wish == "oui")
            {               
                Console.WriteLine("Entrer combien de nombre tu veux multiplier :");
                int numberProduct = Convert.ToInt32(Console.ReadLine());
                
               for (int i = 1; i <= numberProduct; i++)
                    {                   
                    Console.WriteLine($"Nombre {i} :");
                    number = Convert.ToInt32(Console.ReadLine());
                    productList.Add(number);                   
                    }

                Console.WriteLine("Affichage de la liste de produit : ");

               for (int j = 0; j < productList.Count; j++)
                    {
                    Console.WriteLine(productList[j]);
                    }

               for (int k = 0; k < productList.Count ; k++)
                    {                   
                    product *= productList[k];
                    Console.WriteLine($"La multiplication est : {productList[k]} * {numberbis} = {product}");
                    numberbis = product;
                    }             

                Console.WriteLine("Recommencer ?\noui\nnon");
                productList.RemoveRange(0, productList.Count); // Supprime la liste de l'action précédente de l'index 0 à la taille du tableau
                numberbis = 1; // On remet la variable à 1.
                product = 1; // On remet la variable à 1, sinon elle garde la valeur de l'action précédente
                wish = Console.ReadLine();
            }            
        }
    }
}
À l’aide d’une boucle, demander à l’utilisateur les nombres qu’il souhaite multiplier. Les stocker dans une LISTE.

Calculer le résultat de la multiplication et l’afficher en rappelant tous les nombres. */
