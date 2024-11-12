using System;
using System.Text;
using System.Collections.Generic;

namespace C_sharp
{
    public class DecimalHandler
    {
        public string CheckDecimal(double x, double y, int z)
        {
            if (y == 0)
            {
                var message = Notify.DivideByZero;
                return message;
            }
            double result = x / y;
            double decimalPart = result - Math.Floor(result);
            double shifted = decimalPart * Math.Pow(10, z);
            int zthDigit = (int)Math.Floor(shifted) % 10;
            return zthDigit.ToString();
        }

    }
}