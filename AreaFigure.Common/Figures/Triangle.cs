﻿using System;

namespace AreaFigure.Common.Figures
{
    public class Triangle : Figure
    {
        public Triangle(params double[] sides) : base(sides)
        { }
        public override double GetSquare()
        {
            var a = LenghSides[0];
            var b = LenghSides[1];
            var c = LenghSides[2];
            var p = (a + b + c) / 2;
            var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }
        public bool CheckRightTriangle()
        {
            var a = LenghSides[0];
            var b = LenghSides[1];
            var c = LenghSides[2];
            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                return true;

            if (Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2))
                return true;

            if (Math.Pow(c, 2) + Math.Pow(b, 2) == Math.Pow(a, 2))
                return true;

            return false;
        }
    }
}