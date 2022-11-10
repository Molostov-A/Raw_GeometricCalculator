using System;
using System.Linq;
using GeometricCalculator.Abstract;
using GeometricCalculator.Exceptions;

namespace GeometricCalculator.Shapes
{
    public class Triangle : Figure, ITriangle
    {
        private double sideA { get; }
        private double sideB { get; }
        private double sideC { get; }

        /// <summary>
        /// Является ли треугольник прямоугольником
        /// </summary>
        public bool IsRectangle
        {
            get
            {
                if (Math.Pow(sideA, 2) + Math.Pow(sideB, 2) == Math.Pow(sideC, 2))
                    return true;
                if (Math.Pow(sideA, 2) + Math.Pow(sideC, 2) == Math.Pow(sideB, 2))
                    return true;
                if (Math.Pow(sideC, 2) + Math.Pow(sideB, 2) == Math.Pow(sideA, 2))
                    return true;
                return false;
            }
        }

        /// <summary>
        /// Площадь треугольника
        /// </summary>
        public override double Square
        {
            get
            {
                CheckExistenceShape(sideA, sideB, sideC);
                var p = (sideA + sideB + sideC) / 2;
                var s = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
                return s;
            }

        }

        /// <summary>
        /// Создание треугольника по трём полученным сторнам
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        public Triangle(double sideA, double sideB, double sideC) => (this.sideA, this.sideB, this.sideC) = (sideA, sideB, sideC);


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