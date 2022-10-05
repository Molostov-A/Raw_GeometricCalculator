namespace AreaFigure.Common.Figures
{
    public class Point : Figure
    {
        public Point(params double[] sides) : base(sides)
        { }
        public override double GetSquare()
        {
            return 0;
        }
    }
}