using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
    abstract public class AreaClass
    {
        abstract public int Area();
    }
     public class  Square : AreaClass
    {
        int side = 0;
        public Square(int n)//Constructor
        {
            side = n;
        }
        public override int Area()
        {
            return side*side;
        }
    }
}
