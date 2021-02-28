using System;
using System.Collections.Generic;

namespace Calc.Model.Core
{
    public class TransitionTable
    {
        private Dictionary< KeyValuePair<InputState, char>,
                            KeyValuePair<InputState, OutputState> > _associations;

        public TransitionTable()
        {
            _associations = new Dictionary< KeyValuePair<InputState, char>,
                                            KeyValuePair<InputState, OutputState> >();

            _associations.Add(new KeyValuePair<InputState, char>(InputState.Start, ' '), new KeyValuePair<InputState, OutputState>(InputState.Start, OutputState.Space));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Start, '$'), new KeyValuePair<InputState, OutputState>(InputState.Start, OutputState.End));

            // Чтение числа
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Start, '0'), new KeyValuePair<InputState, OutputState>(InputState.LPart, OutputState.LPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Start, '1'), new KeyValuePair<InputState, OutputState>(InputState.LPart, OutputState.LPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Start, '2'), new KeyValuePair<InputState, OutputState>(InputState.LPart, OutputState.LPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Start, '3'), new KeyValuePair<InputState, OutputState>(InputState.LPart, OutputState.LPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Start, '4'), new KeyValuePair<InputState, OutputState>(InputState.LPart, OutputState.LPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Start, '5'), new KeyValuePair<InputState, OutputState>(InputState.LPart, OutputState.LPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Start, '6'), new KeyValuePair<InputState, OutputState>(InputState.LPart, OutputState.LPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Start, '7'), new KeyValuePair<InputState, OutputState>(InputState.LPart, OutputState.LPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Start, '8'), new KeyValuePair<InputState, OutputState>(InputState.LPart, OutputState.LPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Start, '9'), new KeyValuePair<InputState, OutputState>(InputState.LPart, OutputState.LPart));

            _associations.Add(new KeyValuePair<InputState, char>(InputState.LPart, '0'), new KeyValuePair<InputState, OutputState>(InputState.LPart, OutputState.LPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.LPart, '1'), new KeyValuePair<InputState, OutputState>(InputState.LPart, OutputState.LPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.LPart, '2'), new KeyValuePair<InputState, OutputState>(InputState.LPart, OutputState.LPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.LPart, '3'), new KeyValuePair<InputState, OutputState>(InputState.LPart, OutputState.LPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.LPart, '4'), new KeyValuePair<InputState, OutputState>(InputState.LPart, OutputState.LPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.LPart, '5'), new KeyValuePair<InputState, OutputState>(InputState.LPart, OutputState.LPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.LPart, '6'), new KeyValuePair<InputState, OutputState>(InputState.LPart, OutputState.LPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.LPart, '7'), new KeyValuePair<InputState, OutputState>(InputState.LPart, OutputState.LPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.LPart, '8'), new KeyValuePair<InputState, OutputState>(InputState.LPart, OutputState.LPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.LPart, '9'), new KeyValuePair<InputState, OutputState>(InputState.LPart, OutputState.LPart));

            // Конец чтения числа
            _associations.Add(new KeyValuePair<InputState, char>(InputState.LPart, '('), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.LPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.LPart, ')'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.LPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.LPart, '+'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.LPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.LPart, '-'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.LPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.LPart, '/'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.LPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.LPart, '*'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.LPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.LPart, ' '), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.LPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.LPart, '$'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.LPart));

            // Чтение дробной части числа
            _associations.Add(new KeyValuePair<InputState, char>(InputState.LPart, ','), new KeyValuePair<InputState, OutputState>(InputState.RPart, OutputState.RPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.RPart, '0'), new KeyValuePair<InputState, OutputState>(InputState.RPart, OutputState.RPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.RPart, '1'), new KeyValuePair<InputState, OutputState>(InputState.RPart, OutputState.RPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.RPart, '2'), new KeyValuePair<InputState, OutputState>(InputState.RPart, OutputState.RPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.RPart, '3'), new KeyValuePair<InputState, OutputState>(InputState.RPart, OutputState.RPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.RPart, '4'), new KeyValuePair<InputState, OutputState>(InputState.RPart, OutputState.RPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.RPart, '5'), new KeyValuePair<InputState, OutputState>(InputState.RPart, OutputState.RPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.RPart, '6'), new KeyValuePair<InputState, OutputState>(InputState.RPart, OutputState.RPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.RPart, '7'), new KeyValuePair<InputState, OutputState>(InputState.RPart, OutputState.RPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.RPart, '8'), new KeyValuePair<InputState, OutputState>(InputState.RPart, OutputState.RPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.RPart, '9'), new KeyValuePair<InputState, OutputState>(InputState.RPart, OutputState.RPart));

            // Конец чтения дробной части числа
            _associations.Add(new KeyValuePair<InputState, char>(InputState.RPart, '('), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.RPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.RPart, ')'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.RPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.RPart, '+'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.RPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.RPart, '-'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.RPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.RPart, '/'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.RPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.RPart, '*'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.RPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.RPart, ' '), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.RPart));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.RPart, '$'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.RPart));

            // Чтение операторов
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Start, '('), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.LBr));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Start, ')'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.RBr));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Start, '+'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.Add));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Start, '-'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.Sub));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Start, '/'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.Div));

            // Чтение оператора умножения и возведения в степень
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Start, '*'), new KeyValuePair<InputState, OutputState>(InputState.Pow, OutputState.Mul));

            // Оператор умножения
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Pow, '0'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.Mul));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Pow, '1'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.Mul));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Pow, '2'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.Mul));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Pow, '3'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.Mul));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Pow, '4'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.Mul));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Pow, '5'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.Mul));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Pow, '6'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.Mul));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Pow, '7'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.Mul));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Pow, '8'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.Mul));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Pow, '9'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.Mul));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Pow, '('), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.Mul));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Pow, ')'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.Mul));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Pow, '+'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.Mul));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Pow, '-'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.Mul));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Pow, '/'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.Mul));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Pow, ' '), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.Mul));
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Pow, '$'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.Mul));

            // Оператор возведения в степень
            _associations.Add(new KeyValuePair<InputState, char>(InputState.Pow, '*'), new KeyValuePair<InputState, OutputState>(InputState.Finish, OutputState.Pow));
        }

        public KeyValuePair<InputState, OutputState> Get(KeyValuePair<InputState, char> key)
        {
            KeyValuePair<InputState, OutputState> value;
            if (_associations.TryGetValue(key, out value))
            {
                return value;
            }
            throw new Exception();
        }
    }
}
