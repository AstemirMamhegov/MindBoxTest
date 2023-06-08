using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTestLibraryClass
{
    public class Triangle : ICanCalculateMyArea
    {
        public readonly double SideA;
        public readonly double SideB;
        public readonly double SideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
            //проверка входных данных в конструкторе
            if (sideA <= 0) throw new ArgumentException("sideA less zero");
            if (sideC <= 0) throw new ArgumentException("sideC less zero");
            if (sideB <= 0) throw new ArgumentException("sideB less zero");

            if (sideA + sideB < sideC || sideB + sideC < sideA || sideA + sideC < sideB)
            {
                throw new ArgumentException("wrong sides");
            }
        }
        
        public bool IsRight()
        {
            return IsRight(SideA, SideB, SideC);
        }
        
        /// <summary>
        /// треугольник прямоугольный?
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <returns></returns>
        public static bool IsRight(double sideA, double sideB, double sideC)
        {
            if (Math.Pow(sideA, 2) + Math.Pow(sideB, 2) == Math.Pow(sideC, 2) ||
            Math.Pow(sideA, 2) + Math.Pow(sideC, 2) == Math.Pow(sideB, 2) ||
            Math.Pow(sideB, 2) + Math.Pow(sideC, 2) == Math.Pow(sideA, 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double CalculateArea()
        {
            // Вычисление полупериметра.
            double halfPerimeter = (SideA + SideB + SideC) / 2;

            // Вычисление площади
            double areaResult = halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) *
                                (halfPerimeter - SideC);
            areaResult = Math.Sqrt(areaResult);

            return areaResult;
        }
    }
}
