using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Buổi_2
{
    internal class Program
    {
        static void Nhap( int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"a[{i},{j}]");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void Xuat(int[,]a)
        {
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void TongHaiMaTran(int[,] a, int[,] b, int[,]c)
        {
            for(int i = 0; i < c.GetLength(0); i++)
            {
                for(int j = 0; j < c.GetLength(1); j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }
        }
        static int Docfroduct(int[,] a, int[,] b,int i,int j)
        {
            int sum = 0;
            for(int k = 0; k < a.GetLength(0); k++)
            {
                sum = sum + a[i, k] * b[k, j];
            }
            return sum;
        }
        static void TichHaiMang(int[,] a, int[,] b, int[,] c)
        {
          for(int i=0; i < c.GetLength(1); i++)
          {
                for(int j =0; j < c.GetLength(1); j++)
                {
                    c[i, j] = Docfroduct(a, b, i, j); 
                }
          }
            Console.ReadLine();
        }
        static void ChuyenVi(int[,] a)
        {
            int[,] t = new int[a.GetLength(0),a.GetLength(1)];
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    t[i, j] = a[j, i];
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap dong va cot:");
            string input = Console.ReadLine();
            string[] ds = input.Split(' ');
            int m = int.Parse(ds[0]);
            int n = int.Parse(ds[1]);
            int o = int.Parse(ds[2]);
            Console.Write("m=", m);
            Console.Write("n=", n);
            int[,]a= new int[m, n];
            int[,]b= new int[n,o];
            int[,]c= new int[m, o];
            Console.WriteLine("Nhap mang a:");
            Nhap(a);
            Console.WriteLine("Nhap mang b;");
            Nhap(b);
            Console.WriteLine("Mang a:");
            Xuat(a);
            Console.WriteLine("Mang b:");
            Xuat(b);
            TongHaiMaTran(a, b, c);
            Console.WriteLine("Tong hai mang tran:");
            Xuat(c);// bai 1
            TichHaiMang(a,b,c);
            Console.WriteLine("Hai ma tran nhan nhau:");
            Xuat(c);// bai 2
            Console.ReadKey();
            
        }
    }
}
