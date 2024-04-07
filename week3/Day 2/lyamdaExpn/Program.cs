using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lyamdaExpn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list = GetList();
            List<string> list1 = new List<string>();
            list1 = Contain("e", list);
            List<string> list2 = new List<string>();
            list2 = Equals("centric", list);
            List<string> list3 = new List<string>();
            list3 = StartWith("com", list);
            Console.WriteLine("Following are the available lists:");
            foreach (string subname in list)
            {
                Console.WriteLine($"{subname}");
                 
            }
            Console.WriteLine("String Containing 'e' are:");
            foreach (string subname in list1)
            {
                Console.WriteLine($"{subname}");

            }
            Console.WriteLine("String equals to 'centric' are:");
            foreach (string subname in list2)
            {
                Console.WriteLine($"{subname}");

            }
            Console.WriteLine("String that starts with 'com' are:");
            foreach (string subname in list3)
            {
                Console.WriteLine($"{subname}");

            }
            Console.ReadKey();
        }
        static List<string> GetList()
        {
            List<string> list = new List<string>();
            list.Add("Net");
            list.Add("Centric");
            list.Add("Computing");
            list.Add("NET");
            list.Add("CENTRIC");
            list.Add("COMPUTING");
            list.Add("net");
            list.Add("centric");
            list.Add("computing");
            list.Add("nET");
            list.Add("cENtric");
            list.Add("cOMPUTING");
            return list;
        }
        //Contains
        static List<string> Contain(string subname,List<string> list)
        {
            return list.Where(sub => sub.ToUpper().Contains(subname.ToUpper())).ToList();
        }
        //Equal to
        static List<string> Equals(string subname, List<string> list)
        {
            return list.Where(sub => sub.ToUpper() == subname.ToUpper()).ToList();
        }
        //starts with
        static List<string>StartWith(string subname,List<string> list)
        {
            return list.Where(sub => sub.ToUpper().StartsWith(subname.ToUpper())).ToList();
        }
    }
}



