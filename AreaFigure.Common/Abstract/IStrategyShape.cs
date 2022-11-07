namespace AreaFigure.Common.Abstract
{
    public interface IStrategyShape<TShape>
    where TShape:ISquareShape, IShape
    {
        void Create(double[] values);
        TShape GetShape();
        double GetSquare();
    }
}