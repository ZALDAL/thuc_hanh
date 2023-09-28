using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_14_buổi_3___bài_về__nhà__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n:");
            int n = int.Parse(Console.ReadLine());
            int m = n;
            while (m > 0) { int temp = n / 10 * 3;
                m = m + temp;
                n = temp + m % 10;
            }
            Console.WriteLine("m={0}", m);
            Console.ReadKey();
                
        }
    }
}
