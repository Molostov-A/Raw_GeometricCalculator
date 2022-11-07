namespace SquareShape.Common.Shapes
{
    public class Point : Shape
    {
        public Point() { }
        public Point(params double[] sides) : base(sides) { }

        private protected override void SetSquare()
        {
            Square = 0;
        }
    }
}