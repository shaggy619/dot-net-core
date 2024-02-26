using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_4
{
    internal interface Animal
    {
        string Name { get; set; }

        string Description { get; set; }

        void WhatItEats();
    }

    internal interface Vertebrate
    {
        string Type { get; set; }

        void WhereItLives();
    }

    internal class WildAnimal : Animal, Vertebrate
    {
        public WildAnimal(string name, string description, string type)
        {
            Name = name;
            Description = description;
            Type = type;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public void WhereItLives()
        {
            if (Type == "wild")
                Console.WriteLine($"{ Name} lives in jungle.");
            else
                Console.WriteLine($"{Name} lives at home.");
        }
        public void WhatItEats()
        {
            if (Description == "herbivorous")
                Console.WriteLine($"{Name} eats grass.");
            else if (Description == "carnivorous")
                Console.WriteLine($"{Name} eats flesh.");
            else
                Console.WriteLine($"{Name} eats both grass and flesh.");
        }
    }
}
