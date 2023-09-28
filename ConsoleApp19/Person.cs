using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Person
    {
        private string name;
        private int birthyear;
        private string address;
        public Person() { } 
        public Person(string name, int birthyear, string address)
        {
            this.name = name;
            this.birthyear = birthyear;
            this.address = address;
        }
        public void Input()
        {
            Console.Write("Nhap ten: ");
            name = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            birthyear=int.Parse(Console.ReadLine());
            Console.Write("Nhap dia chi: ");
            address = Console.ReadLine();
        }
        public int Age() { return DateTime.Now.Year- birthyear; }
        public override string ToString() { return $"Person[Name={name},BirthYear={birthyear},Address={address}]"; }
    }
}
