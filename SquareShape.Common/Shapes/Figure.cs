using GeometriсCalculator.Abstract;

namespace GeometriсCalculator.Shapes
{
    public class Figure : IFigure
    {
        public virtual double Square { get; }
        public string TypeShape => GetType().Name.ToLower();
    }
}