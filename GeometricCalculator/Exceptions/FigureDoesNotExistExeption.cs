using System;

namespace GeometricCalculator.Exceptions
{
    public class FigureDoesNotExistExeption : Exception
    {
        public FigureDoesNotExistExeption(string messege) : base(messege) { }
    }
}