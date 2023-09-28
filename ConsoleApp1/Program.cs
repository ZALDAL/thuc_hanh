using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("nhap a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap b:");
            b = int.Parse(Console.ReadLine());
            Cong(a, b);
            Tru(a, b);
            Nhan(a, b);
            Chia(a, b);
            Console.ReadLine();
        }
        static void Cong(int a,int b)
        {
            int Tong = a + b;
            Console.WriteLine("Tong la {0}", Tong);
        }
        static void Tru(int a, int b)
        {
            int tru = a - b;
            Console.WriteLine("Tru la {0}", tru);
        }
        static void Nhan(int a, int b)
        {
            int nhan = a * b;
            Console.WriteLine("Nhan la {0}", nhan);
        }
        static void Chia(int a, int b)
        {
            double chia = (double) a / b;
            Console.WriteLine("chia la {0}", chia);
        }
    }
}
