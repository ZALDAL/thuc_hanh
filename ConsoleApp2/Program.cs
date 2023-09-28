using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("nhap a:");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("nhap b:");
            b=int.Parse(Console.ReadLine());
            Console.WriteLine("nhap c:");
            c=int.Parse(Console.ReadLine());
            Min(a, b, c);
            Console.ReadLine();
        }
        static int Min(int a, int b,int c)
        { 
            int min = a;
            if (min > b)
            {
                min = b;
                if (min > c)
                { min = c; }
            }
            Console.WriteLine("So nho nhat trong 3 so nguyen la{0}", min);

            return a+b+c;
        }
    }
}
