using System.Collections.Generic;

namespace ReversePolishNotationCalculator.Operators
{
    public abstract class UnaryOperator : IOperator
    {
        public abstract void Execute(Stack<double> computationStack);

        protected double GetOperand(Stack<double> computationStack)
        {
            return computationStack.Pop();
        }
        
    }
}