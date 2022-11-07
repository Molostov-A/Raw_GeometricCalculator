using AreaFigure.Common;
using AreaFigure.Common.Figures;
using AreaFigureWebApi.Models;

namespace AreaFigureWebApi.Helpers
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