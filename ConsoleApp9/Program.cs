using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void nhap(out int[,] a)
        {
            int m, n;
            Console.Write("Mời nhập số hàng: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Mời nhập số cột: ");
            n = int.Parse(Console.ReadLine());
            a = new int[m, n];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("Nhập giá trị phần tử [{0},{1}]: ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

        }
        static void xuat(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0,3}", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static void GTLNdongK(int[,] a)
        { 

            Console.Write(" nhap dong k ");
            int k = int.Parse(Console.ReadLine());
            int max = a[k, 0];

            for (int j = 0; j<a.GetLength(1); j++)
            {
                if (a[k, j] > max)
                {
                    max = a[k, j];

                }

             }
               Console.WriteLine(" GTLN la {0}", max);

        }
        static void GTNNcuacot(int[,] a)
        {
          Console.Write(" nhap cot z ");
           int z = int.Parse(Console.ReadLine());
           int min = a[0, z];

            for (int i = 0; i < a.GetLength(0); i++)
            {
               if (a[i, z] < min)
               {
                  min = a[i, z];
               }
            }
           Console.WriteLine(" GTNN la {0}", min);
        }
        static bool Kiemtra(int n)
        {
          if (n < 2)
          {
            return true;
          }
          for (int i = 2; i < n; i++)
          {
            if (n % i == 0)
            {
            return false;
            }
          }

           return true;
        }
        static void Songuyento(int[,] a)
        {
          Console.WriteLine(" cac so nguyen to ");
           for (int i = 0; i < a.GetLength(0); i++)
           {
             for (int j = 0; j < a.GetLength(1); j++)
             {
               if (Kiemtra(a[i, j]))
               {
                Console.WriteLine(a[i, j] + " ");
               }
             }
           }
             Console.WriteLine();

        }
        static void duongcheochinh(int[,] a)
        {
          Console.Write(" duong cheo chinh ");
           for (int i = 0; i < a.GetLength(0); i++)
           {
             Console.WriteLine(a[i, i] + " ");
           }
        }
        static void duongcheophu(int[,] a)
        {
          Console.Write(" duong cheo phu ");
           for (int i = 0; i < a.GetLength(0); i++)
           {
             for (int j = 0; j < a.GetLength(1); j++)
             {
            Console.WriteLine(a[i, a.GetLength(1) - 1 + i] + " ");
             }
           }
        }
        static void tamgiactren(int[,] a)
        {
          for (int i = 0; i < a.GetLength(0); i++)
          {
            Console.Write("tam giac tren ");
             for (int j = 0; j < a.GetLength(1); j++)
             if (i <= j)
                Console.Write("{0,3}", a[i, j]);
             else
                Console.Write("{0,3} ", 0);
            Console.WriteLine(' ');
          }
        }

        static void Main(string[] args)
        {
         int[,] a;
         nhap(out a);
         xuat(a);
         GTLNdongK(a);//bai 6
         GTNNcuacot(a);//bai 6
         Songuyento(a);//bai 6
         duongcheochinh(a); // bai 7
         duongcheophu(a);//bai 7
         tamgiactren(a);//bai 7

          Console.ReadKey();

        }
    }
} 

