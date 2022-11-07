using System;

namespace SquareShape.Common.Exceptions
{
    public class FigureDoesNotExist : Exception
    {
        public FigureDoesNotExist()
        { }
        public FigureDoesNotExist(string messege) : base(messege)
        { }
    }
}