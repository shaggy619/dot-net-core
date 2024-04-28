using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();
            List<string> list1= new List<string>();
            List<string> list2 = new List<string>();
            List<string> list3 = new List<string>();
            list = getList();
            list1 = Contain("in",list);
            list2 = Equals("net", list);
            list3 = StartWith("ce", list);

            Console.WriteLine("Following are the available string:");
            foreach (string subname in list)
            {
                Console.WriteLine(subname);
            }
            Console.WriteLine("String which  contains  'in' are:");
            foreach (string subname in list1)
            {
                Console.WriteLine(subname);
            }
            Console.WriteLine("String which is Equals to 'net' are:");
            foreach (string subname in list2)
            {

                Console.WriteLine(subname);
            }
            Console.WriteLine("String which  starts with  'ce' are:");
            foreach (string subname in list3)
            {
                Console.WriteLine(subname);
            }
            Console.ReadKey();
        }
        public static List<string> getList()
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
             static List<string> Contain(string subname, List<string> list)
            {
                return (from subject in list where subject.ToUpper().Contains(subname.ToUpper()) select subject).ToList();

            }
            //starts with
           static List<string> StartWith(string subname, List<string> list)
            {
                return (from subject in list where subject.ToUpper().StartsWith(subname.ToUpper()) select subject).ToList();
            }
            //Equal to
             static List<string> Equals(string subname, List<string> list)
            {
                return (from subject in list where subject.ToUpper() == subname.ToUpper() select subject).ToList();
            }
        
    }
}
