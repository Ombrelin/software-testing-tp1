using System.Collections.Generic;

namespace ReversePolishNotationCalculator.Operators
{
    public abstract class BinaryOperator : IOperator
    {
        public abstract void Execute(Stack<double> computationStack);

        protected (double, double) GetOperands(Stack<double> computationStack)
        {
            return (computationStack.Pop(), computationStack.Pop());
        }
    }
}