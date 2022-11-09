using GeometriсCalculator.Shapes;

namespace GeometriсCalculator.Abstract;

public interface IMakerFigures
{
    Figure Create(params double[] values);
}