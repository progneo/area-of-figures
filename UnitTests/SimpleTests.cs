using AreaOfFigure.Models;

namespace UnitTests;

public abstract class Tests
{
    [TestFixture]
    public class FigureTests
    {
        [Test]
        public void TestCircleArea()
        {
            var circle = new Circle(5);
            Assert.That(circle.CalculateArea(), Is.EqualTo(Math.PI * 25).Within(0.001));
        }

        [Test]
        public void TestTriangleArea()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.CalculateArea(), Is.EqualTo(6).Within(0.001));
        }

        [Test]
        public void TestRightTriangleCheck()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.IsRightTriangle(), Is.True);
        }
    }
}