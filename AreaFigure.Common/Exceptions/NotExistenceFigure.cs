using System;

namespace AreaFigure.Common.Exceptions
{
    public class NotExistenceFigure : Exception
    {
        public NotExistenceFigure()
        { }
        public NotExistenceFigure(string messege) : base(messege)
        { }
    }
}