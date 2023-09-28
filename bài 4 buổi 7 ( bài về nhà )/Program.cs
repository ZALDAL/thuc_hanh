using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_4_buổi_7___bài_về_nhà__
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
        static int TimX(int[]a, int x)
        {
            for(int i =0;i<a.Length;i++)
            {
                if(a[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] a;
            NhapMang(out a);
            XuatMang(a);
            Console.WriteLine("Nhap x can tim:");
            int x = int.Parse(Console.ReadLine());
            int pos = TimX(a, x);
            if(pos == -1)
            {
                Console.WriteLine($"So{x} khong co trong vi tri mang");
            }
            else 
            {
                Console.WriteLine($"So{x} co trong vi tri {pos}");
            }
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
