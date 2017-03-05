using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateCostOfAreaApplication
{
    class Rectangle
    {
        double length, width;

        public Rectangle (double length, double width)
        {
            this.length = length;
            this.width = width;

        }
     
        public double CalculateAreaOfRectangle()
        {
            double areaOfRectangle = length * width;
            Console.WriteLine("Length : "+ length);
            Console.WriteLine("width  : " + width);


            return areaOfRectangle;
        }
    }
}
