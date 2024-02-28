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
           list = GetAppropriateList("pu");   //items Containing string 'pu'
              //list = GetAppropriateList("n");//items that Starts with 'n'
                 //list = GetAppropriateList("centric"); //items that are Equal to 'centric'
                foreach (string subname in list)
                {
                     Console.WriteLine($"{subname}");
                 
                }
                Console.ReadKey();
        }
           static List<string> GetAppropriateList(string subname)
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
            return
            //Equal to 
            //list.Where(sub => sub.ToUpper() == subname.ToUpper()).ToList();
            //starts with
            //list.Where(sub => sub.ToUpper().StartsWith(subname.ToUpper())).ToList();
            //Contains
            list.Where(sub => sub.ToUpper().Contains(subname.ToUpper())).ToList();

        }
    }
}



