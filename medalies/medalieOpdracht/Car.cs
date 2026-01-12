using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medalieOpdracht
{
    internal class Car
    {
        
            private string _name;
            private string _brand;
            private int _amountOfDoors;

        public Car(string name, string brand, int amountOfDoors)
        {
            _name = name;
            _brand = brand;
            _amountOfDoors = amountOfDoors;
        }

        public void printCarInfo()
        {
            Console.WriteLine($"auto naam: {_name} en merk {_brand}");
        }

    }
}
