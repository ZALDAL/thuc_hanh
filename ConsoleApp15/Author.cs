using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Author
    {
        private string name;
        private string email;
        private char gender;
        public Author(string name, string email, char gender)
        {
            this.name = name;
            this.email = email;
            this.gender = gender;
        }
        public string GetName()
        {
            return name;
        }
        public string GetEmail() 
        {
            return email;
        }
        public void SetEmail(string email)
        {
            this.email=email;
        }
        public char GetGender() 
        {
            return gender;
        }
        public string toString()
        {
            return $"Author[name={name}, email={email}, gender ";
        }
    }
}
