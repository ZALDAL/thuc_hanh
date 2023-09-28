using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Book
    {
        private string name;
        private Author author;
        private double price;
        private int qyt = 0;
        public Book(string name, Author author, double price)
        {
            this.name = name;
            this.author = author;
            this.price = price;
        }
        public Book(string name, Author author, double price, int qyt)
        {
            this.name = name;
            this.author = author;
            this.price = price;
            this.qyt = qyt;
        }
        public string GetName()
        {
            return name;
        }
        public Author GetAuthor()
        {
            return author;
        }
        public double GetPrice() 
        {
            return price;
        }
        public void SetPrice(double price) 
        {
            this.price = price;
        }
        public int GetQyt()
        {
            return qyt;
        }
        public void SetQyt(int qyt)
        {
            this.qyt= qyt;
        }
        public string tostring()
        {
            return $"Book[name={name},{author.toString()}, price={price},qyt={qyt}";
        }
    }
   
}
