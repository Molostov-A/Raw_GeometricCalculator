namespace SquareShape.Common.Abstract
{
    public interface IStrategyShape<TShape>
    where TShape:ISquareShape, IShape
    {
        void Create(double[] values);
        TShape GetShape();
    }
}