using GeometricCalculator.Shapes;
using SquareShape.Common;
using SquareShape.WebApi.Models;

namespace SquareShape.WebApi.Helpers
{
    public static class Mapping
    {
        public static InformAboutFigure ToInformAboutFigure(Figure figure)
        {
            InformAboutFigure infFigure = new InformAboutFigure()
            {
                Type = figure.Type,
                Square = figure.Square
            };
            return infFigure;
        }
    }
}