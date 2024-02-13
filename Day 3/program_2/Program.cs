using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***** CONTINUE STATEMENT *****/

            for (int counter = 0; counter < 10; counter++)
            {
                if (counter == 5)
                {
                    continue;
                }
                Console.WriteLine(counter);
            }

            Console.ReadLine(); 

        }
    }
}
