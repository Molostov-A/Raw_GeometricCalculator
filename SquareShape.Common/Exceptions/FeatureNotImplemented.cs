using System;

namespace SquareShape.Common.Exceptions
{
    public class FeatureNotImplemented : Exception
    {
        public FeatureNotImplemented()
        {}
        public FeatureNotImplemented(string messege) : base(messege)
        { }
    }
}