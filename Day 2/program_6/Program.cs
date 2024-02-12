using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***** FOREACH LOOP IN C# *****/

            string[] rappers = { "Joyner Lucas", "Eminem", "Travis Scott", "21 Savage", "2pac" };
            foreach (string rapper in rappers) //foreach loop is used to iterate over elements in a collection, such as an array, list, or any other enumerable type. 
            {
                Console.WriteLine(rapper);
            }
            Console.ReadLine();
        }
    }
}
