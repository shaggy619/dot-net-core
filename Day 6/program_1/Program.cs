using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***** PROGRAM TO ILLUSTRATE ABSTRACT CLASS IN C# *****/

            Wild wild = new Wild("Lion", "wild", 8);
            wild.WhatItEats(wild.Description);
            wild.Display();
            Console.ReadLine();
        }
    }
}
