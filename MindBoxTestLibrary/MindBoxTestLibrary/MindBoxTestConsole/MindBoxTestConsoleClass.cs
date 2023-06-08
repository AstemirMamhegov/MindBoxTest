using System;
using System.Drawing;
using MindBoxTestLibraryClass;

namespace MindBoxTestConsoleClass
{
    public class MindBoxTestConsoleClass
    {
        static void Main()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            //перый метод
            var area = FiguresAreaCalculator.CalculateArea(triangle);

            //второй метод
            var area2 = FiguresAreaCalculatorExtensions.CalculateArea(triangle);

            //проверка на прямой угол
            var result = triangle.IsRight();

            Console.WriteLine(area + " и " + area2 + " " + result);
        }
    }
}