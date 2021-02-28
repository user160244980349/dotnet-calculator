using Calc.Model.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calc.Model.Operators
{
    public class UnarySubstract : Operator
    {
        public UnarySubstract() : base(OperatorType.UnarySubstract, 5)
        {

        }

        override public void Do(Stack<Digit> stack)
        {
            var arg1 = stack.Pop();
            stack.Push(new Digit(-arg1.Value));
        }
    }
}
