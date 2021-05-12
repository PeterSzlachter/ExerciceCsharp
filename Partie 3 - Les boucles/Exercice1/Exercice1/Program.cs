using System;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 10) // C'est mieux avec une boucle for !!
            {
                Console.WriteLine("Bonjour, je ne suis qu'un simple message." + i);
                i++;
            }
        }
    }
}

/* Afficher 10 fois le message suivant dans la console :

« Bonjour, je ne suis qu'un simple message. » */