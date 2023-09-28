using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
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
        static void InterchangerSort(int[] a, int k, int l)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length ; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
        static void BubbleSort(int[] a, int k, int l)
        {
            for (var i = 0; i <a.Length-1; i++)
            {
                for (int j = k; j < l-1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
        static void Tim(int[]a)
        {
            Console.WriteLine("k:");
            int k = int.Parse(Console.ReadLine());
            if(k<0||k>a.Length)
            {
                Console.WriteLine("So k ko phu hop");

            }
            else
            {
                InterchangerSort(a);
                Console.WriteLine($"phan tu lon thu {k}",{ a[a.Length-k] });
            }
        }
        static void Main(string[] args)
        {
            int[] a;
            NhapMang(out a);
            XuatMang(a);
            Tim(a);
            Console.ReadKey();
        }
    }
}
