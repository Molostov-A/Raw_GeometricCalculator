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
            if (figure != null)
            {
                Console.WriteLine($"Type of figure - {figure.GetТypeFigure()}");
                Console.WriteLine($"Square = {figure.GetSquare()}");
            }
        }

        private static Figure CreateFigure()
        {
            Console.WriteLine("Enter the parameters of the figure (values with spaces)");
            Console.WriteLine("One number - length of the radius of the circle");
            Console.WriteLine("Two values - the length of the sides of the rectangle");
            Console.WriteLine("The three values - lengths of the sides of the triangle");
            var values = InputValues();
            return CheckExistenceFigure(values);
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

        private static Figure CheckExistenceFigure(double[] values)
        {
            try
            {
                Figure.СheckExistenceFigure(values);
                return new Figure(values);
            }
            catch (FigureDoesNotExist e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
