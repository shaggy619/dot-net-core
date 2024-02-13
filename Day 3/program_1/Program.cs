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
            /***** BREAK STATEMENT *****/

            for (int counter = 0; counter < 10; counter++)
            {
                if (counter == 5)
                {
                    break;
                }
                Console.WriteLine(counter);
            }

            Console.ReadLine();
        }
    }
}
