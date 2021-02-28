using Calc.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindowModel WindowModel { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            WindowModel = new MainWindowModel();
            DataContext = WindowModel;
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            WindowModel.Expression += '1';
        }
        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            WindowModel.Expression += '2';
        }
        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            WindowModel.Expression += '3';
        }
        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            WindowModel.Expression += '4';
        }
        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            WindowModel.Expression += '5';
        }
        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            WindowModel.Expression += '6';
        }
        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            WindowModel.Expression += '7';
        }
        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            WindowModel.Expression += '8';
        }
        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            WindowModel.Expression += '9';
        }
        private void Button_0_Click(object sender, RoutedEventArgs e)
        {
            WindowModel.Expression += '0';
        }
        private void Button_dot_Click(object sender, RoutedEventArgs e)
        {
            WindowModel.Expression += ',';
        }
        private void Button_add_Click(object sender, RoutedEventArgs e)
        {
            WindowModel.Expression += '+';
        }
        private void Button_sub_Click(object sender, RoutedEventArgs e)
        {
            WindowModel.Expression += '-';
        }
        private void Button_mul_Click(object sender, RoutedEventArgs e)
        {
            WindowModel.Expression += '*';
        }
        private void Button_div_Click(object sender, RoutedEventArgs e)
        {
            WindowModel.Expression += '/';
        }
        private void Button_ob_Click(object sender, RoutedEventArgs e)
        {
            WindowModel.Expression += '(';
        }
        private void Button_cb_Click(object sender, RoutedEventArgs e)
        {
            WindowModel.Expression += ')';
        }
        private void Button_eq_Click(object sender, RoutedEventArgs e)
        {
            WindowModel.Calculate();
        }
    }
}
