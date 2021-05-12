using System;

namespace Exercice5
{
    class Program
    {
        static void Main(string[] args)
        {
           // int season;
            
            Console.WriteLine("Renseinger le numéro du mois parmis les 12 disponibles : \n1 Janvier\n2 Fevrier\n3 Mars\n4 Avril\n5 Mai\n6 Juin\n7 Juillet\n8 Aout\n9 Septembre\n10 Octobre\n11 Novembre\n12 Decembre");

            int month = Convert.ToInt32(Console.ReadLine());

            switch(month)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("La saison du mois saisi est l'HIVER");
                    break;

                case 4:
                case 5:
                case 6:
                    Console.WriteLine("La saison du mois saisi est le PRINTEMPS");
                    break;

                case 7:
                case 8:
                case 9:
                    Console.WriteLine("La saison du mois saisi est l'ETE");
                    break;

                case 10:
                case 11:
                case 12:
                    Console.WriteLine("La saison du mois saisi est l'AUTONOMNE");
                    break;

                default:
                    Console.WriteLine("La saisie n'est pas correct.");
                    break;
            }
        }
    }
}

/* À l’aide de la console, inviter l’utilisateur à renseigner un mois parmi les 12 mois de disponibles.

Dans la console, selon le mois renseigné, afficher un des messages suivants :

« La saison du mois saisi est le PRINTEMPS. »
« La saison du mois saisi est l'ÉTÉ. »
« La saison du mois saisi est l'AUTOMNE. »
« La saison du mois saisi est l'HIVER. » */