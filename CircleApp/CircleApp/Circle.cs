using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Circle
    {
        public double GetDiameter(int radius)
        {
            return 2*(double)radius;
        }

        public double GetPerimeter(int radius)
        {
            return 2*Math.PI*(double)radius;
        }

        public double GetArea(int radius)
        {
            return Math.PI*(double)radius*(double)radius;
        }
    }
}
