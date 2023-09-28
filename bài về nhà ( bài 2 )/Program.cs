using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_về_nhà___bài_2__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringnumber;
            int intnumber;
            Console.WriteLine("input string");
            stringnumber = Console.ReadLine();
            Console.WriteLine("\"stringnumber\" value & type: {0}, {1}", stringnumber, stringnumber.GetType());
            intnumber = int.Parse(stringnumber);
            Console.WriteLine("\"stringnumber\" value & type: {0}, {1}", intnumber, intnumber.GetType());
            Console.ReadKey();
        }
    }
}
