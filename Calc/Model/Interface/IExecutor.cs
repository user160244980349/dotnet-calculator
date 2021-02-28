using System.Collections.Generic;

namespace Calc.Model.Interface
{
    public interface IExecutor
    {
        double Execute(List<Token> tokens);
    }
}
