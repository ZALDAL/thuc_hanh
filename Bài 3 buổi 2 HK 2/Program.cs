using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_3_buổi_2_HK_2
{
    internal class Program
    {
        static void NhapMangA(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"a[{i}]= ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void XuatMang(int[] c)
        {
            for (int i = 0; i < c.Length; i++)
                Console.Write(c[i] + " ");
            Console.WriteLine();
        }
        static void NhapMangB(int[,] b)
        {
            for (int i = 0; i < b.GetLength(0); i++)
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write($"b[{i},{j}]= ");
                    b[i, j] = int.Parse(Console.ReadLine());
                }
        }
        static int DotProductSP(int[] a, int[,] b, int j)
        {
            int sum = 0;
            for (int k = 0; k < a.Length; k++)
                sum += a[k] * b[k, j];
            return sum;
        }
        static void ProductMatrix(int[] a, int[,] b, int[] c, out int sumtong)
        {
            int sum = 0;
            for (int j = 0; j < b.GetLength(1); j++)
            {
                c[j] = DotProductSP(a, b, j);
                sum += c[j];
            }
            sumtong = sum;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so loai trai cay: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Nhap gia cua trai cay: ");
            NhapMangA(a);
            Console.WriteLine("Nhap so ban moi ngay: ");
            string[] ds = Console.ReadLine().Split(' ');
            n = int.Parse(ds[0]);
            int p = int.Parse(ds[1]);
            int[,] b = new int[n, p];
            NhapMangB(b);
            int[] c = new int[p];
            Console.WriteLine("Doanh thu la: ");
            ProductMatrix(a, b, c, out int sumtong);
            XuatMang(c);
            Console.ReadKey();
        }
    }
}
