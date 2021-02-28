using System;
using System.Collections.Generic;
using System.Text;
using Calc.Model;
using Calc.Model.Core;
using Calc.Model.Interface;
using Calc.Model.Type;

namespace LexicalAnalyzerTests
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
                "274 ** ( 53 + 10 )",
                "274**(53+10)",
                "274 ** ( ( 53 + 10 ) * 5)",
                "274**((53+10)*5)",
            };

            var expectations = new List<string>()
            {
                "[2][+][3]",
                "[2][-][3]",
                "[2][*][3]",
                "[2][/][3]",
                "[2][+][3]",
                "[2][-][3]",
                "[2][*][3]",
                "[2][/][3]",
                "[274][**][(][53][+][10][)]",
                "[274][**][(][53][+][10][)]",
                "[274][**][(][(][53][+][10][)][*][5][)]",
                "[274][**][(][(][53][+][10][)][*][5][)]",
            };

            Console.WriteLine("Starting tests...\n");
            var counter = 0;
            var passedCounter = 0;

            foreach (string test in tests)
            {
                var sb = new StringBuilder();
                var table = new TransitionTable();
                var lexical_analyzer = new LexicalAnalyzer(table);
                var tokens = lexical_analyzer.Parse(test);

                foreach (Token token in tokens)
                {
                    if (token.TokenIs == TokenType.Digit)
                        sb.Append(string.Format("[{0}]", (token as Digit).Value.ToString()));

                    if (token.TokenIs == TokenType.Operator)
                    {
                        var op = token as Operator;
                        switch (op.OperatorIs)
                        {
                            case OperatorType.Add:
                                sb.Append("[+]");
                                break;
                            case OperatorType.Subtract:
                                sb.Append("[-]");
                                break;
                            case OperatorType.Multiply:
                                sb.Append("[*]");
                                break;
                            case OperatorType.Divide:
                                sb.Append("[/]");
                                break;
                            case OperatorType.Power:
                                sb.Append("[**]");
                                break;
                            case OperatorType.OpenBracket:
                                sb.Append("[(]");
                                break;
                            case OperatorType.CloseBracket:
                                sb.Append("[)]");
                                break;
                        }
                    }
                }

                Console.WriteLine(string.Format(" >>> Test {0}", counter));
                Console.WriteLine(string.Format("case\t\t\'{0}\'", test));
                Console.WriteLine(string.Format("expectation\t{0}", expectations[counter]));
                Console.WriteLine(string.Format("result\t\t{0}", sb.ToString()));

                if (sb.ToString() == expectations[counter])
                {
                    Console.WriteLine("OK!\n");
                    passedCounter++;
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
