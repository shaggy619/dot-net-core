using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square s1 = new Square(6);
            Console.WriteLine("Area of square:"+s1.Area());
            Console.ReadKey();
        }
    }
}
