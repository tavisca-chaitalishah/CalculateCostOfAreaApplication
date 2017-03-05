using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateCostOfAreaApplication
{
    class CostController : Rectangle
    {
        public double cost;
        public CostController(double length, double width, double cost):base(length, width)
        {
            this.cost = cost;
        }


        public double CalcCost()

        {
            double areaOfRectangle = CalculateAreaOfRectangle();
            double finalCost = cost * areaOfRectangle;
            Console.WriteLine("Area   : " + areaOfRectangle);
            return finalCost;
        }
    }
}
