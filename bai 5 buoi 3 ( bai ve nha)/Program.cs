using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace bai_5_buoi_3___bai_ve_nha_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(" vay uoc so boi cua {0}", n);
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                { Console.WriteLine(i + ""); }
            }
            Console.ReadKey();
        } 
    }
}
