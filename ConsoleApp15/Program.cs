using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author a = new Author("Le Nguyen Duc Tai", "lenguyenductai@gmail.com","m");
            Book b = new Book("bi kip ", a, 120000, 50);
            Console.WriteLine(b.ToString());
            Console.ReadKey();  
        }
    }
}
