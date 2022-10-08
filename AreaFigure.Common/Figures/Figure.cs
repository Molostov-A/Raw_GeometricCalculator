using System;
using System.Linq;
using System.Text.Json.Serialization;
using AreaFigure.Common.Exceptions;

namespace AreaFigure.Common.Figures
{
    public class Figure
    {
        public readonly double[] LenghSides;
        public readonly TypeFigure TypeFigure;
        public double Square { get; set; }
        public string FailedMassage { get; set; }
        public Figure(params double[] sides)
        {
            LenghSides = CollapseNullValues(sides);
            TypeFigure = ShapeType();
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
        public static void СheckExistenceFigure(params double[] values)
        {
            var sides = CollapseNullValues(values);
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

        /// <summary>
        /// If there are zeros among the lengths, they are removed from the list of sides
        /// </summary>
        /// <param name="sides"></param>
        /// <returns> </returns>
        public static double[] CollapseNullValues(double[] sides)
        {
            var notZeroSide = sides.Select(x => x).Where(x => x != 0).ToArray();
            return notZeroSide;
        }

        /// <summary>
        /// Get the square of the figure
        /// </summary>
        /// <returns></returns>
        public virtual double GetSquare()
        {
            return -1;
        }

        /// <summary>
        /// Return the shape type as a text string
        /// </summary>
        /// <returns></returns>
        public string GetТypeFigureString()
        {
            var type = ShapeType();
            return type.ToString();
        }

        public TypeFigure ShapeType()
        {
            if (LenghSides.Length == 0)
                return TypeFigure.point;
            if (LenghSides.Length == 1)
                return TypeFigure.circle;
            if (LenghSides.Length == 2)
                return TypeFigure.rectangle;
            if (LenghSides.Length == 3)
                return TypeFigure.triangle;
            return TypeFigure.polygon;
        }
    }
}