using System;
using System.Collections.Generic;
using ReversePolishNotationCalculator.Operators;

namespace ReversePolishNotationCalculator
{
    
    public class ReversePolishNotationCalculator
    {
        private static readonly Dictionary<string,IOperator> OPERATORS = new ()
        {
            ["*"] = new MultiplyOperator(),
            ["/"] = new DivideOperator(),
            ["+"] = new PlusOperator(),
            ["-"] = new MinusOperator(),
            ["sqrt"] = new SquareRootOperator(),
            ["min"] = new MinOperator(),
            ["max"] = new MaxOperator(),
        };
        
        public double Compute(string polishNotationExpression)
        {
            var computeStack = new Stack<double>();

            string[] tokens = polishNotationExpression.Split(" ");

            foreach (var token in tokens)
            {
                if (!IsOperator(token))
                {
                    AddOperandOnStack(computeStack, token);
                }
                else
                {
                    ExecuteComputation(computeStack, token);
                }
            }

            if (computeStack.Count > 1)
            {
                throw new MalformedExpressionException();
            }

            return computeStack.Pop();
        }

        private static void AddOperandOnStack(Stack<double> computeStack, string token)
        {
            try
            {
                computeStack.Push(double.Parse(token));
            }
            catch (FormatException)
            {
                throw new MalformedExpressionException();
            }
        }

        private static void ExecuteComputation(Stack<double> computationStack, string token)
        {
            if (!OPERATORS.ContainsKey(token))
            {
                throw new MalformedExpressionException();
            }
            
            var operation = OPERATORS[token];
            operation.Execute(computationStack);
        }

        private static bool IsOperator(string token)
        {
            return OPERATORS.ContainsKey(token);
        }
    }
}