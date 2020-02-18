using Xunit;

namespace Shapes.Tests
{
	public class ShapesTests
	{
		[Theory]
		[InlineData(10, 314.1592653589793)]
		public void CircleAreaTest(double radius, double expected)
		{
			Assert.Equal(expected, new Circle(radius).Area);
		}

		[Theory]
		[InlineData(3, 4, 5, 6)]
		public void TriangleAreaTest(double a, double b, double c, double expected)
		{
			Assert.Equal(expected, new Triangle(a, b, c).Area);
		}

		[Theory]
		[InlineData(3, 4, 5, true)]
		[InlineData(5, 3, 4, true)]
		[InlineData(4, 5, 3, true)]
		[InlineData(3, 5, 5, false)]
		public void TriangleIsRightAngledTest(int a, int b, int c, bool expected)
		{
			Assert.Equal(expected, new Triangle(a, b, c).IsRightAngled());
		}
	}
}
