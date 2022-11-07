using SquareShape.Common.Exceptions;

namespace SquareShape.Common.Shapes
{
    public class Polygone : Shape
    {
        public Polygone() { }
        public Polygone(params double[] sides) : base(sides) { }

        private protected override void SetSquare()
        {
            throw new FeatureNotImplemented("this feature has not yet been implemented");
        }
    }
}