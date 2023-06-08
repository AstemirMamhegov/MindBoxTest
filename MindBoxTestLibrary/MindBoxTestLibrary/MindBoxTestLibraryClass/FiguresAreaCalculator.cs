using System.Reflection;

namespace MindBoxTestLibraryClass;

public static class FiguresAreaCalculator
{
	public static double CalculateArea<T>(T figure) where T : ICanCalculateMyArea
	{
		var area = figure.CalculateArea();
		return area;
	}
	
	public static readonly Type InterfaceCanCalculateMyAreaType = typeof(ICanCalculateMyArea);
	public static double CalculateArea(object figure)
	{
		Type figureType = figure.GetType();

		
		if (figureType.GetInterfaces().Contains(InterfaceCanCalculateMyAreaType))
		{
			var calculateAreaMethodInfo = InterfaceCanCalculateMyAreaType.GetMethod(nameof(ICanCalculateMyArea.CalculateArea));
			if (calculateAreaMethodInfo is not null)
			{
				var result = (double?) calculateAreaMethodInfo.Invoke(figure, null);
				if (result is null)
				{
					throw new Exception($"статический метод ({InterfaceCanCalculateMyAreaType.FullName}.{calculateAreaMethodInfo.Name}) возвратил null при передаче в него фигуры типа {figureType.FullName}");
				}
				return result.Value;
			}
		}

		throw new Exception(
			$"Переданная фигура типа {figureType.FullName} не реализует интерфейс {InterfaceCanCalculateMyAreaType.FullName}");
	}
}