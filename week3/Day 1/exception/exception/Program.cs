using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            int x = 0;
            int div;

            try
            {
                age = Convert.ToInt32("26");
                Console.WriteLine(age);
                div = 100 / x;
                Console.WriteLine(div);
            }

            catch (FormatException)
            {
                Console.WriteLine("Input is not in current format");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Attempt to divide by zero");
            }
            catch (Exception ex)//general case
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("Finally Block");
            }

            Console.ReadKey();
        }
    }
}
