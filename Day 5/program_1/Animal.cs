using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_1
{
    internal class Animal
    {
        /***** CONSTRUCTOR IN C# *****/

        public string Name { get; set; }
        public string Description { get; set; }

        public Animal() {
            Name = "Dummy Animal"; // Sets the default value to this when we do not set name of the animal.
            Description = "Dummy Description";
        }

        public Animal(string name, string details) { 
        
            Name = name;
            Description = details;
        }

        public void DisplayDetails() {
            Console.WriteLine($"{Name} is a {Description} animal.");
        }

    }
}
