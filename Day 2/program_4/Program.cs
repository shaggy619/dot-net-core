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
            /***** WHILE LOOP IN C# *****/

            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();
            Console.Write("How many times you want to print: ");
            string repeatTimes = Console.ReadLine();
            int repeatTimesInt = Convert.ToInt32(repeatTimes);

            int i = 0;
            while (i < repeatTimesInt)
            {
                Console.WriteLine(name);
                i++;
            }
            Console.ReadLine();
        }
    }
}
