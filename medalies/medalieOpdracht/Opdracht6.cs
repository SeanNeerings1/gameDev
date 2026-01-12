using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medalieOpdracht
{
    internal class Opdracht6
    {
        public void Start()
        {
            Random random = new Random();
            int maxNumber;
            int guessTheNumber;
            int atempts = 0;


            while (true)
            {
                Console.Write("Geef een maximum getal op: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out maxNumber) && maxNumber > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Voer een geldig nummer groter dan 0 in.");
                }
            }
            guessTheNumber = random.Next(1, maxNumber + 1);

            Console.WriteLine($"\nIk heb een getal gekozen tussen 1 en {maxNumber}.");

            while (true)
            {
                Console.WriteLine("raad het getal:");
                string guessInput = Console.ReadLine();

                if (!int.TryParse(guessInput, out int guess))
                {
                    Console.WriteLine("dat is een geldig nummer.");
                    continue;
                }

                atempts++;
                if (guess < guessTheNumber)
                {
                    Console.WriteLine("hoger!");
                }else if (guess > guessTheNumber)
                {
                    Console.WriteLine("lager");
                }
                else
                {
                    Console.WriteLine($"Je hebt gewonnen het nummer was {guessTheNumber}");
                    Console.WriteLine($"je had {atempts} poginen gedaan");
                    break;
                }

            }
        }

    }
}
