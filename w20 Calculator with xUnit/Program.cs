using System;

namespace w20_Calculator_with_xUnit
{
    internal class Program
    {
        public static int noError = 1;
        static void Main(string[] args)
        {
            double nr1, nr2, result = default;
            char op = default;

            Console.Write("Enter the first number: ");
            nr1 = InputCheck();
            Console.Write("Enter the second number: ");
            nr2 = InputCheck();
            Console.WriteLine("   Press + for addition," +
                              "\n\t - for subtraction," +
                              "\n\t * for multiplication or" +
                              "\n\t / for division.");
            
            op = opCheck();
            Calculator calc = new Calculator();

            switch (op)
            {
                case '+':
                    result = calc.Add(nr1, nr2);
                    break;
                case '-':
                    result = calc.Subtract(nr1, nr2);
                    break;
                case '*':
                    result = calc.Multiply(nr1, nr2);
                    break;
                case '/':
                    result = calc.Divide(nr1, nr2, noError);
                    break;
            }
            if (noError == 1)
            { 
            Console.WriteLine($"The result is {result}");
            }
            else Console.WriteLine($"Division by zero is not possible.");
        }

        public static char opCheck()
        {
            char ch = default;
            do
            {
                try
                {
                    ch = Convert.ToChar(Console.ReadLine());
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("You have to choose an operator!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("You should enter only an operator. Try again!");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }

                if (ch != '+' &&
                    ch != '-' &&
                    ch != '*' &&
                    ch != '/')
                {
                    Console.WriteLine("Choose one operator from above!");
                    ch = default;
                }
            }
            while (ch == default);
            return ch;
        }

        public static double InputCheck()
        {
            double nr = default;
            bool noError = false;
            do
            {
                try
                {
                    nr = Convert.ToDouble(Console.ReadLine());
                    noError = true;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Too big number. Try again!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("You should enter only numbers. Try again!");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
            while (!noError);
            return nr;
        }
    }
}
