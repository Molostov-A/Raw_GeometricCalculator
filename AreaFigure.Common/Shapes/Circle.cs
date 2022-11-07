using System;

namespace AreaFigure.Common.Shapes
{
    public class Circle : Shape
    {
        public Circle() { }
        public Circle(params double[] sides) : base(sides)
        { }
        private protected override void SetSquare()
        {
            square = GetSquareCircle(LenghSides[0]);
        }
        private double GetSquareCircle(double radius)
        {
            return 2 * Math.PI * Math.Pow(radius, 2);
        }
    }
}