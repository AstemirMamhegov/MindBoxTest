using MindBoxTestLibraryClass;
using MindBoxTestConsoleClass;
using System.Runtime.InteropServices;

namespace MindBoxMSTest
{
    [TestClass]
    public class MindBoxUnitTest
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        /// <param name="mustThrow">должен ли action выбросить ожидаемое исключение</param>
        /// <typeparam name="T">тип ожидаемого исключения</typeparam>
        /// <exception cref="AssertFailedException"></exception>
        public void ThrowIfException<T>(Action action, bool mustThrow)
        {
            try
            {
                action();
            }
            catch (Exception e)
            {
                if (e is T)
                {
                    return;
                }

                throw new AssertFailedException("Выброшено неожидаемое исключение", e);
            }

            if (mustThrow == true)
            {
                throw new AssertFailedException("ожидаемое исколючение не выброшено");
            }
        }

        //Тесты на треугольник
        [TestMethod]
        public void TriangleIsRight()
        {
            Triangle triangle;
            triangle = new Triangle(3, 3, 3);
            Assert.AreEqual(false, triangle.IsRight());

            triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(true, triangle.IsRight());
        }

        [TestMethod]
        public void TriangleCreationException()
        {
            //корректно
            ThrowIfException<ArgumentException>(() => new Triangle(3, 4, 5), false);
            ThrowIfException<ArgumentException>(() => new Triangle(3, 3, 3), false);

            //неправильное соотношение сторон
            ThrowIfException<ArgumentException>(() => new Triangle(1, 2, 5), true);

            //неправильные стороны
            ThrowIfException<ArgumentException>(() => new Triangle(-3, 3, 3), false);
        }

        [TestMethod]
        public void TriangleArea()
        {
            Assert.AreEqual(new Triangle(3, 4, 5).CalculateArea(), 6);

        }

        //Тесты на круг
        [TestMethod]
        public void CircleArea()
        {
            Assert.AreEqual(new Circle(10).CalculateArea(), 314, 1592653589793);
        }

        [TestMethod]
        public void CircleCreationException()
        {
            ThrowIfException<ArgumentException>(() => new Circle(5), false);

            ThrowIfException<ArgumentException>(() => new Circle(0), false);

            ThrowIfException<ArgumentException>(() => new Circle(-1), false);
        }

        //Тесты на прямоугольник
        [TestMethod]
        public void RectangleArea()
        {
            Assert.AreEqual(new Rectangle(10, 15).CalculateArea(), 150);
        }

        [TestMethod]
        public void RectangleCrationException()
        {
            ThrowIfException<ArgumentException>(() => new Rectangle(5, 10), false);

            ThrowIfException<ArgumentException>(() => new Rectangle(10, 0), false);

            ThrowIfException<ArgumentException>(() => new Rectangle(-1, 10), false);
        }

        // Тесты на вычисление площадей
        [TestMethod]
        public void FiguresAreaCalculatorException()
        {
            ThrowIfException<Exception>(() => FiguresAreaCalculator.CalculateArea(new object()), true);
            ThrowIfException<Exception>(() => FiguresAreaCalculator.CalculateArea(new bool()), true);
            ThrowIfException<Exception>(() => FiguresAreaCalculator.CalculateArea(new Stack<bool>()), true);

            //CalculateArea(object figure)
            ThrowIfException<Exception>(() => FiguresAreaCalculator.CalculateArea((object)new Triangle(3, 3, 3)), false);
            ThrowIfException<Exception>(() => FiguresAreaCalculator.CalculateArea((object)new Rectangle(5, 5)), false);
            ThrowIfException<Exception>(() => FiguresAreaCalculator.CalculateArea((object)new Circle(5)), false);

            //CalculateArea<T>(T figure) where T : ICanCalculateMyArea
            ThrowIfException<Exception>(() => FiguresAreaCalculator.CalculateArea(new Triangle(3, 3, 3)), false);
            ThrowIfException<Exception>(() => FiguresAreaCalculator.CalculateArea(new Rectangle(5, 5)), false);
            ThrowIfException<Exception>(() => FiguresAreaCalculator.CalculateArea(new Circle(5)), false);
        }

        [TestMethod]
        public void CalculateAreaRuntime()
        {
            var triangle = new Triangle(3, 4, 5);
            var rectangle = new Rectangle(5, 5);
            var circle = new Circle(5);

            Assert.AreEqual(6, FiguresAreaCalculator.CalculateArea(triangle));
            Assert.AreEqual(25, FiguresAreaCalculator.CalculateArea(rectangle));
            Assert.AreEqual(78.5, FiguresAreaCalculator.CalculateArea(circle), 1);
        }


    }
}