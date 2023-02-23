using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxLibraryClass
{
    public class Triangle : Figure
    {
        double sideA, sideB, sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }



        public override double AreaCount()
        {
            // Вычисление полупериметра.
            double halfPerimeter = (sideA + sideB + sideC) / 2;

            // Вычисление площади
            if (sideA + sideB >= sideC && sideB + sideC >= sideA && sideA + sideC >= sideB)
            {
                double areaResult = halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC);
                areaResult = Math.Sqrt(areaResult);

                // Проверка треугольника на прямой угол
                TriangleRightChecked(sideA, sideB, sideC);

                return areaResult;
            }
            else
            {
                Console.WriteLine("Трегульник с такими сторонами не имеет права не существование!");
                return 0;
            }
        }

        public bool TriangleRightChecked(double sideA, double sideB, double sideC)
        {
            if (Math.Pow(sideA, 2) + Math.Pow(sideB, 2) == Math.Pow(sideC, 2) ||
            Math.Pow(sideA, 2) + Math.Pow(sideC, 2) == Math.Pow(sideB, 2) ||
            Math.Pow(sideB, 2) + Math.Pow(sideC, 2) == Math.Pow(sideA, 2))
            {
                Console.WriteLine("Этот треугольник прямоугольный");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
