using System;

namespace AreaFigureConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radiusCircle = 5;
            Console.WriteLine($"Круг с радиусом {radiusCircle}");
            PrintArea(radiusCircle);
            double a = 3;
            double b = 4;
            double c = 5;
            Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c}");
            PrintArea(a, b, c);
            Console.WriteLine($"Прямоугольник со сторонами {b}, {c}");
            PrintArea(b,c);
        }

        private static void PrintArea(double a, double b, double c)
        {
            if (CheckExistenceTriangle(a, b, c))
            {
                Console.WriteLine(GetAreaTriangle(a, b, c));
            }
            else
            {
                Console.WriteLine("There is no such triangle");
            }
        }

        private static void PrintArea(double a, double b)
        {
            Console.WriteLine(GetAreaRectangle(a, b));
        }

        private static void PrintArea(double radius)
        {
            Console.WriteLine(GetAreaCircle(radius));
        }


        static double GetAreaCircle(double radius)
        {
            return 2 * Math.PI * Math.Pow(radius, 2);
        }
        static double GetAreaRectangle(double a, double b)
        {
            return a*b;
        }

        static double GetAreaTriangle(double side1, double side2, double side3)
        {
            var p = side1 + side2 + side3;
            var s = Math.Sqrt((p * (p - side1) * (p - side2) * (p - side3)));
            return s;
        }

        private static bool CheckExistenceTriangle(double a, double b, double c)
        {
            var existence = true;

            if (!((a + b) > c))
            {
                existence = false;
            }
            if (!((a + c) > b))
            {
                existence = false;
            }
            if (!((b + c) > a))
            {
                existence = false;
            }
            return existence;
        }
    }
}
