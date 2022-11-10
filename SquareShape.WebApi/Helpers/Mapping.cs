using GeometricCalculator.Abstract;
using SquareShape.WebApi.Models;

namespace SquareShape.WebApi.Helpers
{
    public static class Mapping
    {
        public static InformAboutFigure ToInformAboutFigure(IFigure figure)
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