using System;
 

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            AppDomain currentAppDomain = AppDomain.CurrentDomain;

            currentAppDomain.UnhandledException += new UnhandledExceptionEventHandler(HandleException);

            Console.WriteLine("Enter first number");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter operation");
            string operation = Console.ReadLine().ToUpperInvariant();


            var calculator = new Calculator();

            try
            {
                int result = calculator.Calculate(number1, number2, operation);
                DisplayResult(result);

            }

            catch (CalculationException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("... finally..."); ;
            }



            Console.WriteLine("\nPress enter to exit.");
            //Console.ReadLine();
        }

        private static void HandleException(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine($"Soory, there was a problem and we need to close Details: {e.ExceptionObject}");
        }

        private static void DisplayResult(int result)
        {
            Console.WriteLine($"Result is: {result}");
        }

    }
}
