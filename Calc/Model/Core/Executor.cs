using Calc.Model.Interface;
using Calc.Model.Type;
using System;
using System.Collections.Generic;

namespace Calc.Model.Core
{
    public class Executor : IExecutor
    {
        public double Execute(List<Token> tokens)
        {
            var values = new Stack<Digit>();
            var operators = new Stack<Operator>();

            foreach (Token token in tokens)
            {
                if (token.TokenIs == TokenType.Digit)
                {
                    values.Push(token as Digit);
                }

                if (token.TokenIs == TokenType.Operator)
                {
                    PushOrCalculate(operators, values, token as Operator);
                }
            }

            while (operators.Count != 0)
            {
                operators.Pop().Do(values);
            }

            return values.Pop().Value;
        }

        private void PushOrCalculate(Stack<Operator> operators, Stack<Digit> values, Operator cur_op)
        {
            if (operators.Count == 0)
            {
                operators.Push(cur_op);
                return;
            }

            var temp_op = cur_op;

            if (temp_op.OperatorIs == OperatorType.OpenBracket)
            {
                operators.Push(temp_op);
                return;
            }

            var last_op = operators.Pop();

            if (temp_op.OperatorIs == OperatorType.CloseBracket)
            {
                while (last_op.OperatorIs != OperatorType.OpenBracket)
                {
                    last_op.Do(values);
                    last_op = operators.Pop();
                }
                return;
            }

            if (last_op.OperatorPriority <= temp_op.OperatorPriority)
            {
                operators.Push(last_op);
                operators.Push(temp_op);
                return;
            }

            if (last_op.OperatorPriority > temp_op.OperatorPriority)
            {
                last_op.Do(values);
                while ( last_op.OperatorPriority > temp_op.OperatorPriority &&
                        operators.Count != 0)
                {
                    last_op = operators.Pop();
                    last_op.Do(values);
                }
                operators.Push(temp_op);
                return;
            }
        }
    }
}
