using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medalieOpdracht
{
    internal class opdracht2
    {
        public void Start()
        {

            Console.WriteLine("ontsnap het huis");
            Console.WriteLine("welke kamer wil je betreden?");
            Console.WriteLine("woonkamer,gang,keuken");
            string eersteKamer = Console.ReadLine();
            if (eersteKamer == "woonkamer")
            {
                Console.WriteLine("je bent nu in de woonkamer");
                Console.WriteLine("welke kamer wil je nu betreden?");
                Console.WriteLine("gang, keuken, trapkast");

            }
            else if (eersteKamer == "gang")
            {
                Console.WriteLine("je bent nu in de gang");
                Console.WriteLine("welke kamer wil je nu betreden?");
                Console.WriteLine("woonkamer, trap, wc");
            }
            else if (eersteKamer == "keuken")
            {
                Console.WriteLine("je bent nu in de keuken");
                Console.WriteLine("welke kamer wil je nu betreden?");
                Console.WriteLine("woonkamer, buiten");
            }

            string tweedeKamer = Console.ReadLine();
            if (tweedeKamer == "woonkamer")
            {
                Console.WriteLine("je bent nu in de woonkamer");
                Console.WriteLine("welke kamer wil je nu betreden?");
                Console.WriteLine("gang, keuken, trapkast");

            }
            else if (tweedeKamer == "gang")
            {
                Console.WriteLine("je bent nu in de gang");
                Console.WriteLine("welke kamer wil je nu betreden?");
                Console.WriteLine("woonkamer, trap, wc");
            }
            else if (tweedeKamer == "keuken")
            {
                Console.WriteLine("je bent nu in de keuken");
                Console.WriteLine("welke kamer wil je nu betreden?");
                Console.WriteLine("woonkamer, buiten");
            }
            else if (tweedeKamer == "trapkast")
            {
                Console.WriteLine("je bent nu in de trapkast");
                Console.WriteLine("welke kamer wil je nu betreden?");
                Console.WriteLine("woonkamer");
            }
            else if (tweedeKamer == "trap")
            {
                Console.WriteLine("je bent nu op de trap");
                Console.WriteLine("welke kamer wil je nu betreden?");
                Console.WriteLine("gang,bovengang");
            }
            else if (tweedeKamer == "wc")
            {
                Console.WriteLine("je bent nu in de wc");
                Console.WriteLine("ga terug naar de gang");
            }
            else if (tweedeKamer == "buiten")
            {
                Console.WriteLine("je bent buiten!");
                Console.WriteLine("je hebt gewonnen!");
            }

            string derdeKamer = Console.ReadLine();
            if (derdeKamer == "woonkamer")
            {
                Console.WriteLine("je bent nu in de woonkamer");
                Console.WriteLine("je hebt verloren!");

            }
            else if (derdeKamer == "gang")
            {
                Console.WriteLine("je bent nu in de gang");
                Console.WriteLine("je hebt verloren!"); ;
            }
            else if (derdeKamer == "keuken")
            {
                Console.WriteLine("je bent nu in de keuken");
                Console.WriteLine("je hebt verloren!");
            }
            else if (derdeKamer == "trapkast")
            {
                Console.WriteLine("je bent nu in de trapkast");
                Console.WriteLine("je hebt verloren!");
            }
            else if (derdeKamer == "trap")
            {
                Console.WriteLine("je bent nu op de trap");
                Console.WriteLine("je hebt verloren!");
            }
            else if (derdeKamer == "wc")
            {
                Console.WriteLine("je bent nu in de wc");
                Console.WriteLine("je hebt verloren!");
            }
            else if (derdeKamer == "buiten")
            {
                Console.WriteLine("je bent buiten!");
                Console.WriteLine("je hebt gewonnen!");
            }
            else if (derdeKamer == "bovengang")
            {
                Console.WriteLine("je bent nu in de bovengang");
                Console.WriteLine("je hebt verloren!");
            }
        }
    }
}
