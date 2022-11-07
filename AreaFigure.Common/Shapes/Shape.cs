using System.Linq;
using SquareShape.Common.Abstract;

namespace SquareShape.Common.Shapes
{
    public class Shape : ISquareShape, IShape
    {

        public double[] LenghSides { get; }
        private protected double square;
        private readonly string _type;
        public string GetTypeShape()
        {
            return _type;
        }
        public Shape(){}
        public Shape(double[] lenghSides)
        {
            LenghSides = CollapseNullValues(lenghSides);
            _type = GetType().Name.ToLower();
            SetSquare();
        }

        /// <summary>
        /// If there are zeros among the lengths, they are removed from the list of sides
        /// </summary>
        /// <param name="sides"></param>
        /// <returns> </returns>
        private static double[] CollapseNullValues(double[] sides)
        {
            var notZeroSide = sides.Select(x => x).Where(x => x != 0).ToArray();
            return notZeroSide;
        }

        public double GetSquare()
        {
            return square;
        }

        private protected virtual void SetSquare()
        {
            square = -1;
        }
    }
}