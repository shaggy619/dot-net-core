using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***** INTERFACE IN C# *****/

            WildAnimal wildAnimal = new WildAnimal("Lion", "carnivorous", "wild");
            wildAnimal.WhatItEats();
            wildAnimal.WhereItLives();
            Console.ReadLine();
        }
    }
}
