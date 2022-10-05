using System.Collections.Generic;
using System.Linq;
using AreaFigure.Common.Exceptions;

namespace AreaFigure.Common
{
    public class Figure
    {
        private double[] lenghSide;
        

        public Figure(params double[] sides)
        {
            lenghSide = CollapseNullValues(sides);
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
            return 0;
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
            var type = ShapeType(lenghSide);
            return type.ToString();
        }
    }
}