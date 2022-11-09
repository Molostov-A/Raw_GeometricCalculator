using GeometricCalculator.Shapes;

namespace GeometricCalculator.Abstract;

public interface IMakerFigures
{
    Figure Create(params double[] values);
}