using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so sv: ");
            int n = int.Parse(Console.ReadLine());
            Student[] ds = new Student[n];
            for(int i = 0; i < n; i++) 
            {
                Console.WriteLine($"============== Nhap thong tin sv{i + 1} ========================");
                ds[i] = new Student();
                ds[i].Input();
            }
            Console.WriteLine("====================Thong tin sv la=====================================");
            for( int i = 0; i < n;i++) 
            {
                ds[i].Printlnfo();
            }
            Console.ReadKey();
        }
    }
}
