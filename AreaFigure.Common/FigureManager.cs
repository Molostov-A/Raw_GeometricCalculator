using AreaFigure.Common.Exceptions;
using AreaFigure.Common.Figures;
using System;
using System.Linq;

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

        public static string[] TrySplitToArray(string str)
        {
            try
            {
                var value = str.Split();
                return value;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static Figure TryExistenceFigure(double[] values)
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

        public static double[] InputValues(string str)
        {
            if (str == "")
            {
                return new double[0];
            }

            str = str.Trim();

            var value = FigureManager.TrySplitToArray(str).Select(double.Parse).ToArray();

            return Figure.CollapseNullValues(value);
        }

        public static string OutputSquareFigure(Figure figure)
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