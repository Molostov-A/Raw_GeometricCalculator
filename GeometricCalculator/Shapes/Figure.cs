using GeometricCalculator.Abstract;

namespace GeometricCalculator.Shapes
{
    public abstract class Figure : IFigure
    {
        public abstract double Square { get; }

        /// <summary>
        /// Тип фигуры
        /// </summary>
        public string Type => GetType().Name.ToLower();
    }
}