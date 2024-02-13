using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace program_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***** BREAK STATEMENT *****/

            for (int counter = 0; counter < 10; counter++)
            {     
                if (counter == 5)
                {
                    break;
                }

                Console.WriteLine(counter);
            }

            /***** Accessing Class *****/
            //Animal myAnimal = new Animal();
            //myAnimal.Name = "Lion";
            //myAnimal.Description = "wild";
            //myAnimal.WhatItEats(myAnimal.Description);
            //Console.ReadLine();
            luckyNumbers();

            
        }

        static void luckyNumbers() {
            //int[] luckyNumbers = { 7, 8, 17, 80 };
            //foreach (int numbers in luckyNumbers)
            //{
            //    Console.WriteLine(numbers);
            //}

            int[,] pixels ={ { 1, 2, 3 }, { 0, 1, 2 }, { 2, 3, 4 }, { 3, 4, 5} };

            Console.ReadLine();
        }
    }
}
