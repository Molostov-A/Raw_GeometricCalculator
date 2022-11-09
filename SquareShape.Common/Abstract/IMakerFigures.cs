using GeometryCalculator.Shapes;

namespace GeometryCalculator.Abstract;

public interface IMakerFigures
{
    Figure Create(params double[] values);
}