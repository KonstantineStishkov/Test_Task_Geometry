using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Triangle : Shape
    {
        public double A { get; private set; }

        public double B { get; private set; }

        public double C { get; private set; }
        public bool IsRight
        {
            get
            {
                return IsRightBySide(A, B, C)
                    || IsRightBySide(B, A, C)
                    || IsRightBySide(C, A, B);
            }
        }

        private Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public static Triangle CreateTriangle(double a, double b, double c)
        {
            if (CheckTriangleExistance(a, b, c))
            {
                return new Triangle(a, b, c);
            }

            throw new InvalidOperationException(string.Format("Triangle with sides: A = {0}, B = {1}, C = {2} could not be created", a, b, c));
        }

        public override double GetArea(int precision)
        {
            double p = GetPerimeter() / 2;
            double result = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return Math.Round(result, precision);
        }
        public double GetPerimeter()
        {
            return A + B + C;
        }

        private bool IsRightBySide(double a, double b, double c, int precision = 3)
        {
            return Math.Round(c, precision) == Math.Round(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)), precision);
        }

        private static bool CheckTriangleExistance(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0
                    && a + b > c
                    && a + c > b
                    && b + c > a;
        }

        public override string ToString()
        {
            return string.Format("Triangle with sides: A = {0}, B = {1}, C = {2}", A, B, C);
        }
    }
}
