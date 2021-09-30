using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLib
{
    public static class Triangle
    {
        public static double Area(double height, double baseLength)
        {
            return height * baseLength / 2;
        }
    }
}
