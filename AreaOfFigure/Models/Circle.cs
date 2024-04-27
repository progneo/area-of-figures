using AreaOfFigure.Interfaces;

namespace AreaOfFigure.Models;

public class Circle(double radius) : IFigure
{
    public double Radius { get; set; } = radius;


    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}