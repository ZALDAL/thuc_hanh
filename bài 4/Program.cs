using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap nam sinh");
            Console.WriteLine("nhap nam hien tai");
            int a = int.Parse(Console.ReadLine());
            int ns = int.Parse(Console.ReadLine());
            int T = a - ns;
            Console.WriteLine("tuoi:" + T);
            Console.ReadKey();
        }
    }
}
