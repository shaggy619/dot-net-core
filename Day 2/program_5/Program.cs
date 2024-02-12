using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***** DO WHILE LOOP *****/

            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();
            Console.Write("How many times you want to print: ");
            string repeatTimes = Console.ReadLine();
            int repeatTimesInt = Convert.ToInt32(repeatTimes);

            int i = 0;
            do
            {
                Console.WriteLine(name);
                i++;
            }
            while (i < repeatTimesInt);
            Console.ReadLine();
        }
    }
}
