using System;
using AreaFigure.Common;
using AreaFigure.Common.Exceptions;
using AreaFigure.Common.Helpers;
using AreaFigure.Common.Shapes;

namespace AreaFigureConsoleApp
{
    internal class Program
    {
        static StrategyShape shapeManager = new StrategyShape();
        static void Main(string[] args)
        {
            CreateShape();
            Console.WriteLine($"Type of figure - {shapeManager.GetTypeShape()}");
            CheckOnTriangleRectangular();
            Console.WriteLine($"Square = {shapeManager.GetSquare()}");
        }

        private static void CreateShape()
        {
            Console.WriteLine("Enter the parameters of the figure (values with spaces)");
            Console.WriteLine("One number - length of the radius of the circle");
            Console.WriteLine("The three values - lengths of the sides of the triangle");
            var values = Converter.ToDoubleArray(Console.ReadLine());
            TryCreateFigure(values);
        }

        private static void CheckOnTriangleRectangular()
        {
            if (shapeManager.GetTypeShape() == TypeShape.Roster[3])
            {
                Triangle triangle = (Triangle)shapeManager.GetShape();
                if (triangle.CheckRightTriangle())
                {
                    Console.WriteLine("This triangle is rectangular");
                }
                else
                {
                    Console.WriteLine("This triangle is not rectangular");
                }
            }
        }

        private static void TryCreateFigure(double[] values)
        {
            try
            {
                shapeManager.Create(values);
            }
            catch (FigureDoesNotExist e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
