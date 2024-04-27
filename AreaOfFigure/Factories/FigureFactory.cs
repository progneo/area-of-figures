using AreaOfFigure.Interfaces;
using AreaOfFigure.Models;

namespace AreaOfFigure.Factory;

public static class FigureFactory
{
    public static IFigure CreateFigure(string type, params double[] dimensions)
    {
        return type.ToLower() switch
        {
            "circle" => new Circle(dimensions[0]),
            "triangle" => new Triangle(dimensions[0], dimensions[1], dimensions[2]),
            _ => throw new ArgumentException("Invalid figure type")
        };
    }
}