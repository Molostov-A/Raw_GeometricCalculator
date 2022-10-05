using System;
using AreaFigure.Common;
using AreaFigure.Common.Figures;
using Xunit;

namespace AreaFigureUnitTest
{
    public class FigureManager_TestClass
    {
        FigureManager figureManager = new FigureManager();

        [Theory]
        [InlineData("1 1 1", 0.433012)]
        [InlineData("3 4 5", 6)]
        public void OutputSquareFigure_TriangleSquare_TrueResult(string input, double output)
        {
            
            var values = figureManager.InputValues(input);
            var figure = figureManager.CreateFigure(values);

            var resultText = figureManager.OutputSquareFigure(figure);
            var resultDouble = Convert.ToDouble(resultText);

            var result = Math.Round(resultDouble, 5);
            output = Math.Round(output, 5);
            Assert.Equal(output, result);
        }
        
    }

}
