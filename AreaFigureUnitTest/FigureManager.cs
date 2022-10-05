using System;
using AreaFigure.Common;
using AreaFigure.Common.Figures;
using Xunit;

namespace AreaFigureUnitTest
{
    public class FigureManager_TestClass
    {

        [Theory]
        [InlineData("1 1 1", 0.433012)]
        [InlineData("3 4 5", 6)]
        public void OutputSquareFigure_TriangleSquare_TrueResult(string input, double output)
        {
            FigureManager figureManager = new FigureManager();
            var values = figureManager.InputValues(input);
            var figure = figureManager.CreateFigure(values);

            var resultText = figureManager.OutputSquareFigure(figure);
            var resultDouble = Convert.ToDouble(resultText);

            resultDouble = Math.Round(resultDouble, 5);
            output = Math.Round(output, 5);
            Assert.Equal(output, resultDouble);
        }
        
    }

}
