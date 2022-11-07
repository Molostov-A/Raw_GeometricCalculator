using System;
using AreaFigure.Common;
using AreaFigure.Common.Figures;
using AreaFigure.Common.Helpers;
using Xunit;

namespace AreaFigureUnitTest
{
    public class StrategyShape_TestClass
    {
        StrategyShape figureManager = new StrategyShape();


        [Theory]
        [InlineData("1 1 1", 0.433012)]
        [InlineData("3 4 5", 6)]
        public void OutputSquareFigure_TriangleSquare_TrueResult(string input, double output)
        {
            var values = Converter.ToDoubleArray(input);
            figureManager.Create(values);

            var resultDouble = figureManager.GetShape().GetSquare();

            var result = Math.Round(resultDouble, 5);
            output = Math.Round(output, 5);
            Assert.Equal(output, result);
        }
    }

}
