using System;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1 = 10;
            Console.WriteLine(number1);

            int number2 = 20;
            Console.WriteLine(number2);

            int number3 = 40;
            Console.WriteLine(number3);

            Console.WriteLine("Le résultat de l'addition des deux premiers nombres : " + (number1 + number2));

            int number4 = number1 + number2;
            Console.WriteLine("Le résultat de la multiplication est : " + (number4 * number3));
        }
    }
}
