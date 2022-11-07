using System.Linq;
using SquareShape.Common.Abstract;

namespace SquareShape.Common.Shapes
{
    public class Shape : ISquareShape, IShape
    {
        /// <summary>
        /// Длины сторон
        /// </summary>
        public double[] LenghSides { get; }
        private protected double Square;
        private readonly string _type;
        public Shape(){}
        public Shape(double[] lenghSides)
        {
            LenghSides = CollapseNullValues(lenghSides);
            _type = GetType().Name.ToLower();
            SetSquare();
        }

        /// <summary>
        /// Вывод типа фигуры
        /// </summary>
        /// <returns></returns>
        public string GetTypeShape()
        {
            return _type;
        }

        /// <summary>
        /// Если среди длин есть нули, метод удаляет их из списка сторон
        /// </summary>
        /// <param name="sides">Длины сторон</param>
        /// <returns> </returns>
        private static double[] CollapseNullValues(double[] sides)
        {
            var notZeroSide = sides.Select(x => x).Where(x => x != 0).ToArray();
            return notZeroSide;
        }

        /// <summary>
        /// Вывод вычесленной, при создании объекта, площади фигуры
        /// </summary>
        /// <returns></returns>
        public double GetSquare()
        {
            return Square;
        }

        private protected virtual void SetSquare()
        {
            Square = -1;
        }
    }
}