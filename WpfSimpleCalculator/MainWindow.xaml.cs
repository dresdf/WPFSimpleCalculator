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

namespace WpfSimpleCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StringBuilder sb = new StringBuilder();
        decimal firstOperand;
        decimal secondOperand;
        string op;
        bool opEnd = false;

        public MainWindow()
        {
            InitializeComponent();


        }

        private void updateDisplay(string input)
        {
            if (!opEnd)
            {
                sb.Append(input);
                displayZone.Text = sb.ToString();
            }
            else
            {
                sb.Clear();
                sb.Append(input);
                displayZone.Text = sb.ToString();
                opEnd = false;

            }
        }

        private void calculate(string operation)
        {
            if (!sb.ToString().Contains("/") && !sb.ToString().Contains("*") && !sb.ToString().Contains("-") && !sb.ToString().Contains("+"))
            {
                firstOperand = decimal.Parse(sb.ToString());
                op = operation;
                updateDisplay(operation);
            }

        }


        #region function buttons click events
        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            if (sb.Length > 1)
            {
                sb.Remove((sb.Length - 1), 1);
            }
            else if (sb.Length == 1)
            {
                sb.Clear();
            }
            displayZone.Text = sb.ToString();
        }

        //clear all input
        private void clearAllButton_Click(object sender, RoutedEventArgs e)
        {
            sb.Clear();
            firstOperand = 0;
            secondOperand = 0;
            op = "";
            opEnd = false;
            displayZone.Text = sb.ToString();

        }

        //clear last operand
        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            if (sb.ToString().Contains("/") || sb.ToString().Contains("*") || sb.ToString().Contains("-") || sb.ToString().Contains("+"))
            {
                int opIndex = sb.ToString().IndexOf(op);
                string tempVal = sb.ToString().Remove(opIndex + 1);
                sb.Clear();
                sb.Append(tempVal);
                displayZone.Text = sb.ToString();
            }
            else
            {
                sb.Clear();
                firstOperand = 0;
                secondOperand = 0;
                op = "";
                displayZone.Text = sb.ToString();

            }


        }

        #endregion

        #region operations buttons click events
        private void divisionButton_Click(object sender, RoutedEventArgs e)
        {
            calculate("/");
        }

        private void multiplicationButton_Click(object sender, RoutedEventArgs e)
        {
            calculate("*");
        }

        private void subtractionButton_Click(object sender, RoutedEventArgs e)
        {
            calculate("-");
        }

        private void additionButton_Click(object sender, RoutedEventArgs e)
        {
            calculate("+");
        }

        private void equalButton_Click(object sender, RoutedEventArgs e)
        {
            //TODO: check if operation was selected before doing equal function to avoid exception
            int opIndex = sb.ToString().IndexOf(op);
            secondOperand = decimal.Parse(sb.ToString().Substring(opIndex + 1));
            decimal result;
            switch (op)
            {
                case "/":
                    result = firstOperand / secondOperand;
                    updateDisplay("=" + result.ToString("F"));
                    break;
                case "*":
                    result = firstOperand * secondOperand;
                    updateDisplay("=" + result.ToString("F"));
                    break;
                case "-":
                    result = firstOperand - secondOperand;
                    updateDisplay("=" + result.ToString());
                    break;
                case "+":
                    result = firstOperand + secondOperand;
                    updateDisplay("=" + result.ToString());
                    break;
            }
            op = "";
            opEnd = true;
        }
        #endregion


        #region number buttons click events
        private void oneButton_Click(object sender, RoutedEventArgs e)
        {
            updateDisplay("1");
        }

        private void twoButton_Click(object sender, RoutedEventArgs e)
        {
            updateDisplay("2");
        }

        private void threeButton_Click(object sender, RoutedEventArgs e)
        {
            updateDisplay("3");
        }

        private void fourButton_Click(object sender, RoutedEventArgs e)
        {
            updateDisplay("4");
        }

        private void fiveButton_Click(object sender, RoutedEventArgs e)
        {
            updateDisplay("5");
        }

        private void sixButton_Click(object sender, RoutedEventArgs e)
        {
            updateDisplay("6");
        }

        private void sevenButton_Click(object sender, RoutedEventArgs e)
        {
            updateDisplay("7");
        }

        private void eightButton_Click(object sender, RoutedEventArgs e)
        {
            updateDisplay("8");
        }

        private void nineButton_Click(object sender, RoutedEventArgs e)
        {
            updateDisplay("9");
        }

        private void zeroButton_Click(object sender, RoutedEventArgs e)
        {
            updateDisplay("0");
        }

        private void decimalButton_Click(object sender, RoutedEventArgs e)
        {
            if (!sb.ToString().Contains("."))
            {
                updateDisplay(".");
            }
        }
        #endregion




        //insert numbers with the keyboard or keypad
        //does not work if window not in focus
        //TODO: make events for all keys
        private void MainWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.Key == Key.D0) || (e.Key == Key.NumPad0))
            {
                updateDisplay("0");
                return;
            }
            else if ((e.Key == Key.D1) || (e.Key == Key.NumPad1))
            {
                updateDisplay("1");
                return;
            }
            else if ((e.Key == Key.D2) || (e.Key == Key.NumPad2))
            {
                updateDisplay("2");
                return;
            }
            else if ((e.Key == Key.D3) || (e.Key == Key.NumPad3))
            {
                updateDisplay("3");
                return;
            }
            else if ((e.Key == Key.D4) || (e.Key == Key.NumPad4))
            {
                updateDisplay("4");
                return;
            }
            else if ((e.Key == Key.D5) || (e.Key == Key.NumPad5))
            {
                updateDisplay("5");
                return;
            }
            else if ((e.Key == Key.D6) || (e.Key == Key.NumPad6))
            {
                updateDisplay("6");
                return;
            }
            else if ((e.Key == Key.D7) || (e.Key == Key.NumPad7))
            {
                updateDisplay("7");
                return;
            }
            else if ((e.Key == Key.D8) || (e.Key == Key.NumPad8))
            {
                updateDisplay("8");
                return;
            }
            else if ((e.Key == Key.D9) || (e.Key == Key.NumPad9))
            {
                updateDisplay("9");
                return;
            }
            else if ((e.Key == Key.OemPeriod))
            {
                if (!sb.ToString().Contains("."))
                {
                    updateDisplay(".");
                }

                return;
            }
            else if (e.Key == Key.Back)
            {
                if (sb.Length > 1)
                {
                    sb.Remove((sb.Length - 1), 1);
                }
                else if (sb.Length == 1)
                {
                    sb.Clear();
                }
                displayZone.Text = sb.ToString();
            }

        }





    }
}
