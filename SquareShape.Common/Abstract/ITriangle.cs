namespace GeometricCalculator.Abstract;

public interface ITriangle : IFigure
{
    double SideA { get; set; }
    double SideB { get; set; }
    double SideC { get; set; }
    bool IsRectangle { get; }
}