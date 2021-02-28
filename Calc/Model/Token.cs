using Calc.Model.Type;

namespace Calc.Model.Interface
{
    public class Token
    {
        public TokenType TokenIs { get { return _token_type; } }
        private TokenType _token_type;

        public Token(TokenType token_type)
        {
            _token_type = token_type;
        }
    }
}
