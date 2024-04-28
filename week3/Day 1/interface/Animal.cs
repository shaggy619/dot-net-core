using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  @interface
{
    public interface   Animal
    {
          void WhatItEats();
    }
    public interface Animals { }
    public  class WildAnimal : Animal,Animals
    {
        public void WhatItEats()
        {
            Console.WriteLine("WildAnimals eat flesh.");
        }
    }
   
}
