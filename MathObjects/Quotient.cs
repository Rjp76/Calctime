using System;
using System.Collections.Generic;
using System.Text;

namespace MathObjects
{
   public static class DivisionTime
    {
        static public decimal Quotient(decimal numerator, decimal denominator)
        {
            decimal quo = numerator / denominator;

            return quo;
        }
        static public decimal Quotient(decimal[] doubleArray)
        {
            decimal quo = doubleArray[0];
            //figure out how to start var x at 1
            foreach (var x in doubleArray)
            {
                quo = Quotient(quo, x);
            }

            return quo;
        }
    }
}
