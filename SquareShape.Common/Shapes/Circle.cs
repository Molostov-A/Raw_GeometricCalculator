using System;

namespace GeometryCalculator.Shapes
{
    public class Circle : Figure
    {
        private readonly double _radius;
        public Circle(double radius) => _radius = radius;

        public override double Square => Math.PI * Math.Pow(_radius, 2);
    }
}