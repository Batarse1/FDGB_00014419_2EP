//Se crea la excepción para el proceso de verificar si existe el ID
using System;

namespace Preparcial.Excepciones
{
    public class IdException : Exception
    {
        public IdException(string message) : base(message)
        {
        }
    }
}