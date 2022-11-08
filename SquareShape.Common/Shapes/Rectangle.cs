namespace SquareShape.Common.Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(){}
        public Rectangle(params double[] sides) : base(sides) { }

        private protected override void SetSquare()
        {
            Square = GetSquareRectangle(LenghSides[0], LenghSides[1]);
        }
        private double GetSquareRectangle(double a, double b)
        {
            return a * b;
        }
    }
}