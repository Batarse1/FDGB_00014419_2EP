using System;

namespace Preparcial.Excepciones
{
    public class NonNegativeValueException : Exception
    {
        public NonNegativeValueException(string message) : base(message)
        {
        }
    }
}