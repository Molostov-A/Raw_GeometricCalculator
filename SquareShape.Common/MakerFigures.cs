using System;
using System.Linq;
using GeometryCalculator.Abstract;
using GeometryCalculator.Shapes;

namespace SquareShape.Common;

public class MakerFigures:IMakerFigures
{
    public Figure Create(params double[] values)
    {
        if(values.Length == 1)
            return Create(values[0]);
        if (values.Length == 3)
            return Create(values[0], values[1], values[2]);
        throw new Exception("Реализация фигуры с данными параметрами отсутствует");
    }
    private Triangle Create(double sideA, double sideB, double sideC) => new (sideA, sideB, sideC);
    private Circle Create(double radius) => new (radius);
}