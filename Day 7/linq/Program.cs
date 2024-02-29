using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list = GetAppropriateList("tr");    //items Containing  'tr'
           // list = GetAppropriateList("co");//items that Starts with 'co'
           //list = GetAppropriateList("Net"); //items that are Equal to 'net'
            foreach (string subname in list)
            {
               // Console.WriteLine($"{subname}");
                Console.WriteLine(subname);
            }
            Console.ReadKey();
        }
        static List<string>GetAppropriateList(string subname)
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

            //Contains
             return (from subject in list where subject.Contains(subname) select subject).ToList();


            //starts with
          //(from subject in list where subject.ToUpper().StartsWith(subname.ToUpper()) select subject).ToList();

            //Equal to
           // return (from subject in list where subject.ToUpper()==subname.ToUpper() select subject).ToList();
        }
    }
}
