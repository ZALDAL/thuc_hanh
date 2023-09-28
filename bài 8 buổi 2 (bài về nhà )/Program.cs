using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_8_buổi_2__bài_về_nhà__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so thuc la x:");
            double x = double.Parse(Console.ReadLine());
            if((x>=0) && (x<=100))
                    { if ((x >= 0) && (x <= 25))
                    Console.WriteLine("x thuoc khoang (0,25)");
                    if ((x >= 25) && (x <=50))
                    { Console.WriteLine("x thuoc khoang (25,50)");
                } if ((x >= 50) && (x <= 75))
                { Console.WriteLine("x thuoc khoang (50,75)"); }
                if((x >= 75) && (x<=100))
                { Console.WriteLine("x thuoc khoang (75,100)"); }
                Console.ReadKey();
            }
        }
    }
}
