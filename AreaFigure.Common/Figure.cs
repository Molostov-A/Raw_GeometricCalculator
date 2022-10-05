﻿using System.Collections.Generic;

namespace AreaFigure.Common
{
    public class Figure
    {
        private double[] lenghSide;
        

        public Figure(params double[] side)
        {
            СheckExistenceFigure(side);
            lenghSide = side;
        }

        private void СheckExistenceFigure(double[] side)
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
    }
}