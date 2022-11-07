using System;
using System.Linq;

namespace AreaFigure.Common.Helpers
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
            var value = TrySplitToArray(str).Select(double.Parse).ToArray();

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
    }
}