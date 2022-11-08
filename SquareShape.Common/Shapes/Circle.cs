using System;

namespace SquareShape.Common.Shapes
{
    public class Circle : Shape
    {
        public Circle() { }
        public Circle(params double[] sides) : base(sides) { }

        private protected override void SetSquare()
        {
            Square = GetSquareCircle(LenghSides[0]);
        }

        private double GetSquareCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}