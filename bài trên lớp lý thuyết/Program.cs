using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace bài_trên_lớp_lý_thuyết
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x, i, sum = 0, a, b;
            Console.WriteLine("nhap n:");
            n = int.Parse(Console.ReadLine());
            if (n == 0)
            { Console.WriteLine("chuong trinh chay khong duoc"); }
            else if (n < 0)
            {
                x = -1 * n;
                for (i = x; i != 0; i = i / 10)
                {
                    a = i % 10;
                    sum = sum * 10 + a;
                }
                Console.WriteLine("ket qua la {0}", sum);
            }
            else
            {
                for (i = n; i != 0; i = i / 10)
                {
                    a = i % 10;
                    sum = sum * 10 + a;
                }
                Console.WriteLine("ket qua la -{0}", sum);3
            }
            Console.ReadKey();
        } 
    }
}
