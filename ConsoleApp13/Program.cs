using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void NhapMang(out int[,] a, int m, int n)
        {
            a = new int[m, n];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"a[{i},{j}]= ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
        }
        static void InDongK(int[,] a, int k)
        {
            int s = 0;
            Console.Write("Cac phan tu dong k: ");
            if (k < 0 || k > a.GetLength(0))
            {
                Console.Write("Invalid K");
            }
            else
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[k, j] + " ");
                    s += a[k, j];
                }
                Console.WriteLine($"Tong dong la: {s}");
            }
        }
        static void InCotK(int[,] a, int k)
        {
            int s = 0;
            Console.Write("Cac phan tu cot K: ");
            if (k < 0 || k > a.GetLength(1))
            {
                Console.Write("Invalid K");
            }
            else
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    Console.Write(a[i, k] + " ");
                    s += a[i, k];
                }
                Console.WriteLine($"Tong cot la: {s}");
            }
        }
        static int TinhTong(int[,] a)
        {
            int s = 0;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    s += a[i, j];
                }
            Console.WriteLine($"Tong cac phan tu: {s}");
            return s;
        }
        static int TongSoChan(int[,] a)
        {
            int s = 0;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    if (a[i, j] % 2 == 0)
                    {
                        s += a[i, j];
                    }
            Console.WriteLine($"Tong cac so chan la: {s}");
            return s;
        }
        static int TongSoLe(int[,] a)
        {
            int s = 0;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    if (a[i, j] % 2 != 0)
                    {
                        s += a[i, j];
                    }
            Console.WriteLine($"Tong cac so le la: {s}");
            return s;
        }
        static double TB(int[,] a)
        {
            int s = 0;
            double tb = 0;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    s += a[i, j];
            tb = (double)s / a.Length;
            Console.Write($"Gia tri trung binh cac phan tu la: {tb}");
            return tb;
        }
        static void XuatMang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {

                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0,3}", a[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so dong,so cot,so k: ");
            string[] ds = Console.ReadLine().Split(' ');
            int m = int.Parse(ds[0]);
            int n = int.Parse(ds[1]);
            int k = int.Parse(ds[2]);
            int[,] a;
            NhapMang(out a, m, n);
            XuatMang(a);
            InDongK(a, k);
            InCotK(a, k);
            TinhTong(a);
            TongSoChan(a);
            TongSoLe(a);
            TB(a);
            Console.ReadKey();
        }

    }
}
