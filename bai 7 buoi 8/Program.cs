using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_7_buoi_8
{
    internal class Program
    {
        static void NhapMang(out int[] a)
        {
            Console.WriteLine("nhap n:");
            int n = int.Parse(Console.ReadLine());
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"a[{i}]=");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void XuatMang(int[] a)
        {
            Console.WriteLine("Gia tri mang");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + "");
            }
            Console.WriteLine();
        }
        static void KiemTraTong(int[]a)
        {
            for(int i =0;i <a.Length;i++)
            {
                for(int j= i+1;j<a.Length;j++)
                    if (a[i] + a[j]==0)
                    {
                        Console.Write($"Cap i j can tim la: i={i}||j={j}");
                        return;
                    }
            }
            Console.WriteLine("ko ton tai cap i j thoa man");
        }
        static void Main(string[] args)
        {
            int[] a;
            NhapMang(out a);
            XuatMang(a);
            KienTraTong(a);
            Console.ReadKey();  
        }
    }
}
