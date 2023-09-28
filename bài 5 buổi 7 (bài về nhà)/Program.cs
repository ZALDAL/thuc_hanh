using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_5_buổi_7__bài_về_nhà_
{
    internal class Program
    {
        static void NhapMang(out double[] a)
        {
            Console.WriteLine("nhap n:");
            int n = int.Parse(Console.ReadLine());
            a = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"a[{i}] = ");
                a[i] = double.Parse(Console.ReadLine());
            }
        }
        static void XuatMang(double[] a)
        {
            Console.WriteLine("Gia tri cua mang:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + "");
            }
            Console.WriteLine();
        }
        static void Max(double[] a)
        {
            double max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }    
            }
            Console.WriteLine($"gia tri lon nhat trong mang la{max}");
           
        }
        static void Main(string[] args)
        {
            double[] a;
            NhapMang(out a);
            XuatMang(a);
            Max(a);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
