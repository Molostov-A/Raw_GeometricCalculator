using GeometricCalculator.Abstract;

namespace GeometricCalculator.Shapes
{
    public abstract class Figure : IFigure
    {
        public abstract double Square { get; }
        public string Type => GetType().Name.ToLower();
    }
}