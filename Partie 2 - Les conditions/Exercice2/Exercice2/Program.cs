using System;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {      
            Console.WriteLine("Entrer votre âge : ");
            int Age = Convert.ToInt32(Console.ReadLine());

            if (Age >= 18)
            {
                Console.WriteLine("Vous avez " + Age + ", vous êtes donc majeur.e");
            }
            else
            {
                Console.WriteLine("Vous avez " + Age + ", vous êtes donc mineur.e");
            }
        }
    }
}
