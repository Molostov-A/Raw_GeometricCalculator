namespace AreaFigure.Common.Figures
{
    public class Point : Shape
    {
        public Point(params double[] sides) : base(sides)
        { }
        public override double GetSquare()
        {
            return 0;
        }
        public override string GetTypeShape()
        {
            return TypeShape.point.ToString();
        }
    }
}