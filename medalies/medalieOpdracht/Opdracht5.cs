using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medalieOpdracht
{
    internal class Opdracht5
    {
        public void Start()
        {
            Console.WriteLine("Welke tafel weill je berekenen");
            int Tabel = int.Parse(Console.ReadLine());
            Console.WriteLine("hoe vaak will je deze berekenen");
            int Tafel = int.Parse(Console.ReadLine());
            for (int i = 1; i < Tafel + 1; i++)
            {
                Console.WriteLine(Tabel * i);
            }

        }

    }
}
