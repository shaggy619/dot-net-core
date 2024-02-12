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
            /***** FOR LOOP IN C# *****/
            Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("How many times you want to print: ");
            string repeatTimes = Console.ReadLine();
            int repeatTimesInt = Convert.ToInt32(repeatTimes);

            for (int i = 0; i < repeatTimesInt; i++)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

        }
    }
}
