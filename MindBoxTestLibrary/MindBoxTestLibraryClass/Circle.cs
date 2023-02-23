using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxLibraryClass
{
    public class Circle : Figure
    {
        double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double AreaCount()
        {
                if (radius < 0)
                {
                    Console.WriteLine("Радиус не может быть отрицательным");
                    return 0;
                }
                else
                {
                    // Вычисление площади
                    double areaResult = Math.PI * Math.Pow(radius, 2);
                    return areaResult;
                }
        }


    }
}
