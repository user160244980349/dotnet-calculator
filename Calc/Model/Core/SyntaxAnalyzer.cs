using Calc.Model.Interface;
using Calc.Model.Operators;
using Calc.Model.Type;
using System.Collections.Generic;

namespace Calc.Model.Core
{
    public class SyntaxAnalyzer : ISyntaxAnalyzer
    {
        public List<Token> Parse(List<Token> tokens)
        {
            if (tokens[0].TokenIs == TokenType.Operator)
                if ((tokens[0] as Operator).OperatorIs == OperatorType.Subtract)
                    tokens[0] = new UnarySubstract();

            for (int i = 0; i < tokens.Count - 1; i++)
            {
                if (tokens[i].TokenIs == TokenType.Operator &&
                    tokens[i + 1].TokenIs == TokenType.Operator)
                    if ((tokens[i + 1] as Operator).OperatorIs == OperatorType.Subtract)
                        tokens[i + 1] = new UnarySubstract();
            }

            return tokens;
        }
    }
}
