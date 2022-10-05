namespace AreaFigure.Common.Figures
{
    public class Rectangle : Figure
    {
        public Rectangle(params double[] sides) : base(sides)
        { }
        public override double GetSquare()
        {
            return GetSquareRectangle(LenghSides[0], LenghSides[1]);
        }
        private double GetSquareRectangle(double a, double b)
        {
            return a * b;
        }
    }
}