using System;

namespace SquareShape.Common.Shapes
{
    public class Triangle : Shape
    {
        public Triangle(){}
        public Triangle(params double[] sides) : base(sides) { }

        private protected override void SetSquare()
        {
            var a = LenghSides[0];
            var b = LenghSides[1];
            var c = LenghSides[2];
            var p = (a + b + c) / 2;
            var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Square = s;
        }

        /// <summary>
        /// Проверка, является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
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