using System;
using System.Drawing;
using System.Linq;
using AreaFigure.Common;
using AreaFigure.Common.Exceptions;

namespace AreaFigureConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var figure = CreateFigure();
            Console.WriteLine($"Тип фигуры - {figure.GetТypeFigure()}");
            Console.WriteLine($"Площадь = {figure.GetSquare()}");
        }

        private static Figure CreateFigure()
        {
            Console.WriteLine("Введите параметры фигуры (значения через пробел)");
            Console.WriteLine("Одно значение - длина радиуса круга");
            Console.WriteLine("Два значения - длина сторон прямоугольника");
            Console.WriteLine("Три значения - длины сторон треугольника");
            var values = InputValues();
            try
            {
                Figure.СheckExistenceFigure();
                return new Figure(values);
            }
            catch (FigureDoesNotExist)
            {
                Console.WriteLine("Такой фигуры не существует");
                return null;
            }
        }

        private static double[] InputValues()
        {
            var str = Console.ReadLine();
            if (str == "")
            {
                return new double[0];
            }
            var value = str.Split().Select(double.Parse).ToArray();
            return Figure.CollapseNullValues(value);
        }







        private static void PrintSquare(double a, double b)
        {
            Console.WriteLine(GetSquareRectangle(a, b));
        }

        private static void PrintSquare(double radius)
        {
            Console.WriteLine(GetSquareCircle(radius));
        }


        static double GetSquareCircle(double radius)
        {
            return 2 * Math.PI * Math.Pow(radius, 2);
        }
        static double GetSquareRectangle(double a, double b)
        {
            return a*b;
        }

        static double GetSquareTriangle(double side1, double side2, double side3)
        {
            var p = side1 + side2 + side3;
            var s = Math.Sqrt((p * (p - side1) * (p - side2) * (p - side3)));
            return s;
        }

        private static bool CheckExistenceTriangle(double a, double b, double c)
        {
            if (!((a + b) > c))
            {
                return false;
            }
            if (!((a + c) > b))
            {
                return false;
            }
            if (!((b + c) > a))
            {
                return false;
            }
            return true;
        }
    }
}
