using System;

namespace w20_Calculator_with_xUnit
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b, int noError)
        {
            if (b == 0)
            {
                Program.noError = 0;
                return 0;
            }
            return a / b;
            Program.noError = 1;
        }
    }
}
