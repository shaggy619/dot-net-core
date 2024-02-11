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
            /***** BASIC PROGRAM TO TAKE NUMBERS AS INPUT AND PERFORM ADDITION *****/

            Console.Write("Enter first number: ");
            string a = Console.ReadLine();
            Console.Write("Enter second number: ");
            string b = Console.ReadLine();
            int add = Convert.ToInt32(a) + Convert.ToInt32(b); // C# reads user input as a string so we need to change string to int using "Convert.ToInt32(stringName)"
            Console.WriteLine("The sum is " + add);
            Console.ReadLine();
        }
    }
}
