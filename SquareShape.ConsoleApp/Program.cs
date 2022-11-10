using System;
using GeometricCalculator;
using GeometricCalculator.Abstract;
using GeometricCalculator.Exceptions;
using GeometricCalculator.Helpers;
using GeometricCalculator.Shapes;

namespace SquareShape.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите параметры фигуры (значения с пробелами)");
            Console.WriteLine("Одно число - длина радиуса окружности");
            Console.WriteLine("Три числа - длины сторон треугольника");
            var values = Converter.ToDoubleArray(Console.ReadLine());
            try
            {
                IFigure figure;
                bool isRect;
                if (values.Length == 1)
                {
                    Circle circle = new Circle(values[0]);
                    figure = circle;
                }
                if (values.Length == 3)
                {
                     Triangle triangle = new Triangle(values[0], values[1], values[2]);
                     isRect = triangle.IsRectangle;
                     figure = triangle;
                }
                else
                {
                    throw new Exception("Реализация фигуры с данными параметрами отсутствует");
                }

                Console.WriteLine($"Тип фигуры - {(figure).Type}");
                CheckOnTriangleRectangular(isRect);
                Console.WriteLine($"Площадь = {figure.Square}");
                Console.WriteLine();
                ((Triangle) figure)._sideA = 2;
                Console.WriteLine(figure.Square);
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
