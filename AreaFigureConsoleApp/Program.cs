using System;

namespace AreaFigureConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radiusCircle = 5;
            Console.WriteLine($"Круг с радиусом {radiusCircle}");
            PrintSquare(radiusCircle);
            double a = 3;
            double b = 4;
            double c = 5;
            Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c}");
            PrintSquare(a, b, c);
            Console.WriteLine($"Прямоугольник со сторонами {b}, {c}");
            PrintSquare(b,c);
        }

        private static void PrintSquare(double a, double b, double c)
        {
            if (CheckExistenceTriangle(a, b, c))
            {
                Console.WriteLine(GetSquareTriangle(a, b, c));                
            }
            else
            {
                Console.WriteLine("There is no such triangle");
            }
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
