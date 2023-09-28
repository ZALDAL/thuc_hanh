using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace bài__4_buổi_2__bài_về_nhà__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap a");
            double a = double.Parse(Console.ReadLine());
            Console.Write("nhap b");
            double b = double.Parse(Console.ReadLine());
            Console.Write("nhap c");
            double c = double.Parse(Console.ReadLine());
            if (a > b)
            { double t = a;
                a = b;
                b = t;
            }
            if (b>c)
            { double t = b;
                b = c;
                c = t;
            }
            if (a > b)
            {
                double t = a;
                a = b;
                b = t;
            }
            Console.WriteLine("thu tu sau khi sap xep la a={0},b={1},c={2}", a, b, c);
            Console.ReadKey();
        }
    }
}
