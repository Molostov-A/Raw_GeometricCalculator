using AreaFigure.Common.Exceptions;
using AreaFigure.Common.Figures;
using System;
using System.Linq;
using AreaFigure.Common.Interface;

namespace AreaFigure.Common
{
    public class FigureManager:IFigureManager
    {
        public string OutputSquareOrFalied(Figure figure)
        {
           string ansver;
           try
           {
               ansver = figure.GetSquare().ToString();
           }
           catch (FeatureNotImplemented e)
           {
               figure.FailedMassage = e.Message;
               ansver = e.Message;
           }
           return ansver;
        }

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