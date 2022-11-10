using GeometricCalculator.Abstract;
using GeometricCalculator.Shapes;
using System;
using Xunit;

namespace GeometricCalculator.UnitTests
{
    public class CircleTestClass
    {
        [Theory]
        [InlineData(new double[] { 3 }, 28.274334)]
        public void SquareFigure_TrueResult(double[] input, double output)
        {
            IFigure shape = new Circle(input[0]);
            var result = Math.Round(shape.Square, 5);
            output = Math.Round(output, 5);
            Assert.Equal(output, result);
        }

        [Theory]
        [InlineData(new double[] { 3 }, 28.27)]
        public void SquareFigure_FalseResult(double[] input, double output)
        {
            IFigure shape = new Circle(input[0]);
            var result = Math.Round(shape.Square, 5);
            output = Math.Round(output, 5);
            Assert.False(output == result);
        }

        [Theory]
        [InlineData(new double[] { 3 }, "circle")]
        public void TypeFigure_TrueResult(double[] input, string output)
        {
            IFigure shape = new Circle(input[0]);
            var result = shape.Type;
            Assert.Equal(output, result);
        }
    }
}