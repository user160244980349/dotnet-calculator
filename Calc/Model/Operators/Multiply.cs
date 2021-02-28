using Calc.Model.Type;
using System.Collections.Generic;

namespace Calc.Model.Operators
{
    public class Multiply : Operator
    {
        public Multiply() : base(OperatorType.Multiply, 2)
        {

        }

        override public void Do(Stack<Digit> stack)
        {
            var arg2 = stack.Pop();
            var arg1 = stack.Pop();
            stack.Push(new Digit(arg1.Value * arg2.Value));
        }
    }
}
