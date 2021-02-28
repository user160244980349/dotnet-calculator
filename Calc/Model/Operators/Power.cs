using Calc.Model.Type;
using System;
using System.Collections.Generic;

namespace Calc.Model.Operators
{
    public class Power : Operator
    {
        public Power() : base(OperatorType.Power, 3)
        {

        }

        override public void Do(Stack<Digit> stack)
        {
            var arg2 = stack.Pop();
            var arg1 = stack.Pop();
            stack.Push(new Digit(Math.Pow(arg1.Value, arg2.Value)));
        }
    }
}
