using SquareShape.Common;
using SquareShape.Common.Shapes;
using SquareShape.WebApi.Models;

namespace SquareShape.WebApi.Helpers
{
    public static class Mapping
    {
        public static InformAboutFigure ToInformAboutFigure(Shape figure)
        {
            InformAboutFigure infFigure = new InformAboutFigure()
            {
                Type = figure.GetTypeShape(),
                Sides = figure.LenghSides,
                Square = figure.GetSquare()
            };
            return infFigure;
        }
    }
}