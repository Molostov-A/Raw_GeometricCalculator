using System.Linq;
using Dawn;
using SquareShape.Common.Abstract;
using SquareShape.Common.Exceptions;
using SquareShape.Common.Shapes;

namespace SquareShape.Common
{
    public class StrategyShape : IStrategyShape<Shape>
    {
        private Shape shape { get; set; }

        /// <summary>
        /// Создание фигуры, в соответствие с количеством введённых сторон
        /// </summary>
        /// <param name="values">количество введенных сторон</param>
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

        /// <summary>
        /// Вывод упакованной фигуры
        /// </summary>
        /// <returns></returns>
        public Shape GetShape()
        {
            return shape;
        }

        ///  <summary>
        ///  Проверка того, что фигура может существовать с заданными длинами сторон
        ///  </summary>
        ///  <exception cref="FigureDoesNotExist">
        /// Ошибка, которая означает что такая фигура не может существовать 
        /// </exception>
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