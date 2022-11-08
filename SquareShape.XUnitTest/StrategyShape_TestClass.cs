using System;
using SquareShape.Common;
using SquareShape.Common.Helpers;
using SquareShape.Common.Shapes;
using Xunit;

namespace SquareShape.XUnitTest
{
    public class StrategyShape_TestClass
    {
        StrategyShape figureManager = new StrategyShape();


        [Theory]
        [InlineData("1 1 1", 0.433012)]
        [InlineData("3 4 5", 6)]
        [InlineData("3", 28.274334)]
        public void OutputSquareFigure_TriangleSquare_TrueResult(string input, double output)
        {
            var values = Converter.ToDoubleArray(input);
            figureManager.Create(values);

            var resultDouble = figureManager.GetShape().GetSquare();

            var result = Math.Round(resultDouble, 5);
            output = Math.Round(output, 5);
            Assert.Equal(output, result);
        }

        [Theory]
        [InlineData("1 1 1", 0.43)]
        [InlineData("3", 28.27)]
        public void OutputSquareFigure_TriangleSquare_FalseResult(string input, double output)
        {
            var values = Converter.ToDoubleArray(input);
            figureManager.Create(values);

            var resultDouble = figureManager.GetShape().GetSquare();

            var result = Math.Round(resultDouble, 5);
            output = Math.Round(output, 5);
            Assert.False(output == result);
        }

        [Theory]
        [InlineData("1 1 1", "triangle")]
        [InlineData("3", "circle")]
        public void OutputTypeFigure_TrueResult(string input, string output)
        {
            var values = Converter.ToDoubleArray(input);
            figureManager.Create(values);
            var result = figureManager.GetShape().GetTypeShape();
            Assert.Equal(output, result);
        }

        [Theory]
        [InlineData("3 4 5", true)]
        [InlineData("33 56 65", true)]
        public void OutputTypeTriangle_TrueResult(string input, bool output)
        {
            var values = Converter.ToDoubleArray(input);
            figureManager.Create(values);
            var result = ((Triangle)figureManager.GetShape()).CheckRightTriangle();
            Assert.Equal(output, result);
        }

        [Theory]
        [InlineData("3 4 5,1", false)]
        [InlineData("33 56 65,1", false)]
        public void OutputTypeTriangle_FalseResult(string input, bool output)
        {
            var values = Converter.ToDoubleArray(input);
            figureManager.Create(values);
            var result = ((Triangle)figureManager.GetShape()).CheckRightTriangle();
            Assert.Equal(output, result);
        }
    }

}
