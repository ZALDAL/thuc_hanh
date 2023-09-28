using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Date
    {
        private int day;
        private int year;
        private int month;
        public Date(int day, int year, int month)
        {
            this.day = day;
            this.year = year;
            this.month = month;
        }
        public int GetDay()
        {
            return day;
        }
        public void SetDay(int day) 
        {
            this.day = day;
        }
        public int GetYear() 
        {
            return year;
        }
        public void SetYear(int year) 
        {
            this.year = year;
        }
        public int GetMonth()
        {
            return month;
        }
        public void SetMonth(int month)
        {
            this.month = month;
        }
        public void SetDate(int day, int month,int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public string toString()
        {
            return string.Format($"{0}/{1}/{2}",day,month,year);
        }
    }
}
