using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Student
    {
        private string StudentId;
        private string Name;
        private int brithYear;
        private bool Gender;
        private string StdClass;
        public Student() { }
        public Student(string StudenId, string Name, int BrithYear,bool Gender, string stdClass)
        {
            this.StudentId = StudenId;
            this.Name = Name;
            this.brithYear = BrithYear;
            this.Gender = Gender;
            this.StdClass = stdClass;

        }
       public string GetStudentId()
        {
            return StudentId;
        }
        public void SetStudentId( string newId)
        {
            StudentId = newId;
        }
        public string GetName() 
        { return Name; }
        public void SetName( string newName) 
        { Name = newName; }
       public int GetBrithYear() 
        {
            return brithYear;
        }
        public void SetBirthYear(int newbirthyear)
        {
            if(newbirthyear<1900|| newbirthyear>DateTime.Now.Year)
            {
                Console.Write("Nhap sai nam");
                newbirthyear = 1900;
            }
            else  brithYear=newbirthyear;
        }
        public bool GetGender() 
        { return Gender; }
        public void SetGender( bool newgender ) 
        { 
            Gender = newgender;
        }
        public string GetStdClass()
        { return StdClass; }
        public void SetStdClass( string  newStdClass )
        {
            StdClass = newStdClass;
        }
        public int GetAge()
        {
            return DateTime.Now.Year - brithYear;
        }
        public void Input ()
        {
            Console.Write("Nhap ma sv: ");
            SetStudentId(Console.ReadLine());
            Console.Write("Nhap ten sv: ");
            SetName(Console.ReadLine());
            Console.Write("Nhap nam sinh sv: ");
            SetBirthYear(int.Parse(Console.ReadLine()));
            Console.Write("NHap gioi tinh sv: ");
            SetGender(bool.Parse(Console.ReadLine()));
            Console.Write("Nhap lop sv: ");
            SetStdClass(Console.ReadLine());
        }
        public void Printlnfo()
        {
            Console.WriteLine("Ma sv: " + StudentId);
            Console.WriteLine("Ten sv: " + Name);
            Console.WriteLine("Nam sinh sv: " + brithYear);
            Console.WriteLine("Tuoi sv: " + GetAge());
            var gt = Gender == true ? "Gioi nam " : "Gioi tinh nu";
            Console.WriteLine(gt);
            Console.WriteLine("Lop sv: " + StdClass);

        }

    }
}
