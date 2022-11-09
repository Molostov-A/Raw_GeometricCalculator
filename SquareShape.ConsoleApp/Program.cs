using System;
using GeometricCalculator.Abstract;
using GeometricCalculator.Exceptions;
using GeometricCalculator.Helpers;
using SquareShape.Common;

namespace SquareShape.ConsoleApp
{
    internal class Program
    {
        static MakerFigures _makerFigures = new MakerFigures();
        static void Main(string[] args)
        {
            Console.WriteLine("Введите параметры фигуры (значения с пробелами)");
            Console.WriteLine("Одно число - длина радиуса окружности");
            Console.WriteLine("Три числа - длины сторон треугольника");
            var values = Converter.ToDoubleArray(Console.ReadLine());
            try
            {
                var figure = _makerFigures.Create(values);
                Console.WriteLine($"Тип фигуры - {figure.Type}");
                if (figure is ITriangle triangle)
                {
                    CheckOnTriangleRectangular(triangle.IsRectangle);
                }

                Console.WriteLine($"Площадь = {figure.Square}");
            }
            catch (FigureDoesNotExistExeption e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void CheckOnTriangleRectangular(bool isRect)
        {
            if (isRect)
            {
                Console.WriteLine("Этот треугольник - прямоугольный");
            }
            else
            {
                Console.WriteLine("Этот треугольник не прямоугольный");
            }
        }
    }
}
