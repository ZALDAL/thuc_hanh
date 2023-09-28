using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void NhapMang1(out int[,] a)
        {
            Console.Write("Nhap mang a:");
            Console.Write("Nhap so dong: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            int col = int.Parse(Console.ReadLine());
            a = new int[row, col];
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"a[{i},{j}]= ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
        }
        static int[,] NhapMang2()
        {
            int[,] a;
            Console.Write("Nhap so dong: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            int col = int.Parse(Console.ReadLine());
            a = new int[row, col];
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"a[{i},{j}]= ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            return a;
        }
        static void NhapMang3(int[,] c)
        {
            for (int i = 0; i < c.GetLength(0); i++)
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    Console.Write($"a[{i},{j}]= ");
                    c[i, j] = int.Parse(Console.ReadLine());
                }
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
            int[,] a;
            NhapMang1(out a);
            XuatMang(a);
            Console.Write("Nhap mang b:");
            int[,] b;
            b = NhapMang2();
            XuatMang(b);
            Console.Write("Nhap mang c:");
            Console.Write("Nhap so dong: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            int col = int.Parse(Console.ReadLine());
            int[,] c = new int[row, col];
            NhapMang3(c);
            XuatMang(c);
            Console.ReadKey();
        }

    }
}
