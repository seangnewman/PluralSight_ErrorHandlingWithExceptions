using System;

namespace ConsoleCalculator
{
    public class Calculator
    {
        public int Calculate(int number1, int number2, string operation)
        {
            //if (operation is null)
            //{
            //    throw new ArgumentNullException(nameof(operation));
            //}

           // throw new ArgumentNullException(nameof(number1));

            string nonNullOperation = operation ?? throw new ArgumentNullException(nameof(operation));

            if (nonNullOperation == "/")
            {
                try
                {
                    return Divide(number1, number2);

                }
                catch (DivideByZeroException ex)
                {
                    // By using throw (rather than throw ex) we save valuable information on the call stack
                    //throw;

                    throw new ArithmeticException("An error occurred during calculation", ex);
                }
            }
            else
            {
                //Console.WriteLine("Unknown operation.");
                //return 0;
                throw new ArgumentOutOfRangeException(nameof(operation), "The mathematical operations is not supported. ");
            }
        }
        
        private int Divide(int number, int divisor)
        {
            return number / divisor;
        }
    }
}

