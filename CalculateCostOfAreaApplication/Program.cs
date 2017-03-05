using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateCostOfAreaApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of Rectangle");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width of Rectangle");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entert the cost of area of plot");
            double cost = Convert.ToDouble(Console.ReadLine());
            CostController costController = new CostController(length, width, cost);
         
            Console.WriteLine("Cost   : "+costController.CalcCost());
            Console.WriteLine("Thankyou \n Press any key to Exit the application...");
            Console.ReadLine();
        }
    }
}
