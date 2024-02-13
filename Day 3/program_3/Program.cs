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
            /***** GOTO STATEMENT *****/

            int i = 0;

        // Define a label
        labelA:

            Console.WriteLine(i);

            i++;

            if (i < 5)
            {
                goto labelA; // Jump to the label
            }

            Console.Write("\nEnd of the loop!");
            Console.ReadLine();
        }
    }
}
