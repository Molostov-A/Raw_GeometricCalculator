using System;

namespace AreaFigure.Common.Exceptions
{
    public class FigureDoesNotExist : Exception
    {
        public FigureDoesNotExist()
        { }
        public FigureDoesNotExist(string messege) : base(messege)
        { }
    }
}