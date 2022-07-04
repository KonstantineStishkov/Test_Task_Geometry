using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Circle : Shape
    {
        const int minValue = 0;
        const int precisionMaxValue = 15;

        private double _radius;

        //Здесь вместо исключений сделал запись "безопасных" значений в случае неверных значений
        public double Radius
        {
            get
            {
                return _radius;
            }
            private set
            {
                if (value >= minValue)
                    _radius = value;
                else
                    _radius = minValue;
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        /* В задании не было указана точность, с которой производить вычисления,
        * поэтому я сделал переменную величину */
        public override double GetArea(int precision)
        {
            precision = CheckPrecision(precision);

            double result = Math.PI * Math.Pow(Radius, 2);
            return Math.Round(result, precision);
        }

        private static int CheckPrecision(int precision)
        {
            int result;
            if (precision < minValue)
                result = minValue;
            else if (precision > precisionMaxValue)
                result = precisionMaxValue;
            else
                result = precision;
            return result;
        }

        public override string ToString()
        {
            return string.Format("Circle with Radius = {0}", Radius);
        }
    }
}
