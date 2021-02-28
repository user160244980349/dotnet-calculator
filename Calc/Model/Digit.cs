using Calc.Model.Interface;
using Calc.Model.Type;

namespace Calc.Model
{
    public class Digit : Token
    {
        public double Value { get { return _value; }  }
        private double _value;

        public Digit(int value) : base(TokenType.Digit)
        {
            _value = value;
        }

        public Digit(double value) : base(TokenType.Digit)
        {
            _value = value;
        }

        public Digit(string value) : base(TokenType.Digit)
        {
            _value = double.Parse(value);
        }
    }
}
