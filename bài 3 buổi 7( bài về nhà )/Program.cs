using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_3_buổi_7__bài_về_nhà__
{
    internal class Program
    {
        static void NhapMang(out int[]a)
        {
            Console.WriteLine("nhap n:");
            int n = int.Parse(Console.ReadLine());
            a = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine( $"a[{i}] = " );
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void XuatMang(int[] a)
        {
            Console.WriteLine("Gia tri cua mang:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + "");
            }
            Console.WriteLine();
        }
        static void Sum(int[] a)
        {
            int s=0;
            for(int i = 0; i < a.Length; i++)
                s=s+a[i];
            Console.WriteLine($"tong gia tri mang la{s}");
        }
        
        static void Main(string[] args)
        {
            int[] a;
            NhapMang(out a);
            XuatMang(a);
            Sum(a);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
