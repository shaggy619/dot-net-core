using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhetitance.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal animal1 = new Animal();
            //animal1.Name = "lion";
            //animal1.Description = "wild";
            //animal1.WhatItEats(animal1.Description);

            WildAnimal wa1 = new WildAnimal();
            wa1.Name = "lion";
            wa1.Description = "wild";
            wa1.WhatItEats(wa1.Description);
            wa1.WhereItLives(wa1.Description);
            Console.ReadLine();

        }
    }
}
