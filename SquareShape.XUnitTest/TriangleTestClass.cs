using GeometricCalculator.Shapes;
using System;
using GeometricCalculator.Abstract;
using Xunit;

namespace GeometricCalculator.UnitTests
{
    public class TriangleTestClass
    {


        [Theory]
        [InlineData(new double[] { 1, 1, 1 }, 0.433012)]
        [InlineData(new double[] { 3, 4, 5 }, 6)]
        public void OutputSquareFigure_TriangleSquare_TrueResult(double[] input, double output)
        {
            IFigure shape = new Triangle(input[0], input[1], input[2]);
            var result = Math.Round(shape.Square, 5);
            output = Math.Round(output, 5);
            Assert.Equal(output, result);
        }

        [Theory]
        [InlineData(new double[] { 1, 1, 1 }, 0.43)]
        public void OutputSquareFigure_TriangleSquare_FalseResult(double[] input, double output)
        {
            IFigure shape = new Triangle(input[0], input[1], input[2]);
            var result = Math.Round(shape.Square, 5);
            output = Math.Round(output, 5);
            Assert.False(output == result);
        }

        [Theory]
        [InlineData(new double[] { 1, 1, 1 }, "triangle")]
        public void OutputTypeFigure_TrueResult(double[] input, string output)
        {
            IFigure shape = new Triangle(input[0], input[1], input[2]);
            var result = shape.Type;
            Assert.Equal(output, result);
        }

        [Theory]
        [InlineData(new double[] { 3, 4, 5 }, true)]
        [InlineData(new double[] { 33, 56, 65 }, true)]
        public void OutputTypeTriangle_TrueResult(double[] input, bool output)
        {
            ITriangle shape = new Triangle(input[0], input[1], input[2]);
            var result = shape.IsRectangle;
            Assert.Equal(output, result);
        }

        [Theory]
        [InlineData(new[] { 3, 4, 5.1 }, false)]
        [InlineData(new[] { 33, 56, 65.1 }, false)]
        public void OutputTypeTriangle_FalseResult(double[] input, bool output)
        {
            ITriangle shape = new Triangle(input[0], input[1], input[2]);
            var result = shape.IsRectangle;
            Assert.Equal(output, result);
        }
    }
}