using AreaFigure.Common.Figures;
using AreaFigureWebApi.Models;

namespace AreaFigureWebApi.Helpers
{
    public static class Mapping
    {
        public static InformAboutFigure ToInformAboutFigure(Figure figure)
        {
            InformAboutFigure infFigure = new InformAboutFigure()
            {
                Type = figure.GetТypeFigureString(),
                Sides = figure.LenghSides,
                Square = figure.GetSquare(),
                FailedMassage = figure.FailedMassage
            };
            return infFigure;
        }
    }
}