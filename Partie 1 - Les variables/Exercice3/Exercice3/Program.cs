using System;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string number1;
            string number2; */

            Console.WriteLine("Entrer deux nombres au choix : ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Voici le nombre 1 : " + number1 + " Voici le nombre 2 : " + number2);

            number1 = number1 + 33;
            number2++;

            Console.WriteLine("Nombre 1 est maintenant : " + number1 + " Nombre 2 est maintenant : " + number2);

            Decimal number3 = Convert.ToDecimal(number1) / Convert.ToDecimal(number2);

            Console.WriteLine("Le résultat de la divion du nombre 1 et du nombre 2 est : " + number3);


        }
    }
}
