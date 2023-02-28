using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTestLibraryClass
{
    public class Triangle : Figure
    {
        public double sideA, sideB, sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            //проверка входных данных в конструкторе
            if (sideA < 0) throw new ArgumentException("sideA less zero");
            if (sideC < 0) throw new ArgumentException("sideC less zero");
            if (sideB < 0) throw new ArgumentException("sideB less zero");

            if (sideA + sideB >= sideC && sideB + sideC >= sideA && sideA + sideC >= sideB)
            {
                throw new ArgumentException("wrong sides");
            }
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
                //throw new ArgumentException("wrong sides");
                //Console.WriteLine("Трегульник с такими сторонами не имеет права не существование!");
                return 0;
            }
        }

        public bool TriangleRightChecked(double sideA, double sideB, double sideC)
        {
            if (Math.Pow(sideA, 2) + Math.Pow(sideB, 2) == Math.Pow(sideC, 2) ||
            Math.Pow(sideA, 2) + Math.Pow(sideC, 2) == Math.Pow(sideB, 2) ||
            Math.Pow(sideB, 2) + Math.Pow(sideC, 2) == Math.Pow(sideA, 2))
            {
                //Console.WriteLine("Этот треугольник прямоугольный");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
