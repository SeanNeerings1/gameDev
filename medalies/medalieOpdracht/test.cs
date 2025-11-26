using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medalieOpdracht

{
    
    internal class test
    {
        public void Start()
        {
            Console.WriteLine(CheckForPositiveNumber(4));
            Console.WriteLine(Multi(4, 2));
            Console.WriteLine(Smile("Sean"));


        }
        private bool CheckForPositiveNumber(int Number)
        {
            return Number > 0;

        }

        private int Multi(int Som1, int Som2)
        {
            return Som1 + Som2;
        }

        private string Smile(string Name)
        {
            return Name + ":)";
        }
    }
}
