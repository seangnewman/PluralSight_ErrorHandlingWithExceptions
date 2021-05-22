using System;

namespace ConsoleCalculator
{
    class CalculationException : Exception
    {
        private static readonly string DefaultMessage = "An error occurred during calculation. Ensure that the operator is supported and that the values are within the valid ranges";


        //  <summary>
        // Creates a new <see cref="CalculationException"/> with a predefined message
        // <summary>
        public CalculationException(): base(DefaultMessage)
        {

        }

        //  <summary>
        // Creates a new <see cref="CalculationException"/> with a user-supplied  message
        // <summary>
        public CalculationException(string message): base(message)
        {

        }

        //  <summary>
        // Creates a new <see cref="CalculationException"/> with a predefined message and wrapped InnerException
        // <summary>
        public CalculationException(Exception innerException): base(DefaultMessage, innerException)
        {

        }


        //  <summary>
        // Creates a new <see cref="CalculationException"/> with a user defined message and wrapped InnerException
        // <summary>
        public CalculationException(string message, Exception innerException) : base(message, innerException)
        {

        }

    }
}
