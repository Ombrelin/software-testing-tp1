using System.Collections.Generic;
using System.Linq;

namespace ReversePolishNotationCalculator.Operators
{
    public class MinOperator : NAryOperator
    {
        public override void Execute(Stack<double> computationStack)
        {
            var result = GetOperands(computationStack).Min();
            computationStack.Push(result);
        }
    }
}