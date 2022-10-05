using System;

namespace AreaFigure.Common.Figures
{
    public class Triangle : Figure
    {
        public Triangle(params double[] sides) : base(sides)
        { }
        public override double GetSquare()
        {
            return GetSquareTriangle(LenghSides[0], LenghSides[1], LenghSides[2]);
        }
        private double GetSquareTriangle(double a, double b, double c)
        {
            var p = (a + b + c) / 2;
            var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }
    }
}