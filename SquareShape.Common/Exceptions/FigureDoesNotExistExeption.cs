using System;

namespace SquareShape.Common.Exceptions
{
    public class FigureDoesNotExistExeption : Exception
    {
        public FigureDoesNotExistExeption(string messege) : base(messege) { }
    }
}