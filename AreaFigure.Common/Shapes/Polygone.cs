using AreaFigure.Common.Exceptions;

namespace AreaFigure.Common.Figures
{
    public class Polygone : Shape
    {
        public Polygone(params double[] sides) : base(sides)
        { }
        public override double GetSquare()
        {
            throw new FeatureNotImplemented("this feature has not yet been implemented");
        }

        public override string GetTypeShape()
        {
            return TypeShape.polygon.ToString();
        }
    }
}