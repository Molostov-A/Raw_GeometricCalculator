using System;
using System.Linq;

namespace GeometricCalculator.Helpers
{
    public static class Converter
    {
        /// <summary>
        /// Перевод строки чисел в массив
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Разделение строки на строки чисел по пробелу
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
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