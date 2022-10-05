using AreaFigure.Common.Exceptions;
using AreaFigure.Common.Figures;
using System;

namespace AreaFigure.Common
{
    public class TryFigure
    {
        public string[] TrySplitToArray(string str)
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

        public Figure TryExistenceFigure(double[] values)
        {
            try
            {
                Figure.СheckExistenceFigure(values);
                return new Figure(values);
            }
            catch (FigureDoesNotExist e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}