using System;

namespace GeometryCalculator.Exceptions
{
    public class FigureDoesNotExistExeption : Exception
    {
        public FigureDoesNotExistExeption(string messege) : base(messege) { }
    }
}