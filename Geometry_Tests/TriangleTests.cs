using Geometry;

namespace Geometry_Tests
{
    public class TriangleTests
    {
        [Test]
        [TestCase(1, 1, 1, 3, 0.433)]
        [TestCase(1, 2, 2, 3, 0.968)]
        [TestCase(1, 2, 2, 3, 0.968)]
        [TestCase(3.5, 2.2, 2.7, 4, 2.9698)]

        public void GetAreaPositiveTest(double a, double b, double c, int precision, double expected)
        {
            Shape triangle = Triangle.CreateTriangle(a, b, c);
            double actual = triangle.GetArea(precision);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(double.MaxValue, double.MaxValue, double.MaxValue, 3, double.PositiveInfinity)]
        public void GetAreaBigValuesTest(double a, double b, double c, int precision, double expected)
        {
            Shape triangle = Triangle.CreateTriangle(a, b, c);
            double actual = triangle.GetArea(precision);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(1, 1, 1, 3, 0.433)]
        [TestCase(1, 2, 2, 6, 0.968246)]
        [TestCase(1, 2, 2, 7, 0.9682458)]
        [TestCase(3.5, 2.2, 2.7, 9, 2.969848481)]

        public void GetAreaPrecisionTest(double a, double b, double c, int precision, double expected)
        {
            Shape triangle = Triangle.CreateTriangle(a, b, c);
            double actual = triangle.GetArea(precision);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(0, 1, 1)]
        [TestCase(1, 0, 1)]
        [TestCase(1, 1, 0)]
        [TestCase(0, 0, 0)]
        public void ConstructorZeroesTest(double a, double b, double c)
        {
            Assert.Catch(typeof(InvalidOperationException), delegate { Triangle.CreateTriangle(a, b, c); });
        }

        [Test]
        [TestCase(-1, 1, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(1, 1, -1)]
        [TestCase(4, 1, 1)]
        public void ConstructorWrongValuesTest(double a, double b, double c)
        {
            Assert.Catch(typeof(InvalidOperationException), delegate { Triangle.CreateTriangle(a, b, c); });
        }

        [Test]
        [TestCase(1, 1, 1.414)]
        [TestCase(1, 2, 2.236)]
        [TestCase(2, 3, 3.606)]
        public void IsRightTrueTest(double a, double b, double c)
        {
            Triangle triangle = Triangle.CreateTriangle(a, b, c);
            bool actual = triangle.IsRight;

            Assert.IsTrue(actual);
        }

        [Test]
        [TestCase(1, 1, 1)]
        [TestCase(1, 2, 2.5)]
        [TestCase(2, 3, 3.1)]
        public void IsRightFalseTest(double a, double b, double c)
        {
            Triangle triangle = Triangle.CreateTriangle(a, b, c);
            bool actual = triangle.IsRight;

            Assert.IsFalse(actual);
        }

        [Test]
        [TestCase(1, 1, 1, "Triangle with sides: A = 1, B = 1, C = 1")]
        [TestCase(2, 2, 2, "Triangle with sides: A = 2, B = 2, C = 2")]
        [TestCase(2, 3, 4, "Triangle with sides: A = 2, B = 3, C = 4")]
        [TestCase(2.52, 3.12, 4.478, "Triangle with sides: A = 2,52, B = 3,12, C = 4,478")]

        public void ToStringTest(double a, double b, double c, string expected)
        {
            Shape triangle = Triangle.CreateTriangle(a, b, c);
            string actual = triangle.ToString();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}