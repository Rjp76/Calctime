using System;
using MathObjects;
using Microsoft.Cci.MutableCodeModel;

namespace Calculator
{
    class basicCalculator
    {

        static public int Add(int a, int b)
        {
            var c = AdditionTime.Sum(a, b);

            return c;
        }
        static public int Sub(int a, int b)
        {
            return SubtractionTime.Difference(a, b);

            
        }
        static public int Mult(int a, int b)
        {
            var c = MultiplicationTime.Product(a, b);

            return c;
        }
        static public decimal Divi(decimal a, decimal b)
        {
            decimal c = DivisionTime.Quotient(a, b);

            return c;
        }
        static public int Sq(int a)
        {
            int c = SquareTime.Square(a);
            return c;

        }
        static public double SquareRoot(int a)
        {
            double c = SquaredRootTime.SquareRt(a);
            return c;
        }



    }
}
