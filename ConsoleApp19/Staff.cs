using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Staff:Person
    {
        private string department;
        private double salary;
        public Staff() { }
        public Staff(string department, double salary,string name, int birthyear, string address):base(name, birthyear, address) 
        {
            this.department = department;
            this.salary = salary;
        }
        public void Input()
        {
            base.Input();
            Console.Write("Nhap Phong: ");
            department=Console.ReadLine();
            Console.Write("Nhap Luong: ");
            salary=double.Parse(Console.ReadLine());    
        }
        public override string ToString()
        {
            return $"Staff[{base.ToString()}]-Department={department},Salary={salary}";
        }
        public void Update(double salary)
        {
            this.salary=salary;
        }
    }
}
