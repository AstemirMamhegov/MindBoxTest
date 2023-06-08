namespace MindBoxTestLibraryClass;

public static class FiguresAreaCalculatorExtensions
{
    public static double CalculateArea(this Triangle triangle)
    {
        double sideA = triangle.SideA, sideB = triangle.SideB, sideC = triangle.SideC;

        // Вычисление полупериметра.
        double halfPerimeter = (sideA + sideB + sideC) / 2;

        // Вычисление площади
        double areaResult = halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) *
                            (halfPerimeter - sideC);
        areaResult = Math.Sqrt(areaResult);

        return areaResult;
    }

    public static double CalculateArea(this Circle circle)
    {
        // Вычисление площади
        double areaResult = Math.PI * Math.Pow(circle.Radius, 2);
        return areaResult;
    }

    public static double CalculateArea(this Rectangle rectangle)
    {
        double areaResult = rectangle.SideA * rectangle.SideB;
        return areaResult;
    }
}