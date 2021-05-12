using System;

namespace Exercice6
{

    class Program
    {
        enum WeekDay { Lundi, Mardi, Mercredi, Jeudi, Vendredi, Samedi, Dimanche };

        static void Main(string[] args)
        {
            /* for (int i = 0; i <= 6 ; i++)
            { 
                Console.WriteLine((WeekDay)i);             
            } */

            foreach (string day in Enum.GetNames(typeof(WeekDay)))

            { Console.WriteLine(day); }
           
            WeekDay dayFour = WeekDay.Vendredi; // Méthode 1
            Console.WriteLine(dayFour); // Méthode 1

            Console.WriteLine((WeekDay)4); // Méthode 2

            Console.WriteLine(Enum.GetName(typeof(WeekDay), 4)); // Méthode 3

            Console.WriteLine(Enum.GetNames(typeof(WeekDay)).GetValue(4)); // Méthode 4
        }
    }
}
