using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_3
{
    internal class Animal
    {
        //Fields

        private string name;
        private int age;

        //Property

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Property with validation 

        public int Age
        {
            get { return age; }
            set { if (value >= 0)
                {
                    age = value;
                }
                else
                    Console.WriteLine("Age cannot be a negative number.");
            }
        }

        public Animal(string animalName, int animalAge)
        {
            Name = animalName;
            Age = animalAge;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Name} is {Age} years old.");
        }

    }
}
