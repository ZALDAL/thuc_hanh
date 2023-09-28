using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_4_buổi_3__bài_về_nhà_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n =");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            double avg = 0;
            for(int i = 1;i<=n;i++)
            { sum = sum + i;}
            avg = (double)sum / n;
            Console.Write("sum ={0}", sum);
            Console.Write("avg = {0}", avg);
            Console.ReadKey();
        }
    }
}
