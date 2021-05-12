using System;

namespace Exercice5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Entrer votre nom : ");
            string Name = Console.ReadLine();
            Console.WriteLine("Entrer votre prénom : ");
            string FirstName = Console.ReadLine();
            string Date = DateTime.Now.ToLongDateString();
            Console.WriteLine("Bonjour " + Name + " " + FirstName + " nous sommes le " + Date + ", comment allez-vous ?");
        }
    }
}
