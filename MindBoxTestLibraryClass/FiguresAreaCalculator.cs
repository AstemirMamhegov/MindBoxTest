using System.Reflection;
using System.Security.Cryptography.X509Certificates;

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
					throw new ReturnedNullException(calculateAreaMethodInfo, figureType);
				}
				return result.Value;
			}
		}

		throw new InterfaceNotImplementedException(InterfaceCanCalculateMyAreaType, figureType);

	}
}