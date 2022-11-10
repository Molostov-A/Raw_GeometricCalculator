using System;
using System.Linq;
using GeometricCalculator.Abstract;
using GeometricCalculator.Exceptions;

namespace GeometricCalculator.Shapes
{
    public class Triangle : Figure, ITriangle
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public bool IsRectangle
        {
            get
            {
                if (Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2))
                    return true;
                if (Math.Pow(SideA, 2) + Math.Pow(SideC, 2) == Math.Pow(SideB, 2))
                    return true;
                if (Math.Pow(SideC, 2) + Math.Pow(SideB, 2) == Math.Pow(SideA, 2))
                    return true;
                return false;
            }
        }
        public override double Square
        {
            get
            {
                CheckExistenceShape(SideA, SideB, SideC);
                var p = (SideA + SideB + SideC) / 2;
                var s = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
                return s;
            }

        }

        public Triangle(double sideA, double sideB, double sideC) => (SideA, SideB, SideC) = (sideA, sideB, sideC);


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