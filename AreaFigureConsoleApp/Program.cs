using System;
using AreaFigure.Common;
using AreaFigure.Common.Figures;
using AreaFigure.Common.Helpers;

namespace AreaFigureConsoleApp
{
    internal class Program
    {
        private static FigureManager figureManager = new FigureManager();

        static void Main(string[] args)
        {
            var figure = CreateFigure();
            if (figure != null)
            {
                Console.WriteLine($"Type of figure - {figure.GetТypeFigureString()}");
                CheckOnTriangleRectangular(figure);
                Console.WriteLine($"Square = {figureManager.OutputSquareOrFalied(figure)}");
            }
        }

        private static Figure CreateFigure()
        {
            Console.WriteLine("Enter the parameters of the figure (values with spaces)");
            Console.WriteLine("One number - length of the radius of the circle");
            Console.WriteLine("Two values - the length of the sides of the rectangle");
            Console.WriteLine("The three values - lengths of the sides of the triangle");
            var values = Converter.ToDoubleArray(Console.ReadLine());
            var figure = figureManager.CreateFigure(values);
            return figure;
        }

        private static void CheckOnTriangleRectangular(Figure figure)
        {
            if (figure.TypeFigure == TypeFigure.triangle)
            {
                var triangle = (Triangle)figure;
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
    }
}
