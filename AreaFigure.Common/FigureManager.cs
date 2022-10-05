using AreaFigure.Common.Exceptions;
using AreaFigure.Common.Figures;
using System;
using System.Linq;

namespace AreaFigure.Common
{
    public class FigureManager
    {
        public Figure CreateFigure(Figure figure)
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
        
        public double[] InputValues(string str)
        {
            if (str == "")
            {
                return new double[0];
            }

            str = str.Trim();
            var tryFigure = new TryFigure();
            var value = tryFigure.TrySplitToArray(str).Select(double.Parse).ToArray();

            return Figure.CollapseNullValues(value);
        }

        public string OutputSquareFigure(Figure figure)
        {
            string ansver;
            try
            {
                ansver = figure.GetSquare().ToString();
            }
            catch (FeatureNotImplemented e)
            {
                ansver = e.Message;
            }
            return ansver;
        }
    }
}