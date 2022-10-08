using AreaFigure.Common.Figures;

namespace AreaFigure.Common.Interface
{
    public interface IFigureManager
    {        
        Figure CreateFigure(double[] values);
    }
}