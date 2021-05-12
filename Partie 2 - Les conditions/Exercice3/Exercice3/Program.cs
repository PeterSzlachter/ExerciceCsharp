using System;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrer votre âge : ");
            int Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entrer votre Sexe : h ou f ");
            string Sexe = Console.ReadLine();

            if (Age >= 18 && Sexe == "h")
            {
                Console.WriteLine("Vous êtes un homme et vous êtes majeur");
            }

            else if (Age >= 18 && Sexe == "f")
            {
                Console.WriteLine("Vous êtes une femme et vous êtes majeure");
            }
            else if (Age <= 18 && Sexe == "h")
            {
                Console.WriteLine("Vous êtes un homme et vous êtes mineur");
            }
            else if (Age <= 18 && Sexe == "f")
            {
                Console.WriteLine("Vous êtes une femme et vous êtes mineure");
            }
        }
    }
}
