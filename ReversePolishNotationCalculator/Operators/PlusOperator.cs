using System.Collections.Generic;

namespace ReversePolishNotationCalculator.Operators
{
    public class PlusOperator : BinaryOperator
    {
        public override void Execute(Stack<double> computationStack)
        {
            var(op1, op2) = GetOperands(computationStack);
            computationStack.Push(op2 + op1);
        }
    }
}