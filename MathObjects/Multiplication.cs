using System;
using System.Collections.Generic;
using System.Text;

namespace MathObjects
{
    public static class MultiplicationTime
    {
        static public int Product(int factorA, int factorB)
        {
            var product = factorA * factorB;

            return product;
        }

        static public decimal Product(decimal factorA, decimal factorB)
        {
            var product = factorA * factorB;

            return product;
        }

        static public decimal Product(decimal[] doubleArray)
        {
            decimal product = 1;

            foreach (var x in doubleArray)
            {
                product = Product(product, x);
            }

            return product;
        }
        static public int Product(int[] doubleArray)
        {
            int result = 1;

            foreach (var x in doubleArray)
            {
                result = Product(result, x);
            }

            return result;
        }
    }
}
