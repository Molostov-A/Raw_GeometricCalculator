namespace AreaFigure.Common.Figures
{
    public class Rectangle : Shape
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

        public override string GetTypeShape()
        {
            return TypeShape.rectangle.ToString();
        }
    }
}