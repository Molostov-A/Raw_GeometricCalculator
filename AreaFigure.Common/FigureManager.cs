using AreaFigure.Common.Figures;

namespace AreaFigure.Common
{
    public static class FigureManager
    {
        public static Figure CreateFigure(Figure figure)
        {
            if (figure.TypeFigure == TypeFigure.point)
                return new Point(figure.LenghSides);

            if (figure.TypeFigure == TypeFigure.rectangle)
                return new Rectangle(figure.LenghSides);

            if (figure.TypeFigure == TypeFigure.circle)
                return new Circle(figure.LenghSides);

            if (figure.TypeFigure == TypeFigure.triangle)
                return new Triangle(figure.LenghSides);

            return new Polygone(figure.LenghSides);
        }
    }
}