using System;

namespace AreaFigure.Common.Exceptions
{
    public class FeatureNotImplemented : Exception
    {
        public FeatureNotImplemented()
        {}
        public FeatureNotImplemented(string messege) : base(messege)
        { }
    }
}