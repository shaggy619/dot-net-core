using program_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_3
{
    internal class Animal
    {
        public void Details()
        {
            Console.WriteLine("This is a tiger!");
        }
    }
}
 class Wild : Animal
{
    public new void Details()
    {
        Console.WriteLine("This is a Lion!");
    }

}
