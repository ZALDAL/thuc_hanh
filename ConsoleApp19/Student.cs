using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Student:Person
    {
        private string program;
        private int year;
        public Student() { }
        public Student(string program, int year,string name,int birthyear,string address):base(name,birthyear,address) 
        {
            this.program = program;
            this.year = year;
        }
        public void Input()
        {
            base.Input();
            Console.Write("Nhap phong: ");
            program = Console.ReadLine();
            Console.Write("Nhap nam hoc:");
            year=int.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return $"Student[{base.ToString()}]-Program:{program},Year:{year}";
        }
        public void ChangeProgram(string program)
        {
            this.program=program;
        }
    }
}
