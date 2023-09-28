using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a:");
            int a =int.Parse(Console.ReadLine());
            Console.WriteLine("b:");
            int b =int.Parse(Console.ReadLine());
            hoandoi(a, b);
            Console.ReadKey();
        }
        static int hoandoi(int a, int b)
        {
            int c = a;
             a = b;
             b = c;
            Console.WriteLine("Sau khi hoan doi a={0} b={1}",a,b);
            return a + b; 
        }
    }
}
