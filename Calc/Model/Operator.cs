using Calc.Model.Interface;
using Calc.Model.Type;
using System;
using System.Collections.Generic;

namespace Calc.Model
{
    public class Operator : Token
    {
        public OperatorType OperatorIs { get { return _operator_type; } }
        public int OperatorPriority { get { return _operator_priority; } }

        private OperatorType _operator_type;
        private int _operator_priority;

        public Operator(OperatorType operator_type, int priority) : base(TokenType.Operator)
        {
            _operator_type = operator_type;
            _operator_priority = priority;
        }

        public virtual void Do(Stack<Digit> stack)
        {
            throw new NotImplementedException();
        }
    }
}
