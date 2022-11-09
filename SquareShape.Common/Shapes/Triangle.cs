using System;
using System.Linq;
using GeometricCalculator.Abstract;
using GeometricCalculator.Exceptions;

namespace GeometricCalculator.Shapes
{
    public class Triangle : Figure, ITriangle
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;
        public bool IsRectangle
        {
            get
            {
                if (Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2) == Math.Pow(_sideC, 2))
                    return true;
                if (Math.Pow(_sideA, 2) + Math.Pow(_sideC, 2) == Math.Pow(_sideB, 2))
                    return true;
                if (Math.Pow(_sideC, 2) + Math.Pow(_sideB, 2) == Math.Pow(_sideA, 2))
                    return true;
                return false;
            }
        }
        public override double Square
        {
            get
            {
                CheckExistenceShape(_sideA, _sideB, _sideC);
                var p = (_sideA + _sideB + _sideC) / 2;
                var s = Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
                return s;
            }

        }

        public Triangle(double sideA, double sideB, double sideC) => (_sideA, _sideB, _sideC) = (sideA, sideB, sideC);


        ///  <summary>
        ///  Проверка того, что фигура может существовать с заданными длинами сторон
        ///  </summary>
        ///  <exception cref="FigureDoesNotExistExeption">
        /// Ошибка, которая означает что такая фигура не может существовать 
        /// </exception>
        private static void CheckExistenceShape(params double[] sides)
        {
         if (sides.Length > 2)
         {
             var perimeter = sides.Sum();
             for (int i = 0; i < sides.Length; i++)
             {
                 if (perimeter - sides[i] <= sides[i])
                     throw new FigureDoesNotExistExeption("Такого треугольника не существует");
             }
         }
        }
    }
}