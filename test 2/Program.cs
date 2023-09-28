using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_2
{
    internal class Program
    {
        static int bingo;
        static int bingo2;
        static void MaxMin(int[]a,int n)
        {
            for(int i = 1; i < n; i++) 
            {
                bingo = Math.Min(a[i],bingo);
                bingo2 = Math.Max(a[i],bingo2);
            }
        }
        static int[] bingoSort(int[] a,int n) 
        {
            bingo = a[0];
            bingo2 = a[0];
            int Lon = bingo2;
            int pos = 0;
            while(bingo<bingo2)
            {
                int batdaupos = bingo2;
                for(int i = batdaupos; i < n; i++)
                {
                    if (a[i]==bingo)
                    {
                        int temp = a[i];
                        a[i] = a[pos];
                        a[pos] = temp;
                        pos=pos+1;
                    }
                    else if(a[i]<bingo2)  
                    {
                        bingo = a[i];
                    }
                    bingo = bingo2;
                    bingo2 = Lon;
                }
            }    
            return a;
        }
        static void Mang(int[] a,int n)
        {
            Console.WriteLine("Mang");
            for(int i = 0;i < n; i++)
            {
                Console.Write(a[i] + " ");
                
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] a = { 9, 8, 65, 41, 5, 8, 6, 9, 46 };
            a= bingoSort(a,a.Length);
            Mang(a, a.Length);
            Console.ReadLine();
        }
    }
}
