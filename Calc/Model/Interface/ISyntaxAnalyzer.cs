using System.Collections.Generic;

namespace Calc.Model.Interface
{
    public interface ISyntaxAnalyzer
    {
        List<Token> Parse(List<Token> tokens);
    }
}
