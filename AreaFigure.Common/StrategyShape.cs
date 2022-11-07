using System.Linq;
using AreaFigure.Common.Abstract;
using AreaFigure.Common.Exceptions;
using AreaFigure.Common.Figures;
using Dawn;

namespace AreaFigure.Common
{
    public class StrategyShape : IStrategyShape<Shape>
    {
        //public IStrategyShape Shape { get; }
        private Shape shape { get; set; }
        public void Create(double[] values)
        {
            var shape = Guard.Argument(new Shape(values), nameof(values)).NotNull(); ;
            CheckExistenceShape(shape);
            this.shape = shape;
        }

        public Shape GetShape()
        {
            return shape;
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