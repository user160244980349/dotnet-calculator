using System.Collections.Generic;

namespace Calc.Model.Interface
{
    public interface ILexicalAnalyzer
    {
        List<Token> Parse(string expression);
    }
}
