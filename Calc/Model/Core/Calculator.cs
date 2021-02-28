using Calc.Model.Interface;

namespace Calc.Model.Core
{
    public class Calculator : ICalculator
    {
        private static Calculator _calculator;
        private LexicalAnalyzer _lexical_analyzer;
        private SyntaxAnalyzer _syntax_analyzer;
        private Executor _executor;

        static public Calculator Get() 
        {
            if (_calculator == null)
                _calculator = new Calculator();
            return _calculator;
        }

        private Calculator()
        {
            var table = new TransitionTable();
            _lexical_analyzer = new LexicalAnalyzer(table);
            _syntax_analyzer = new SyntaxAnalyzer();
            _executor = new Executor();
        }

        public double Do(string expression)
        {
            var list1 = _lexical_analyzer.Parse(expression);
            var list2 = _syntax_analyzer.Parse(list1);
            return _executor.Execute(list2);
        }
    }
}
