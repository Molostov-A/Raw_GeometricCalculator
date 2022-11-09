using System;

namespace GeometriсCalculator.Exceptions
{
    public class FigureDoesNotExistExeption : Exception
    {
        public FigureDoesNotExistExeption(string messege) : base(messege) { }
    }
}