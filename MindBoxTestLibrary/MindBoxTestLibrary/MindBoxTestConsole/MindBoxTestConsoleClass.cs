using System;
using System.Drawing;
using MindBoxTestLibraryClass;

namespace MindBoxTestConsoleClass
{
    public class MindBoxTestConsoleClass
    {
        /*
         * Задание:
         * +| Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.
         * -| Дополнительно к работоспособности оценим:
         * +| Юнит-тесты
         * +| Легкость добавления других фигур
         * -| Вычисление площади фигуры без знания типа фигуры в compile-time
         * +| Проверку на то, является ли треугольник прямоугольным
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите фигуру площадь которой вы хотите высчитать:"
                + "\n 1. Треугольник по формуле трех сторон."
                + "\n 2. Круг по радиусу."
                + "\n 3. Прямоугильник по двум сторонам."
                + "\n 4. Вычисление площади фигуры без знания типа фигуры");
            int meaning = Convert.ToInt32(Console.ReadLine());

            if (meaning == 1)
            {
                string triangleAreaResult = TriangleAreaResult();
                if (triangleAreaResult != null)
                    Console.WriteLine("Площадь треугольника равна: " + triangleAreaResult);
            }
            else if (meaning == 2)
            {
                string circleAreaResult = CircleAreaResult();
                if (circleAreaResult != null)
                    Console.WriteLine("Площадь круга равна: " + circleAreaResult);
            }
            else if (meaning == 3)
            {
                string rectangleAreaResult = RectangleAreaResult();
                if (rectangleAreaResult != null)
                    Console.WriteLine("Площадь прямоугольника равна: " + rectangleAreaResult);
            }else if (meaning == 4)
            {
                string abstractAreaResult = AbstractFigureResult();
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Метод для вывода площади треугольника
        /// </summary>
        /// <returns></returns>
        public static string TriangleAreaResult()
        {
            Console.WriteLine("Введите длины сторон треугольника: ");

            Console.Write("Сторона А: ");
            double sideA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Сторона B: ");
            double sideB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Сторона C: ");
            double sideC = Convert.ToDouble(Console.ReadLine());

            Triangle areaLibrary = new Triangle(sideA, sideB, sideC);
            string result = areaLibrary.AreaCount().ToString();

            return result;
        }

        /// <summary>
        /// Метод для вывода площади круга
        /// </summary>
        /// <returns></returns>
        public static string CircleAreaResult()
        {
            Console.WriteLine("Введите длину радиуса круга: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Circle areaLibrary = new Circle(radius);
            string result = areaLibrary.AreaCount().ToString();

            return result;
        }

        public static string RectangleAreaResult()
        {
            Console.WriteLine("Введите длины сторон прямоугольника: ");

            Console.Write("Сторона А: ");
            double sideA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Сторона B: ");
            double sideB = Convert.ToDouble(Console.ReadLine());

            Rectangles areaLibrary = new Rectangles(sideA, sideB);
            string result = areaLibrary.AreaCount().ToString();

            return result;
        }

        /// <summary>
        /// Попытка выполнения третьего подпункта
        /// </summary>
        /// <returns></returns>
        public static string AbstractFigureResult()
        {
            IFigure fig = new IFigure();
            //1 сторона - это круг
            fig.sides.Add(5);
            //еще 2 стороны - это треугольник
            fig.sides.Add(6);
            fig.sides.Add(7);




            FigCalc.Calc(fig);


            return null;
        }
    }
}