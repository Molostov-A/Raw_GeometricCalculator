using System;
using GeometricCalculator.Abstract;
using GeometricCalculator.Shapes;
using Xunit;

namespace GeometricCalculator.UnitTests
{
    public class MakerFigures_TestClass
    {
        private IFigure CreateShape(double[] input)
        {
            IMakerFigures makerFigures = new MakerFigures();
            var shape = makerFigures.Create(input);
            return shape;
        }

        [Theory]
        [InlineData(new double[] { 1, 1, 1 }, 0.433012)]
        [InlineData(new double[] { 3, 4, 5 }, 6)]
        [InlineData(new double[] { 3 }, 28.274334)]
        public void SquareFigure_TrueResult(double[] input, double output)
        {
            var shape = CreateShape(input);
            var result = Math.Round(shape.Square, 5);
            output = Math.Round(output, 5);
            Assert.Equal(output, result);
        }

        [Theory]
        [InlineData(new double[] { 1, 1, 1 }, 0.43)]
        [InlineData(new double[] { 3 }, 28.27)]
        public void SquareFigure_FalseResult(double[] input, double output)
        {
            var shape = CreateShape(input);
            var result = Math.Round(shape.Square, 5);
            output = Math.Round(output, 5);
            Assert.False(output == result);
        }

        [Theory]
        [InlineData(new double[] { 1, 1, 1 }, "triangle")]
        [InlineData(new double[] { 3 }, "circle")]
        public void TypeFigure_TrueResult(double[] input, string output)
        {
            var shape = CreateShape(input);
            var result = shape.Type;
            Assert.Equal(output, result);
        }

        [Theory]
        [InlineData(new double[] { 3, 4, 5 }, true)]
        [InlineData(new double[] { 33, 56, 65 }, true)]
        public void TypeTriangle_TrueResult(double[] input, bool output)
        {
            var shape = CreateShape(input);
            var result = ((ITriangle)shape).IsRectangle;
            Assert.Equal(output, result);
        }

        [Theory]
        [InlineData(new [] { 3, 4, 5.1 }, false)]
        [InlineData(new [] { 33, 56, 65.1 }, false)]
        public void TypeTriangle_FalseResult(double[] input, bool output)
        {
            var shape = CreateShape(input);
            var result = ((ITriangle)shape).IsRectangle;
            Assert.Equal(output, result);
        }
    }
}
