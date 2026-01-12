using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medalieOpdracht
{
    internal class Program
    {
        private static string _name = "Sean";
        private static string _lastName = "neerings";
        private static int _age = 19;



        static void Main(string[] args)
        {
            //opdracht 1
            //opdracht1 test = new opdracht1();
            //test.Start();

            //opdracht 2
            //opdracht2 test1 = new opdracht2();
            //test1.Start();

            //opdracht 3
            //opdracht3 test2 = new opdracht3();
            //test2.Start();


            //opdracht 4
            //Opdracht4 test2 = new Opdracht4();
            //test2.Start();

            //opdracht5
            //Opdracht5 test2 = new Opdracht5();
            //test2.Start();

            //opdracht6
            //Opdracht6 test2 = new Opdracht6();
            //test2.Start();

            //opdracht7
            //Opdracht7 test2 = new Opdracht7();
            //test2.Start();


            //loops test1 = new loops();
            //test1.Start();

            //opdracht 2.5
            //Dictionary_opdracht test1 = new Dictionary_opdracht();
            //test1.Start();


            //List<Character> CharacterList = new List<Character>()
            //{
            //    new Character("Sean", 20),
            //    new Character("rayvano", 21)
            //};


            //foreach (Character character in CharacterList)
            //{
            //    character.printCharacterInfo();
            //}

            List<Opdracht9> WeaponList = new List<Opdracht9>()
            {
                new Opdracht9("Silvere prikker", 5),
                new Opdracht9("Goude prikker", 10)
            };


            foreach (Opdracht9 weapon in WeaponList)
            {
                weapon.printWeaponInfo();
            }




            //List<Car> carList = new List<Car>();
            //Car car1 = new Car("tt", "audi", 3);
            //carList.Add(car1);
            //Car car2 = new Car("Ibiza", "Seat", 5);
            //carList.Add(car2);


            //foreach (Car car in carList)
            //{
            //    car.printCarInfo();
            //}

        }

    }
}
