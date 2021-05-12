using System;

namespace Exercice4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); // random est une instance de l'objet Random
            int number = random.Next(1, 50);
            int numberFound;
            int compteur = 0;

            Console.WriteLine("Deviner le nombre gènèré aléatoirement entre 1 et 50 :" + number);
            numberFound = Convert.ToInt32(Console.ReadLine());
                                
            while (numberFound != number) // Do while est possible ici.
            {
                if (numberFound > number)
                {
                    Console.WriteLine("C'est plus petit");
                    compteur++;
                    Console.WriteLine("Tentative numéro :" + compteur);
                    numberFound = Convert.ToInt32(Console.ReadLine());
                }
                else /* if (numberFound < number) */
                {
                    Console.WriteLine("C'est plus grand");
                    compteur++;
                    Console.WriteLine("Tentative numéro :" + compteur);
                    numberFound = Convert.ToInt32(Console.ReadLine());
                }              
            }
            compteur++;
            Console.WriteLine($"Bravo ! Vous avez trouvé(e) en {compteur} tentative(s)");
        }
    }
}

/* Définir un nombre en 1 et 50. Demander à l’utilisateur de deviner ce nombre. Si la réponse est supérieure au nombre, afficher « C’est plus petit », si la réponse est inférieure au nombre, afficher « C’est plus grand ».

Si l’utilisateur trouve la bonne réponse, afficher « Bravo vous avez trouvé ! »

Bonus 1 : Le nombre défini au départ est aléatoire.

Bonus 2 : Vous affichez le nombre de tentatives. */ 