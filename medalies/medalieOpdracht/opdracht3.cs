using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medalieOpdracht
{
    internal class opdracht3
    {
        public void Start()
        {
            Console.WriteLine("Wat voor weer is het vandaag");
            Console.WriteLine("Zonnig, Regen, Bewolkt");
            string Weer = Console.ReadLine();
            if(Weer == "Zonnig")
            {
                Console.WriteLine("Het is zonnig hoeveel graaden is het?");
            }
            if (Weer == "Regen")
            {
                Console.WriteLine("Het regent hoeveel graaden is?");
            }
            if (Weer == "Bewolkt")
            {
                Console.WriteLine("Het is bewolkt hoeveel graaden is?");
            }
        }
    }
}
