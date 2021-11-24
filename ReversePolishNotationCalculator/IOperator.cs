using System.Collections.Generic;

namespace ReversePolishNotationCalculator
{
    public interface IOperator
    {
        void Execute(Stack<double> computationStack);
    }
}