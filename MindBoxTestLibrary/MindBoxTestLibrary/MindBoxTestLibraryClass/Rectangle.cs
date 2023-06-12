using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTestLibraryClass
{
	public class Rectangle : ICanCalculateMyArea
	{
		public readonly double SideA;
		public readonly double SideB;

		public Rectangle(double sideA, double sideB)
		{
			if (sideA <= 0) throw new ArgumentException("sideA less zero");
			if (sideB <= 0) throw new ArgumentException("sideA less zero");
			this.SideA = sideA;
			this.SideB = sideB;
		}

		public double CalculateArea()
		{
			double areaResult = SideA * SideB;
			return areaResult;
		}
	}
}