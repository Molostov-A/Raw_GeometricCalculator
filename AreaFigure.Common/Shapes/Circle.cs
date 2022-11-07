﻿using System;

namespace AreaFigure.Common.Figures
{
    public class Circle : Shape
    {
        public Circle(params double[] sides) : base(sides)
        { }
        public override double GetSquare()
        {
            return GetSquareCircle(LenghSides[0]);
        }
        private double GetSquareCircle(double radius)
        {
            return 2 * Math.PI * Math.Pow(radius, 2);
        }
        public override string GetTypeShape()
        {
            return TypeShape.circle.ToString();
        }
    }
}