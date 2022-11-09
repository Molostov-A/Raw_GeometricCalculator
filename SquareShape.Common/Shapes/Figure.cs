using GeometryCalculator.Abstract;

namespace GeometryCalculator.Shapes
{
    public class Figure : IFigure
    {
        public virtual double Square { get; }
        public string TypeShape => GetType().Name.ToLower();
    }
}