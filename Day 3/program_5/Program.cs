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
            /***** ACCESSING ARRAY ITEMS IN C# *****/

            luckyNumbers();
            Console.ReadLine(); 
        }

        static void luckyNumbers()
        {
            int[] luckyNumbers = { 3, 7, 8, 80 };
            foreach (int numbers in luckyNumbers)
            {
                Console.WriteLine(numbers);
            }
        }
    }
}
