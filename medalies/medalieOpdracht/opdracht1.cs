using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medalieOpdracht
{
    internal class opdracht1
    {
        public void Start()
        {
            Console.WriteLine("Wat is jouw naam?");
            string naam = Console.ReadLine();
            Console.WriteLine("wat is jouw leeftijd");
            String leeftijd = Console.ReadLine();
            Console.WriteLine("hoi " + naam + ", je bent " + leeftijd + " jaar oud!");
        }
    }
}