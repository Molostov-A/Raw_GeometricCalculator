using System;
using System.Collections.Generic;
using System.Linq;
using AreaFigure.Common.Abstract;
using AreaFigure.Common.Exceptions;
using AreaFigure.Common.Shapes;
using Dawn;

namespace AreaFigure.Common
{
    public class StrategyShape : IStrategyShape<Shape>
    {
        private Shape shape { get; set; }
        public void Create(double[] values)
        {
            shape = Guard.Argument(new Shape(values), nameof(values)).NotNull();
            CheckExistenceShape(shape);
            if (shape.LenghSides.Length == 0)
            {
                var shapeFigure = new Point(shape.LenghSides);
                shape = shapeFigure;
            }
            if (shape.LenghSides.Length == 1)
            {
                var shapeFigure = new Circle(shape.LenghSides);
                shape = shapeFigure;
            }
            if (shape.LenghSides.Length == 2)
            {
                var shapeFigure = new Rectangle(shape.LenghSides);
                shape = shapeFigure;
            }
            if (shape.LenghSides.Length == 3)
            {
                var shapeFigure = new Triangle(shape.LenghSides);
                shape = shapeFigure;
            }
            if (shape.LenghSides.Length > 3)
            {
                var shapeFigure = new Polygone(shape.LenghSides);
                shape = shapeFigure;
            }
            else
            {
                var shapeFigure = shape;
                shape = shapeFigure;
            }
        }

        public Shape GetShape()
        {
            return shape;
        }

        public double GetSquare()
        {
            return shape.GetSquare();
        }

        public string GetTypeShape()
        {
            return shape.GetTypeShape();
        }

        /// <summary>
        /// Checking that a shape can exist with the given lengths of the sides
        /// </summary>
        /// <param name="values">
        /// Values of the lengths of the sides. 
        ///Exceptions: 
        ///1. there are no sides - it is a point
        ///2. one side is the radius of the circle
        ///3. two sides are sides of a rectangle
        /// </param>
        /// <exception cref="FigureDoesNotExist"></exception>
        private static void CheckExistenceShape(Shape shape)
        {
            var sides = shape.LenghSides;
            if (sides.Length > 2)
            {
                var perimeter = sides.Sum();
                for (int i = 0; i < sides.Length; i++)
                {
                    if (perimeter - sides[i] <= sides[i])
                        throw new FigureDoesNotExist("This figure does not exist");
                }
            }
        }
    }
}