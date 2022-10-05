using System;
using System.Drawing;
using System.Linq;
using AreaFigure.Common;
using AreaFigure.Common.Exceptions;
using AreaFigure.Common.Figures;

namespace AreaFigureConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var figure = CreateFigure();
            figure = FigureManager.CreateFigure(figure);
            if (figure != null)
            {
                Console.WriteLine($"Type of figure - {figure.GetТypeFigureString()}");
                CheckOnTriangleRectangular(figure);
                Console.WriteLine($"Square = {FigureManager.OutputSquareFigure(figure)}");
                
            }
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

        private static Figure CreateFigure()
        {
            Console.WriteLine("Enter the parameters of the figure (values with spaces)");
            Console.WriteLine("One number - length of the radius of the circle");
            Console.WriteLine("Two values - the length of the sides of the rectangle");
            Console.WriteLine("The three values - lengths of the sides of the triangle");
            var values = FigureManager.InputValues(Console.ReadLine());
            return FigureManager.TryExistenceFigure(values);
        }
    }
}
