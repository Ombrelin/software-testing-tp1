using System.Collections.Generic;
using System.Linq;

namespace ReversePolishNotationCalculator.Operators
{
    public class MaxOperator : NAryOperator
    {
        public override void Execute(Stack<double> computationStack)
        {
            var result = GetOperands(computationStack).Max();
            computationStack.Push(result);
        }
    }
}