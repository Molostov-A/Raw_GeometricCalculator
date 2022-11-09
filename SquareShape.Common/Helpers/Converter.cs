using System;
using System.Linq;

namespace GeometryCalculator.Helpers
{
    public static class Converter
    {
        public static double[] ToDoubleArray(string str)
        {
            if (str == "")
            {
                return new double[0];
            }

            str = str.Trim();
            var value = CollapseNullValues(TrySplitToArray(str).Select(double.Parse).ToArray());
            return value;
        }

        public static string[] TrySplitToArray(string str)
        {
            try
            {
                var value = str.Split();
                return value;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
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
    }
}