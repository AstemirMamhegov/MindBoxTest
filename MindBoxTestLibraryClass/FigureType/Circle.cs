using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTestLibraryClass.FigureType
{
    public class Circle : ICanCalculateMyArea
    {
        public readonly double Radius;

        public Circle(double radius)
        {
            if (radius <= 0) throw new ArgumentException("radius less zero");
            Radius = radius;
        }

        public double CalculateArea()
        {
            double areaResult = Math.PI * Math.Pow(Radius, 2);
            return areaResult;
        }
    }
}
