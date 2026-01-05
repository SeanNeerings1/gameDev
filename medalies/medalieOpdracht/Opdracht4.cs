using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medalieOpdracht
{
    internal class Opdracht4
    {

        static (bool isAdult, string voteMessage, int age) VotingAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;

            if (birthDate > today.AddYears(-age))
                age--;

            bool isAdult = age >= 18;
            string voteMessage = isAdult ? "Je mag stemmen." : "Je mag nog niet stemmen.";

            return (isAdult, voteMessage, age);
        }

        static void FunMsg(DateTime birthDate)
        {
            var result = VotingAge(birthDate);
            if(!result.isAdult)
            {
                Console.WriteLine("je bent onder de 18 dus je bent nog niet oud genoeg voor een catogorie");
            }
            if (result.age >=18 && result.age <= 25)
            {
                Console.WriteLine("Catagorie: Young adult - je bent nog jong dus blijf vooruit kijken");
            }else if (result.age > 25 && result.age <= 40)
            {
                Console.WriteLine("Catagorie: Volwassene - het is de tijd om je leven goed onder controle te hebben");
            }else if (result.age > 40)
            {
                Console.WriteLine("Catogorie ouder - mensen kunnen van je wijsheid leeren");
            }
            Console.WriteLine(result.voteMessage);
            Console.WriteLine($"Leeftijd: {result.age} jaar.");
        }

        public void Start()
        {
            Console.Write("Voer je geboortedatum in (yyyy-MM-dd): ");
            string input = Console.ReadLine();

            if (DateTime.TryParse(input, out DateTime birthDate))
            {
                FunMsg(birthDate);
            }
            else
            {
                Console.WriteLine("Ongeldige datum.");
            }
        }

    }
}
