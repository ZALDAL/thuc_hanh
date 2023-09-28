using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_3_buổi_2___bài_về_nhà__
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
            double max = a;
            if(max<b)
            { max = b; }
            if (max < c)
            { max = c; }
            Console.WriteLine("vay so lon nhat la {0}", max);
            Console.ReadKey();
        }
    }
}
