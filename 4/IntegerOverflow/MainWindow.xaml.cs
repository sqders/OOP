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

namespace IntegerOverflow
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

        private void DoMultiply_Click(object sender, RoutedEventArgs e)
        {
            int a, b, c;
            if (int.TryParse(FirstIntTextBox.Text, out a) && int.TryParse(SecondIntTextBox.Text, out b))
            {
                c = 0;
                int i = Int32.MaxValue;
                try
                {
                 c = checked(a * b);
                }
                catch (OverflowException exc)
                {
                    MessageBox.Show(exc.ToString());
                }
                ResultLabel.Content ="Результат :" + c.ToString();
            }
        }
    }
}
