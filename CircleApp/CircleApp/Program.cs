using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string rad;
            int radius;
            double area;
            double diameter;
            double perimeter;

            Circle aCircle= new Circle();
            Console.WriteLine("Plese enter the radius:");
            rad=Console.ReadLine();
            radius = Convert.ToInt16(rad);
            diameter = aCircle.GetDiameter(radius);
            perimeter = aCircle.GetPerimeter(radius);
            area=aCircle.GetArea(radius);

            Console.WriteLine("The diameter is: " + diameter);
            Console.WriteLine("The perimeter is: " + perimeter);
            Console.WriteLine("The area is: " + area);
            Console.ReadKey();

        }
    }
}
