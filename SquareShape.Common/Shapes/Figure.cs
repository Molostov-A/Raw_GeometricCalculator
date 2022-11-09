using GeometricCalculator.Abstract;

namespace GeometricCalculator.Shapes
{
    public class Figure : IFigure
    {
        public virtual double Square { get; }
        public string Type => GetType().Name.ToLower();
    }
}