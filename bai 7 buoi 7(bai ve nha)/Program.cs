using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_7_buoi_7_bai_ve_nha_
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
                Console.WriteLine($"a[{i}] = ");
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
        static void DemX(int[]a,int x)
        {
            int dem = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                {
                    dem++;
                }
            }
            Console.WriteLine($"So lan luot xuat hien la {dem}");
        }
        static void Main(string[] args)
        {
            int[] a;
            NhapMang(out a);
            XuatMang(a);
            Console.WriteLine("nhap x:");
                int x = int.Parse(Console.ReadLine());
            DemX(a, x);
            Console.ReadLine();
            Console.ReadKey();
            
        }
    }
}
