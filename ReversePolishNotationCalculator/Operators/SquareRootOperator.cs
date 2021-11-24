using System;
using System.Collections.Generic;

namespace ReversePolishNotationCalculator.Operators
{
    public class SquareRootOperator : UnaryOperator
    {
        public override void Execute(Stack<double> computationStack)
        {
            var operand = GetOperand(computationStack);
            computationStack.Push(Math.Sqrt(operand));
        }
    }
}