using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class Fraction
    {

        private int numerator;
        private int denominator;
        public int Numerator
        {
            get { return numerator; }
            set
            {
                numerator = value;
            }
        }
        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value != 0)
                {
                    denominator = value;

                    if (denominator < 0)
                    {
                        numerator = -numerator;
                        denominator = -denominator;
                    }
                }
                else
                {
                    Console.WriteLine("Mau so phai khac 0. " +
                        "Mau so duoc thiet lap mac dinh la 1");
                    denominator = 1;
                }
            }
        }


        public Fraction()
        {

            this.numerator = 0;
            this.denominator = 1;
        }
        public Fraction(int numerator, int denominator)
        {
            this.Numerator = numerator;

            this.Denominator = denominator;
            this.Simplify();
        }
        public Fraction(int numerator)
        {

            this.numerator = numerator;
            this.denominator = 1;
        }


        private static int GCD(int a, int b)
        {
            if (b == 0)
                return a;
            return GCD(b, a % b);
        }
        private void Simplify()
        {
            int g = GCD(this.numerator, this.denominator);
            this.numerator = this.numerator / g;
            this.denominator = this.denominator / g;
        }

        public Fraction Add(Fraction f)
        {
            Fraction sum = new Fraction();
            sum.Denominator = denominator * f.denominator;
            sum.Numerator = numerator * f.denominator + denominator * f.numerator;

            sum.Simplify();
            return sum;


        }

        public static Fraction Add(Fraction f1, Fraction f2)
        {
            Fraction sum = new Fraction();
            sum.denominator = f1.denominator * f2.denominator;
            sum.numerator = f1.numerator * f2.denominator + f1.denominator * f2.numerator;
            sum.Simplify();
            return sum;
        }
        public static Fraction Sub(Fraction f1, Fraction f2)
        {
            Fraction sub = new Fraction();
            sub.denominator = f1.denominator * f2.denominator;
            sub.numerator = f1.numerator * f2.denominator - f1.denominator * f2.numerator;
            sub.Simplify();
            return sub;
        }
        public static Fraction Mul(Fraction f1, Fraction f2)
        {
            Fraction Mul = new Fraction();
            Mul.denominator = f1.denominator * f2.denominator;
            Mul.numerator = f1.numerator * f2.numerator;
            Mul.Simplify();
            return Mul;
        }
        public static Fraction Div(Fraction f1, Fraction f2)
        {
            Fraction Div = new Fraction();
            Div.denominator = f1.denominator * f2.numerator;
            Div.numerator = f1.numerator * f2.denominator;
            Div.Simplify();
            return Div;
        }
        public string ToString()
        {

            this.Simplify();
            return numerator + "/" + denominator;

        }
    }
}
