using System.Collections.Generic;
using System.Linq;

namespace ReversePolishNotationCalculator.Operators
{
    public abstract class NAryOperator : IOperator
    {
        public abstract void Execute(Stack<double> computationStack);

        protected List<double> GetOperands(Stack<double> computationStack)
        {
            var operands = new List<double>();
            while (computationStack.Count > 0)
            {
                operands.Add(computationStack.Pop());
            }

            return operands;
        }
        
    }
}