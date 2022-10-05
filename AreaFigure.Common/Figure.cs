using System;
using System.Collections.Generic;
using System.Linq;
using AreaFigure.Common.Exceptions;

namespace AreaFigure.Common
{
    public class Figure
    {
        private double[] lenghSides;
        

        public Figure(params double[] sides)
        {
            lenghSides = CollapseNullValues(sides);
        }

        
        public static void СheckExistenceFigure(params double[] values)
        {
            var sides = CollapseNullValues(values);
            if (sides.Length > 2)
            {
                var perimeter = sides.Sum();
                for (int i = 0; i < sides.Length; i++)
                {
                    if (perimeter - sides[i] <= sides[i])
                        throw new FigureDoesNotExist("This figure does not exist");
                }
            }
        }

        public static double[] CollapseNullValues(double[] sides)
        {
            var notZeroSide = sides.Select(x => x).Where(x => x != 0).ToArray();
            return notZeroSide;
        }

        public double GetSquare()
        {
            if (lenghSides.Length == 0)
                return 0;
            if (lenghSides.Length == 1)
                return GetSquareCircle(lenghSides[0]);
            if (lenghSides.Length == 2)
                return GetSquareRectangle(lenghSides[0], lenghSides[1]);
            if (lenghSides.Length == 3)
                return GetSquareTriangle(lenghSides[0], lenghSides[1], lenghSides[2]);
            return GetSquarePolygon(lenghSides);
        }

        private double GetSquareCircle(double radius)
        {
            return 2 * Math.PI * Math.Pow(radius, 2);
        }

        private double GetSquareRectangle(double a, double b)
        {
            return a * b;
        }

        private double GetSquareTriangle(double a, double b, double c)
        {
            var p = (a + b + c)/2;
            var s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return s;
        }

        private double GetSquarePolygon(double[] doubles)
        {
            throw new System.NotImplementedException();
        }

        public TypeFigure ShapeType(double[] lenghSide)
        {
            if (lenghSide.Length == 0)
                return TypeFigure.point;
            if (lenghSide.Length == 1)
                return TypeFigure.circle;
            if (lenghSide.Length == 2)
                return TypeFigure.rectangle;
            if (lenghSide.Length == 3)
                return TypeFigure.triangle;
            return TypeFigure.polygon;
        }

        public string GetТypeFigure()
        {
            var type = ShapeType(lenghSides);
            return type.ToString();
        }
    }
}