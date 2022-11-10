using System;

namespace GeometricCalculator.Shapes
{
    public class Circle : Figure
    {
        private readonly double _radius;

        /// <summary>
        /// Создаём круг по полученному радиусу
        /// </summary>
        /// <param name="radius">радиус</param>
        public Circle(double radius) => _radius = radius;

        /// <summary>
        /// Площадь круга
        /// </summary>
        public override double Square => Math.PI * Math.Pow(_radius, 2);
    }
}