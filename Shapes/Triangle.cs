using System;
using System.Linq;

namespace Shapes
{
	public class Triangle : Shape
	{
		public double A { get; }
		public double B { get; }
		public double C { get; }

		public Triangle(double a, double b, double c) => (A, B, C) = (a, b, c);

		public bool IsRightAngled()
		{
			var orderedSides = new[] {A, B, C}.OrderBy(s => s).ToArray();
			return (Math.Pow(orderedSides[0], 2) + Math.Pow(orderedSides[1], 2)).Equals(Math.Pow(orderedSides[2], 2));
		}


		public override double Area
		{
			get {
				var s = (A + B + C) / 2;
				return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
			}
			
		}
	}
}
