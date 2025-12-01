using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medalieOpdracht
{
    internal class Dictionary_opdracht
    {
        private readonly Dictionary<string, string[]> Translate =
            new Dictionary<string, string[]>
            {
                { "woordenboek", new[] { "dictionary", "Wörterbuch" } },
                { "steen", new[] { "rock", "Felsen" } },
                { "hoofd", new[] { "head", "Kopf" } },
            };
        public void Start()
        {
            Console.WriteLine(Translate["woordenboek"][0]);
        }


    }
}
