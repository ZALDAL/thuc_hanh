using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_6_buổi_7__bài_về_nhà_
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
        static void Min(double[]a)
        {
            double min = 0;
            double pos = 0;
            for(int i =1; i<a.Length;i++)
            {
                if (min>a[i])
                {
                    min = a[i];
                    pos = i;
                }
            }
            Console.WriteLine($"Gia tri nho nhat trong mang la{min}");
        }
        static void Main(string[] args)
        {
            double[] a;
            NhapMang(out a);
            XuatMang(a);
            Min(a);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
