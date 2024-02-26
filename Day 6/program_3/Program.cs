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
            /***** FIELD AND PROPERTIES IN C# *****/

            Animal myAnimal = new Animal("Lion", 2);
            myAnimal.Age = -10;
            myAnimal.DisplayInfo();
            Console.ReadLine();
        }
    }
}
