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

namespace lab2app
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            double numberDouble ;
            if (double.TryParse(inputTextBox.Text, out numberDouble ))
            {
                if(numberDouble >=0)
                {
                    double squareRoot=Math.Sqrt(numberDouble );
                    frameworkLabel.Content = String.Format("{0} (Using.NET Framework)", squareRoot);
                    decimal numberDecimal;
                    if(decimal.TryParse(inputTextBox.Text, out numberDecimal))
                    {
                        decimal delta = Convert.ToDecimal(Math.Pow(10, -28)),
                                guess = numberDecimal / 2 ,
                                result = ((numberDecimal / guess) + guess) / 2;
                        while(Math.Abs(guess-result)>delta)
                        {
                            guess = result;
                            result = ((numberDecimal / guess) + guess) / 2;
                        }
                        newtonLabel.Content= String.Format("{0} (Using Newton)", result);
                    }
                    else
                    {
                        MessageBox.Show("Пожалуйста введите decimal");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a positive number,");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter a double,");
                return;
            }
        }
        decimal currentNumber=-1;
        private void iterationButton_Click(object sender, RoutedEventArgs e)
        {
            decimal numberDecimal;
            if (decimal.TryParse(inputTextBox.Text, out numberDecimal))
            {
                if (currentNumber != numberDecimal)
                {
                    decimal delta = Convert.ToDecimal(Math.Pow(10, -28)),
                            guess = numberDecimal / 2,
                            result = ((numberDecimal / guess) + guess) / 2;
                    iterationLable.Content = String.Format("Newton method:\nIteration {0}\nChange {1}\nDelta {2}", 1, Math.Abs(guess - result), delta);
                    currentNumber = numberDecimal;
                }
                else
                {
                    int iterationNumber;
                    char[] separators = new char[] { '\n', '\r' };
                    string s = iterationLable.Content.ToString().Split(separators, StringSplitOptions.RemoveEmptyEntries)[1].Split(' ')[1];
                    if(int.TryParse(s,out iterationNumber))
                    {
                        iterationNumber += 1;
                        decimal delta = Convert.ToDecimal(Math.Pow(10, -28)),
                                guess = numberDecimal / 2,
                                result = ((numberDecimal / guess) + guess) / 2;
                        for (int i=1; i<iterationNumber; i++)
                        {
                            guess = result;
                            result = ((numberDecimal / guess) + guess) / 2;
                        }
                        iterationLable.Content = String.Format("Newton method:\nIteration {0}\nChange {1}\nDelta {2}", iterationNumber, Math.Abs(guess - result), delta);
                        newtonLabel.Content = result.ToString() + "(Using Newton)";
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста введите decimal");
                return;
            }
        }
    }
}
