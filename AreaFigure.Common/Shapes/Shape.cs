using AreaFigure.Common.Abstract;
using System.Linq;

namespace AreaFigure.Common.Figures
{
    public class Shape : ISquareShape, IShape
    {
        public readonly double[] LenghSides;
        public Shape(double[] lenghSides)
        {
            LenghSides = CollapseNullValues(lenghSides);
        }

        /// <summary>
        /// Get the square of the figure
        /// </summary>
        /// <returns></returns>
        public virtual double GetSquare()
        {
            return -1;
        }
        public virtual string GetTypeShape()
        {
            return "shape";
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
    }
}