 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhetitance.cs
{
    public class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string NameWithDescription { get; set; }
        public void WhatItEats(string Description)
        {
            NameWithDescription= Name+" is a "+Description +" animal.";
            Console.WriteLine(NameWithDescription);
            if (Description == "domestic")
            {
                Console.WriteLine(Name +" eats Grass.");
            }
            else
            {
                Console.WriteLine( Name +" eats flesh");
            }
        }
    }
    public class WildAnimal:Animal
    {
        public bool Veg { get; set; }  
        public string Food { get; set; }
        public void WhereItLives(string Description)
        {
            Console.WriteLine( Name +" lives in Jungle");
        }
    }
}
