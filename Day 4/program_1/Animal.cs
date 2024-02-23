using program_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace program_1
    
    /***** BASE CLASS *****/
{
    public class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public void WhatItEats() { 
        
           if (Description == "wild")
            {
                Console.WriteLine($"{Name} eats flesh.");
            }
            else
            {
                Console.WriteLine($"{Name} eats grass.");
            }
        }
    }
}

/***** DERIVED CLASS LION *****/
class Lion : Animal
{
    public void SoundMade()
    {
        if (Name == "Tiger" | Name == "Lion")
        {
            Console.WriteLine($"{Name} roars!");
        }
        else
        {
            Console.WriteLine("Sorry the information is not stored in database!");
        }
    }
}

/***** DERIVED CLASS TIGER *****/
class Tiger : Animal
{
    public void Details()
    {
        Console.WriteLine($"{Name} is a tiger!");
    }
}
