using System;

namespace Exercice6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrer votre nom : ");
            string Name = Console.ReadLine();
            Console.WriteLine("Entrer votre prénom : ");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Entrer votre année de naissance : ");
            string DateBirth = Console.ReadLine();
            int Age = DateTime.Now.Year - Convert.ToInt32(DateBirth);
            
            Console.WriteLine("Fiche de renseignement :\n" + "*Nom : " + Name + "\n*Prénom : " + FirstName + "\n*Age : " + Age);
        }
    }
}
