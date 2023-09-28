using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_3_buổi_3_bài_về_nhà_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            while(n<=1)
            { Console.WriteLine("n=");
            n = int.Parse(Console.ReadLine());}
            for(int i = 2; i <= n; i=i+2)
            { Console.Write(i + ""); }
            Console.ReadKey();
        }
    }
}
