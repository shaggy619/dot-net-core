using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***** BASIC PROGRAM TO READ KEY FROM USER AND DISPLAY IT IN CONSOLE *****/

            Console.Write("Enter any key: "); // Prints the value on the console without line break
            ConsoleKeyInfo keyInfo = Console.ReadKey();  // Read the key from the user
            Console.WriteLine("\nYou pressed the key: " + keyInfo.KeyChar); // Change the key to char and display the pressed key
            Console.ReadKey(); //Pause the program and wait for the user to press ANY KEY before closing the console window
        }
    }
}
