using AreaFigure.Common.Exceptions;
using AreaFigure.Common.Figures;
using System;
using System.Linq;

namespace AreaFigure.Common
{
    public class FigureManager
    {
       public Figure CreateFigure(double[] values)
        {
            var figure = TryExistenceFigure(values);
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

        private Figure TryExistenceFigure(double[] values)
        {
            try
            {
                Figure.СheckExistenceFigure(values);
                return new Figure(values);
            }
            catch (FigureDoesNotExist e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }


    }
}