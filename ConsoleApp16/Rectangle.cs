using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
   public class Rectangle
   {
      private double length;
      private double width;

     public Rectangle(double l, double w)
     {
        length = l;
        width = w;
     }

     public double GetArea()
     {
        return length * width;
     }

     public double GetPerimeter()
     {
         return 2 * (length + width);
     }

     public double Length
     {
        get { return length; }
        set { length = value; }
     }

     public double Width
     {
        get { return width; }
        set { width = value; }
     }
   }

}
