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
            /***** PASSING VARIABLE BY VALUE *****/

            Animal myAnimal = new Animal();
            myAnimal.Age = 8;
            Console.WriteLine(myAnimal.Age);
            ChangeAge(myAnimal.Age);
            Console.WriteLine(myAnimal.Age); //Doesn't change the actual value of the varialbe
            Console.ReadLine();
        }

        static void ChangeAge (int age) {
            age = 10;
            Console.WriteLine(age);
        }
    }
}
