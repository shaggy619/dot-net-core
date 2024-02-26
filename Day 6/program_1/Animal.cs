using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    abstract public class Animal
    {

        // Abstract method without implementation
        abstract public void WhatItEats(string description);

        // Concrete method with implementation
        public void Display() {
            Console.WriteLine("\n\n***Program executed successfully!***");
        }
    }
    public class Wild : Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }

        public Wild(string name, string description, int age)
        {
            Name = name;
            Description = description;
            Age = age;
        }
        public override void WhatItEats(string description)
        {
            Console.WriteLine($"{Name} is {Age} years old.");
            if (description == "pet")
            {
                Console.WriteLine("It eats grass");
            }
            else
            {
                Console.WriteLine("It eats flesh");
            }
        }
    }
}

