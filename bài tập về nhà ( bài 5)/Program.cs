using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_về_nhà___bài_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r, p, a;
            Console.WriteLine("r = ");
            r = double.Parse(Console.ReadLine());
            p = 2 * Math.PI * r;
            a = Math.PI * r * r;
            Console.WriteLine("P = {0:F2}", p);
            Console.WriteLine("A = {0:F2}", a);
            Console.ReadKey();
        }
    }
}
