using System;

namespace ConsoleCalculator
{
    class CalculationOperationNotSupportedException : CalculationException
    {
        public string Operation { get; set; }

        //  <summary>
        // Creates a new <see cref="CalculationOperationNotSupported"/> with a default message  
        // <summary>
        public CalculationOperationNotSupportedException():base("Specified operation was out of the range of valid values")
        {

        }

        //  <summary>
        // Creates a new <see cref="CalculationOperationNotSupported"/> with operation that is not supported  
        // <summary>
        public CalculationOperationNotSupportedException(string operation) : this()
        {
            Operation = operation;
        }

        //  <summary>
        // Creates a new <see cref="CalculationOperationNotSupported"/> with user supplied message and InnerException
        // <summary>
        public CalculationOperationNotSupportedException(string message, Exception innerException) : base(message, innerException)
        {
             
        }

        //  <summary>
        // Creates a new <see cref="CalculationOperationNotSupported"/> with user supplied message and the operation
        // <summary>
        public CalculationOperationNotSupportedException(string operation, string message) : base(message)
        {
            Operation = operation;
        }

        public override string Message {
            get {
                string message = base.Message;
                if (Operation != null)
                {
                    return message + Environment.NewLine + $"Unsupported operation: {Operation}";
                }
                return message;
            }
        }
        
    }
}
