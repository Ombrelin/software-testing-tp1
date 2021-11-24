namespace ReversePolishNotationCalculator
{
    public class ReversePolishNotationCalculator
    {
        public double Compute(string polishNotationExpression)
        {
            string[] tokens = polishNotationExpression.Split(" ");

            double leftOperand = double.Parse(tokens[0]);
            double rightOperand = double.Parse(tokens[1]);

            string op = tokens[2];

            return op switch
            {
                "+" => leftOperand + rightOperand,
                "-" => leftOperand - rightOperand,
                "*" => leftOperand * rightOperand,
                "/" => leftOperand / rightOperand
            };
        }
    }
}

