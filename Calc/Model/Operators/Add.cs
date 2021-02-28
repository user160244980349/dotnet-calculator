using Calc.Model.Type;
using System;
using System.Collections.Generic;

namespace Calc.Model.Operators
{
    public class Add : Operator
    {
        public Add() : base(OperatorType.Add, 1)
        {

        }

        override public void Do(Stack<Digit> stack)
        {
            var arg2 = stack.Pop();
            var arg1 = stack.Pop();
            stack.Push(new Digit(arg1.Value + arg2.Value));
        }
    }
}
