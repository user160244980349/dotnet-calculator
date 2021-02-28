using Calc.Model.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExecutorTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var tests = new List<string>()
            {
                "2 + 3",
                "2 - 3",
                "2 * 3",
                "2 / 3",
                "2+3",
                "2-3",
                "2*3",
                "2/3",
                "2*3+1--6",
                "5 ** ( 6 + 10 )",
                "5**(6+10)",
                "5 ** ( ( 6 + 10 ) * 5 )",
                "5**((6+10)*5)",
            };

            var expectations = new List<double>()
            {
                5,
                -1,
                6,
                0.6666666666666666,
                5,
                -1,
                6,
                0.6666666666666666,
                13,
                152587890625,
                152587890625,
                8.271806125530277E+55,
                8.271806125530277E+55,
            };

            Console.WriteLine("Starting tests...\n");
            var counter = 0;
            var passedCounter = 0;

            foreach (string test in tests)
            {
                var sb = new StringBuilder();
                var table = new TransitionTable();
                var lexical_analyzer = new LexicalAnalyzer(table);
                var syntax_analyzer = new SyntaxAnalyzer();
                var executor = new Executor();
                var tokens1 = lexical_analyzer.Parse(test);
                var tokens2 = syntax_analyzer.Parse(tokens1);
                var result = executor.Execute(tokens2);

                Console.WriteLine(string.Format(" >>> Test {0}", counter));
                Console.WriteLine(string.Format("case\t\t\'{0}\'", test));
                Console.WriteLine(string.Format("expectation\t{0}", expectations[counter]));
                Console.WriteLine(string.Format("result\t\t{0}", result));

                if (result == expectations[counter])
                {
                    passedCounter++;
                    Console.WriteLine("OK!\n");
                }
                else
                    Console.WriteLine("FAILURE!\n");

                counter++;
            }

            Console.WriteLine("RESULT: {0}/{1}!\n", passedCounter, counter);
            Console.ReadKey();
        }
    }
}
