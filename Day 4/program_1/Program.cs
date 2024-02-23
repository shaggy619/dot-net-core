using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Accessing Derived Class Lion

            Lion myLion = new Lion();
            myLion.Name = "Lion";
            myLion.Description = "wild";
            myLion.WhatItEats();
            myLion.SoundMade();

            //Accessing Derived Class Tiger

            Tiger myTiger = new Tiger();
            myTiger.Name = "Rocky";
            myTiger.Details();
            Console.ReadLine();
        }
    }
}
