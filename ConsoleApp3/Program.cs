using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static int Sum(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                int s = n % 10;
                sum = sum + s;
                n = n / 10;
            }
            Console.WriteLine("tong cac so la{0}",sum);
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("n =");
            int n = int.Parse(Console.ReadLine());
            Sum(n);
            Console.ReadKey();
        }    
      
    }
}
