using System.Linq;
using AreaFigure.Common.Abstract;

namespace AreaFigure.Common.Shapes
{
    public class Shape : ISquareShape, IShape
    {

        public double[] LenghSides { get; }
        private protected double square;
        public string GetTypeShape()
        {
            throw new System.NotImplementedException();
        }

        public Shape(double[] lenghSides)
        {
            LenghSides = CollapseNullValues(lenghSides);
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