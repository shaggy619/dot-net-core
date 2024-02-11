using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***** BASIC PROGRAM TO TAKE INPUT FROM USER AND PRINT IT *****/

            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine(); // Take input from user and store it in variable named 'name'
            Console.WriteLine("Hi, " +  name + "!");
            Console.ReadLine();
        }
    }
}
