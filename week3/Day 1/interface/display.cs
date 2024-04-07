using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
  public interface  display
    {
        void print();
    }
    public class result:display
    {
        public void print()
        {
            Console.WriteLine("I am a Child class");
        }

    }
}
