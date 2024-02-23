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
            Animal myAnimal = new Animal("Tiger", "Wild");
            Console.WriteLine(myAnimal.Name);
            myAnimal.DisplayDetails();
            Console.ReadLine();
        }
    }
}
