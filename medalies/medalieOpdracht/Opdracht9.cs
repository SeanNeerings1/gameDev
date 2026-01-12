using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medalieOpdracht
{
    internal class Opdracht9
    {
        private string _name;
        private int _dmg;
        public Opdracht9(string name, int dmg)
        {
            _name = name;
            _dmg = dmg;
        }
        public void printWeaponInfo()
        {
            Console.WriteLine($"dit is een wapen met de naam: {_name} en hij doet {_dmg} punten aan dmg ");

        }
    }
}
