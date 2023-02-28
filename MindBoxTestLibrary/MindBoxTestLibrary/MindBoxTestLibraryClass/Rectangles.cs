using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTestLibraryClass
{
    public class Rectangles : Figure
    {
        public double sideA, sideB;

        public Rectangles(double sideA, double sideB)
        {
            if (sideA < 0) throw new ArgumentException("sideA less zero");
            if (sideB < 0) throw new ArgumentException("sideA less zero");
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public override double AreaCount()
        {
            double areaResult = sideA * sideB;
            return areaResult;
        }
    }
}
