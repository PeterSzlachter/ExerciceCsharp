using System;

namespace Exercice4
{
    class Program
    {
        static void Main(string[] args)
        {
            const string login = "Peter";
            const string password = "Szlachter";
            // int success = 0;

            Console.WriteLine("Entrer votre login : ");
            string enterLogin = Console.ReadLine();

            Console.WriteLine("Entrer votre password : ");
            string enterPassword = Console.ReadLine();

            /* if (login == "Peter" && password == "Szlachter")
            {success = 1; } */
             
            switch (enterLogin, enterPassword)
            {
                default :
                    Console.WriteLine("Mauvais identifiant ou mauvais mot de passe.");
                    break;

                case (login, password):
                    Console.WriteLine("Votre identifiant est " + login);
                    Console.WriteLine("Votre password est " + password);
                    Console.WriteLine("Bienvenue à la Manu");
                    break;
            }            
        }
    }
}
