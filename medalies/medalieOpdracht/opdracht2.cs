using System;
using System.Collections.Generic;
using System.Linq;

namespace medalieOpdracht
{
    internal class opdracht2
    {
        private readonly Dictionary<string, string[]> Rooms =
            new Dictionary<string, string[]>
            {
                { "woonkamer", new[] { "gang", "keuken", "trapkast" } },
                { "gang",      new[] { "woonkamer", "trap", "wc" } },
                { "keuken",    new[] { "woonkamer", "buiten" } },
                { "trapkast",  new[] { "woonkamer" } },
                { "trap",      new[] { "gang", "bovengang" } },
                { "wc",        new[] { "gang" } },
                { "bovengang", Array.Empty<string>() },
                { "buiten",    Array.Empty<string>() }
            };

        public void Start()
        {
            Console.WriteLine("ontsnap het huis");

            string CurrentRoom = AskRoom(
                "welke kamer wil je betreden?",
                new[] { "woonkamer", "gang", "keuken" }
            );

            int steps = 1;

            while (steps < 3 && CurrentRoom != "buiten")
            {
                Console.WriteLine($"je bent nu in de {CurrentRoom}");

                if (!Rooms.ContainsKey(CurrentRoom) ||
                    Rooms[CurrentRoom].Length == 0)
                {
                    break;
                }

                string[] PossibleRooms = Rooms[CurrentRoom];

                CurrentRoom = AskRoom(
                    "welke kamer wil je nu betreden?",
                    PossibleRooms
                );

                steps++;
            }

            if (CurrentRoom == "buiten")
            {
                Console.WriteLine("je bent buiten!");
                Console.WriteLine("je hebt gewonnen!");
            }
            else
            {
                Console.WriteLine($"je bent nu in de {CurrentRoom}");
                Console.WriteLine("je hebt verloren!");
            }
        }
        private string AskRoom(string vraag, string[] LegalRoom)
        {
            Console.WriteLine(vraag);
            Console.WriteLine(string.Join(", ", LegalRoom));

            string input = Console.ReadLine();

            while (!LegalRoom.Contains(input))
            {
                Console.WriteLine("Kies een geldige kamer: " + string.Join(", ", LegalRoom));
                input = Console.ReadLine();
            }

            return input;
        }
    }
}
