using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace bài_2_buổi_2___bài_về_nhà_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a= ");
            Double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("c =");
            double c = double.Parse(Console.ReadLine());
            double delta = b*b -4 * a * c;
            if (a == 0)
                Console.WriteLine("phuong trinh nhap phai la phuong trinh bac 2");
            else if(delta<0)
            {
                Console.WriteLine("phuong trinh co nghiem");
            }
            else if(delta==0)
            { Console.WriteLine("phuong trinh co nghiem kep x1 = x2 = {0}", -b / (2 * a)); }
            else { Console.WriteLine("phuong trinh co 2 nghiem:");
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("-x1 = {0}", x1);
                Console.WriteLine("-x2 = {0}", x2);
            }
            Console.ReadKey();
           

        }
    }
}
