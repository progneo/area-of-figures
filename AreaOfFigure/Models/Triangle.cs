using AreaOfFigure.Interfaces;

namespace AreaOfFigure.Models;

public class Triangle(double sideA, double sideB, double sideC) : IFigure
{
    public double SideA { get; set; } = sideA;
    public double SideB { get; set; } = sideB;
    public double SideC { get; set; } = sideC;


    public double CalculateArea()
    {
        var s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public bool IsRightTriangle()
    {
        var sides = new List<double> { SideA, SideB, SideC };
        sides.Sort();
        return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 0.001;
    }
}