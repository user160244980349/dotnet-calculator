using Calc.Model.Core;
using System.Windows;

namespace Calc.Model
{
    public class MainWindowModel : DependencyObject
    {
        public string Expression
        {
            get { return (string)GetValue(ExpressionProperty); }
            set { SetValue(ExpressionProperty, value); }
        }

        public static readonly DependencyProperty ExpressionProperty =
            DependencyProperty.Register("Expression", typeof(string), typeof(MainWindowModel), new PropertyMetadata(""));

        public void Calculate()
        {
            Expression = Calculator.Get().Do(Expression).ToString();
        }
    }
}
