using program_3;
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
            /***** PASSING VARIABLE BY REFERENCE *****/

            Animal myAnimal = new Animal();
            myAnimal.Name = "Tiger";
            Console.WriteLine(myAnimal.Name);
           ChangeName(myAnimal);
            Console.WriteLine(myAnimal.Name); //Changes the actual value of the variable
            Console.ReadLine();
        }

        static void ChangeName(Animal newAnimal)
        {
            newAnimal.Name = "Cow"; 
            Console.WriteLine(newAnimal.Name);
        }
    }
}
