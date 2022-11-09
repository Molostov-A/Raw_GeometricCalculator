using System;
using GeometryCalculator.Helpers;
using GeometryCalculator.Shapes;
using SquareShape.Common;
using Xunit;

namespace GeometryCalculator.UnitTests
{
    public class MakerFigures_TestClass
    {
        private MakerFigures makerFigures = new MakerFigures();
        private Figure CreateShape(double[] input)
        {
            var shape = makerFigures.Create(input);
            return shape;
        }

        [Theory]
        [InlineData(new double[] { 1, 1, 1 }, 0.433012)]
        [InlineData(new double[] { 3, 4, 5 }, 6)]
        [InlineData(new double[] { 3 }, 28.274334)]
        public void OutputSquareFigure_TriangleSquare_TrueResult(double[] input, double output)
        {
            var shape = CreateShape(input);
            var result = Math.Round(shape.Square, 5);
            output = Math.Round(output, 5);
            Assert.Equal(output, result);
        }

        [Theory]
        [InlineData(new double[] { 1, 1, 1 }, 0.43)]
        [InlineData(new double[] { 3 }, 28.27)]
        public void OutputSquareFigure_TriangleSquare_FalseResult(double[] input, double output)
        {
            var shape = CreateShape(input);
            var result = Math.Round(shape.Square, 5);
            output = Math.Round(output, 5);
            Assert.False(output == result);
        }

        [Theory]
        [InlineData(new double[] { 1, 1, 1 }, "triangle")]
        [InlineData(new double[] { 3 }, "circle")]
        public void OutputTypeFigure_TrueResult(double[] input, string output)
        {
            var shape = CreateShape(input);
            var result = shape.TypeShape;
            Assert.Equal(output, result);
        }

        [Theory]
        [InlineData(new double[] { 3, 4, 5 }, true)]
        [InlineData(new double[] { 33, 56, 65 }, true)]
        public void OutputTypeTriangle_TrueResult(double[] input, bool output)
        {
            var shape = CreateShape(input);
            var result = ((Triangle)shape).IsRectangle;
            Assert.Equal(output, result);
        }

        [Theory]
        [InlineData(new [] { 3, 4, 5.1 }, false)]
        [InlineData(new [] { 33, 56, 65.1 }, false)]
        public void OutputTypeTriangle_FalseResult(double[] input, bool output)
        {
            var shape = CreateShape(input);
            var result = ((Triangle)shape).IsRectangle;
            Assert.Equal(output, result);
        }
    }
}
