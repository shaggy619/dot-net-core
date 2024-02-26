using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***** EXCEPTION HANDLING IN C# *****/

            string age = "aa";

            try
            {
                Console.WriteLine(Convert.ToInt32(age));
            }

            catch (FormatException)
            {
                Console.WriteLine("Format Error!");
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Divide by Zero Exception");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Execution Completed!");
            }

            Console.ReadLine();
        }
    }
}