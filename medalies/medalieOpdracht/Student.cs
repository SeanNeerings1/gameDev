using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace medalieOpdracht
{
    internal class Student
    {
        private string _name;
        private int _age;
        private string _lastName;
        public Student(string name, int age, string lastName)
        {
            _name = name;
            _age = age;
            _lastName = lastName;
        }

        public void Student_description()
        {

            Console.WriteLine($"dit is een student met de naam: {_name} {_lastName} en hij is {_age} jaar oud");
        }
    }
    }
