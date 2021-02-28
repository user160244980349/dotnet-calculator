using Calc.Model.Interface;
using Calc.Model.Operators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calc.Model.Core
{
    public class LexicalAnalyzer : ILexicalAnalyzer
    {
        private TransitionTable _table;
        private int _pos;
        private string _expression;

        public LexicalAnalyzer(TransitionTable table)
        {
            _table = table;
        }

        public List<Token> Parse(string expression)
        {
            var tokens = new List<Token>();

            _pos = 0;
            _expression = string.Format("{0}$", expression);

            Token token;
            while (ReadToken(out token))
            {
                tokens.Add(token);
            }

            return tokens;
        }

        private void Step()
        {
            _pos++;
        }

        private bool ReadToken(out Token token)
        {
            var currentState = InputState.Start;
            var tokenStr = new StringBuilder();

            for (; _pos < _expression.Length; _pos++)
            {
                var symbol = _expression[_pos];
                var pair = _table.Get(new KeyValuePair<InputState, char>(currentState, symbol));

                if (pair.Key == InputState.Start) 
                    continue;

                if (pair.Key == InputState.Finish)
                {
                    switch (pair.Value)
                    {
                        case OutputState.Add:
                            token = new Add();
                            Step();
                            return true;

                        case OutputState.Sub:
                            token = new Substract();
                            Step();
                            return true;

                        case OutputState.Mul:
                            token = new Multiply();
                            return true;

                        case OutputState.Div:
                            token = new Divide();
                            Step();
                            return true;

                        case OutputState.Pow:
                            token = new Power();
                            Step();
                            return true;

                        case OutputState.LBr:
                            token = new OpenBracket();
                            Step();
                            return true;

                        case OutputState.RBr:
                            token = new CloseBracket();
                            Step();
                            return true;

                        case OutputState.LPart:
                            token = new Digit(tokenStr.ToString());
                            return true;

                        case OutputState.RPart:
                            token = new Digit(tokenStr.ToString());
                            return true;
                    }
                }
                currentState = pair.Key;
                tokenStr.Append(symbol);
            }
            token = null;
            return false;
        }
    }
}
