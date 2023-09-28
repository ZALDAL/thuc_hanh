using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_5_buoi_8
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
        static void InterchangerSort_Dec(int[] a, int k, int l)
        {
            for (int i = k; i < l; i++)
            {
                for (int j = i + 1; j < l+1; j++)
                {
                    if (a[i] <a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
        static void InterchangerSort_Int(int[] a, int k, int l)
        {
            for (int i = k; i < l; i++)
            {
                for (int j = i + 1; j < l + 1; j++)
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
        static void SapXepTangGiam(int[] a, int k, int l)
        {
            InterchangerSort_Int(a, k, l);
            InterchangerSort_Dec(a, 0, k - 1);
            InterchangerSort_Dec(a,l+1,a.Length-1);
        }
        static void BubbleSort(int[] a, int k, int l)
        {
            for (var i = 0; i < a.Length - 1; i++)
            {
                for (int j = k; j < l - 1; j++)
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
        static void Main(string[] args)
        {
            int[] a;
            NhapMang(out a);
            XuatMang(a);
            Console.WriteLine("k:");
            int k =int.Parse(Console.ReadLine());
            Console.WriteLine("l:");
            int l = int.Parse(Console.ReadLine());
            if(0<=k||k<=l&&l<a.Length)
            {
                SapXepTangGiam(a, k, l);
                XuatMang(a);
            }
            else
            {
                Console.WriteLine("k va l ko thoa dk");
            }
            Console.ReadKey();
        }
    }
}
