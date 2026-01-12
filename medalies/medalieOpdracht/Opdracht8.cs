using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medalieOpdracht
{
    internal class Character
    {
        private string _name;
        private int _lvl;
        public Character(string name, int lvl)
        {
            _name = name;
            _lvl = lvl;
        }
        public void printCharacterInfo()
        {
            Console.WriteLine($"dit is een player met de naam: {_name} en hij is lvl {_lvl} ");

        }
    }
}