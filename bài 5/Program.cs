using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap a va b");
            Console.WriteLine("nhap a");
            Console.WriteLine("nhap b");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = a;
            a = b  ;
            b = c ;
            Console.WriteLine("sau khi hoan doi");
            Console.WriteLine("a:" + a);
            Console.WriteLine("b:" + b);
            Console.ReadKey();
        }
    }
}
