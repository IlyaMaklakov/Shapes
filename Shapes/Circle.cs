using System;

namespace Shapes
{
	public class Circle : Shape
	{
		public double Radius { get; }

		public Circle(double radius) => Radius = radius;

		public override double Area => Math.PI * Math.Pow(Radius, 2);
	}
}
