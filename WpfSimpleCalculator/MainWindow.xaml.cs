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

        public MainWindow()
        {
            InitializeComponent();

            
        }

        #region function buttons click events
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sb.Length > 1)
            {
                sb.Remove((sb.Length - 1), 1);
            }
            else if (sb.Length == 1)
            {
                sb.Clear();
                sb.Append("0");
            }
            updateDisplay();
        }
        #endregion

        #region operations buttons click events
        private void divisionButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void multiplicationButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void subtractionButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void additionButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void equalButton_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion


        #region number buttons click events
        private void oneButton_Click(object sender, RoutedEventArgs e)
        {
            sb.Append("1");
            updateDisplay();
        }

        private void twoButton_Click(object sender, RoutedEventArgs e)
        {
            sb.Append("2");
            updateDisplay();
        }

        private void threeButton_Click(object sender, RoutedEventArgs e)
        {
            sb.Append("3");
            updateDisplay();
        }

        private void fourButton_Click(object sender, RoutedEventArgs e)
        {
            sb.Append("4");
            updateDisplay();
        }

        private void fiveButton_Click(object sender, RoutedEventArgs e)
        {
            sb.Append("5");
            updateDisplay();
        }

        private void sixButton_Click(object sender, RoutedEventArgs e)
        {
            sb.Append("6");
            updateDisplay();
        }

        private void sevenButton_Click(object sender, RoutedEventArgs e)
        {
            sb.Append("7");
            updateDisplay();
        }

        private void eightButton_Click(object sender, RoutedEventArgs e)
        {
            sb.Append("8");
            updateDisplay();
        }

        private void nineButton_Click(object sender, RoutedEventArgs e)
        {
            sb.Append("9");
            updateDisplay();
        }

        private void zeroButton_Click(object sender, RoutedEventArgs e)
        {
            sb.Append("0");
            updateDisplay();
        }

        private void decimalButton_Click(object sender, RoutedEventArgs e)
        {
            sb.Append(".");
            updateDisplay();
        }
        #endregion



        private void updateDisplay()
        {
            displayZone.Text = sb.ToString() ;
        }

        private void MainWindow_KeyUp(object sender, KeyEventArgs e)
        {
            //does not work if window not in focus
            if ((e.Key == Key.D1) || (e.Key == Key.NumPad1))
            {
                sb.Append("1");
                updateDisplay();
                return;
            }

            //TODO: create methods for all buttons
            
        }



    }
}
