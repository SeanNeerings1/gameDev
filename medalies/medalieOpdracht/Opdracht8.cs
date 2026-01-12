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
        private int _hp;
        public Character(string name, int lvl, int hp)
        {
            _name = name;
            _lvl = lvl;
            _hp = hp;
        }
        public void printCharacterInfo()
        {
            Console.WriteLine($"dit is een player met de naam: {_name} en hij is lvl {_lvl} en hij heeft {_hp} levens punten");

        }
    }
}