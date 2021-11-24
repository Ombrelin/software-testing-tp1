using System;

namespace ReversePolishNotationCalculator
{
    public class UnsupportedOperatorException : Exception
    {
        public UnsupportedOperatorException(string? message) : base(message)
        {
        }
    }
}