using Geometry;

namespace Geometry_Tests
{
    public class CircleTests
    {
        [Test]
        [TestCase(1, 4, 3.1416)]
        [TestCase(2, 4, 12.5664)]
        [TestCase(3, 4, 28.2743)]
        [TestCase(1.5, 4, 7.0686)]
        public void GetAreaPositiveTest(double radius, int precision, double expected)
        {
            Shape circle = new Circle(radius);
            double actual = circle.GetArea(precision);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(0, 4, 0)]
        [TestCase(1, 0, 3)]
        public void GetAreaZeroesTest(double radius, int precision, double expected)
        {
            Shape circle = new Circle(radius);
            double actual = circle.GetArea(precision);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(-1, 4, 0)]
        [TestCase(1, -1, 3)]
        public void GetAreaNegativeTest(double radius, int precision, double expected)
        {
            Shape circle = new Circle(radius);
            double actual = circle.GetArea(precision);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(double.MaxValue, 4, double.PositiveInfinity)]
        [TestCase(1, int.MaxValue, 3.1415926535897931)]
        public void GetAreaBigValuesTest(double radius, int precision, double expected)
        {
            Shape circle = new Circle(radius);
            double actual = circle.GetArea(precision);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(1, 0, 3)]
        [TestCase(1, 1, 3.1)]
        [TestCase(1, 2, 3.14)]
        [TestCase(1, 3, 3.142)]
        [TestCase(1, 4, 3.1416)]
        [TestCase(1, 5, 3.14159)]
        [TestCase(1, 6, 3.141593)]
        [TestCase(1, 7, 3.1415927)]
        public void GetAreaPrecisionSuccessTest(double radius, int precision, double expected)
        {
            Shape circle = new Circle(radius);
            double actual = circle.GetArea(precision);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(1, -1, 3)]
        [TestCase(1, 18, 3.1415926535897931)]
        public void GetPrecisionWrongValuesTest(double radius, int precision, double expected)
        {
            Shape circle = new Circle(radius);
            double actual = circle.GetArea(precision);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(1, "Circle with Radius = 1")]
        [TestCase(2, "Circle with Radius = 2")]
        public void ToStringTest(double radius, string expected)
        {
            Shape circle = new Circle(radius);
            string actual = circle.ToString();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}