using System.Collections.Generic;
using AreaFigure.Common.Exceptions;

namespace AreaFigure.Common
{
    public class Figure
    {
        private double[] lenghSide;
        

        public Figure(params double[] side)
        {
            lenghSide = side;
        }

        
        public static void СheckExistenceFigure(params double[] side)
        {
            //throw new System.NotImplementedException();
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