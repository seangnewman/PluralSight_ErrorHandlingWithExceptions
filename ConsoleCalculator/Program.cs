using System;
 

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
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
            catch (Exception ex)
            {
                Console.WriteLine($"Sorry, something went wrong.  {ex}");
            }
          



            Console.WriteLine("\nPress enter to exit.");
            //Console.ReadLine();
        }

        private static void DisplayResult(int result)
        {
            Console.WriteLine($"Result is: {result}");
        }
    }
}
