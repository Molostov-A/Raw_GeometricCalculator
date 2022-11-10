using GeometricCalculator.Shapes;

namespace GeometricCalculator.Abstract;

public interface IMakerFigures
{
    IFigure Create(params double[] values);
}