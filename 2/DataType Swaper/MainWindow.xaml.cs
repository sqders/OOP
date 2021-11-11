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

namespace DataType_Swaper
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBlock1.Text = "";
            dynamic input=null;
            bool InputIsCorrect = false;
            switch(ComboBoxInput.SelectedIndex)
            {
                case 0:
                    try
                    {
                        input = char.Parse(TextBox1.Text);
                    }
                    catch (Exception exc)
                    {
                        TextBlock1.Text = "Некорректный ввод\nОшибка:" + exc.ToString();
                        break;
                    }
                    InputIsCorrect = true;
                    break;

                case 1:
                    try
                    {
                        input = TextBox1.Text;
                    }
                    catch (Exception exc)
                    {
                        TextBlock1.Text = "Некорректный ввод\nОшибка:" + exc.ToString();
                        break;
                    }
                    InputIsCorrect = true;
                    break;

                case 2:
                    try
                    {
                        input = byte.Parse(TextBox1.Text);
                    }
                    catch (Exception exc)
                    {
                        TextBlock1.Text = "Некорректный ввод\nОшибка:" + exc.ToString();
                        break;
                    }
                    InputIsCorrect = true;
                    break;

                case 3:
                    try
                    {
                        input = int.Parse(TextBox1.Text);
                    }
                    catch (Exception exc)
                    {
                        TextBlock1.Text = "Некорректный ввод\nОшибка:" + exc.ToString();
                        break;
                    }
                    InputIsCorrect = true;
                    break;

                case 4:
                    try
                    {
                        input = float.Parse(TextBox1.Text);
                    }
                    catch (Exception exc)
                    {
                        TextBlock1.Text = "Некорректный ввод\nОшибка:" + exc.ToString();
                        break;
                    }
                    InputIsCorrect = true;
                    break;

                case 5:
                    try
                    {
                        input = double.Parse(TextBox1.Text);
                    }
                    catch (Exception exc)
                    {
                        TextBlock1.Text = "Некорректный ввод\nОшибка:" + exc.ToString();
                        break;
                    }
                    InputIsCorrect = true;
                    break;

                case 6:
                    try
                    {
                        input = decimal.Parse(TextBox1.Text);
                    }
                    catch (Exception exc)
                    {
                        TextBlock1.Text = "Некорректный ввод\nОшибка:" + exc.ToString();
                        break;
                    }
                    InputIsCorrect = true;
                    break;

                case 7:
                    try
                    {
                        input = bool.Parse(TextBox1.Text);
                    }
                    catch (Exception exc)
                    {
                        TextBlock1.Text = "Некорректный ввод\nОшибка:" + exc.ToString();
                        break;
                    }
                    InputIsCorrect = true;
                    break;

                case 8:
                    try
                    {
                        input = (object)TextBox1.Text;
                    }
                    catch (Exception exc)
                    {
                        TextBlock1.Text = "Некорректный ввод\nОшибка:" + exc.ToString();
                        break;
                    }
                    InputIsCorrect = true;
                    break;
                default:
                    break;

            }
            if (InputIsCorrect)
            {
                switch (ComboBoxOutput.SelectedIndex)
                {
                    case 0:
                        {
                            bool ImplicitPassed = true;
                            char output;
                            try
                            {
                                output = input;
                            }
                            catch (Exception exc)
                            {
                                TextBlock1.Text = "Неявное преобразование:False\n";
                                ImplicitPassed = false;
                            }
                            if (ImplicitPassed)
                                TextBlock1.Text = "Неявное преобразование:True\n";
                            try
                            {
                                output = (char)input;
                            }
                            catch (Exception exc)
                            {
                                TextBlock1.Text += "Явное преобразование:False\n";
                                break;
                            }
                            TextBlock1.Text += "Явное преобразование:True\n";
                            break;
                        }
                    case 1:
                        {
                            bool ImplicitPassed = true;
                            string output;
                            try
                            {
                                output = input;
                            }
                            catch (Exception exc)
                            {
                                TextBlock1.Text = "Неявное преобразование:False\n";
                                ImplicitPassed = false;
                            }
                            if (ImplicitPassed)
                                TextBlock1.Text = "Неявное преобразование:True\n";
                            try
                            {
                                output = (string)input;
                            }
                            catch (Exception exc)
                            {
                                TextBlock1.Text += "Явное преобразование:False\n";
                                break;
                            }
                            TextBlock1.Text += "Явное преобразование:True\n";
                            break;
                        }
                    case 2:
                        {
                            bool ImplicitPassed = true;
                            byte output;
                            try
                            {
                                output = input;
                            }
                            catch (Exception exc)
                            {
                                TextBlock1.Text = "Неявное преобразование:False\n";
                                ImplicitPassed = false;
                            }
                            if (ImplicitPassed)
                                TextBlock1.Text = "Неявное преобразование:True\n";
                            try
                            {
                                output = (byte)input;
                            }
                            catch (Exception exc)
                            {
                                TextBlock1.Text += "Явное преобразование:False\n";
                                break;
                            }
                            TextBlock1.Text += "Явное преобразование:True\n";
                            break;
                        }
                    case 3:
                        {
                            bool ImplicitPassed = true;
                            int output;
                            try
                            {
                                output = input;
                            }
                            catch (Exception exc)
                            {
                                TextBlock1.Text = "Неявное преобразование:False\n";
                                ImplicitPassed = false;
                            }
                            if (ImplicitPassed)
                                TextBlock1.Text = "Неявное преобразование:True\n";
                            try
                            {
                                output = (int)input;
                            }
                            catch (Exception exc)
                            {
                                TextBlock1.Text += "Явное преобразование:False\n";
                                break;
                            }
                            TextBlock1.Text += "Явное преобразование:True\n";
                            break;
                        }
                    case 4:
                        {
                            bool ImplicitPassed = true;
                            float output;
                            try
                            {
                                output = input;
                            }
                            catch (Exception exc)
                            {
                                TextBlock1.Text = "Неявное преобразование:False\n";
                                ImplicitPassed = false;
                            }
                            if (ImplicitPassed)
                                TextBlock1.Text = "Неявное преобразование:True\n";
                            try
                            {
                                output = (float)input;
                            }
                            catch (Exception exc)
                            {
                                TextBlock1.Text += "Явное преобразование:False\n";
                                break;
                            }
                            TextBlock1.Text += "Явное преобразование:True\n";
                            break;
                        }
                    case 5:
                        {
                            bool ImplicitPassed = true;
                            double output;
                            try
                            {
                                output = input;
                            }
                            catch (Exception exc)
                            {
                                TextBlock1.Text = "Неявное преобразование:False\n";
                                ImplicitPassed = false;
                            }
                            if(ImplicitPassed)
                                TextBlock1.Text = "Неявное преобразование:True\n";
                            try
                            {
                                output = (double)input;
                            }
                            catch (Exception exc)
                            {
                                TextBlock1.Text += "Явное преобразование:False\n";
                                break;
                            }
                            TextBlock1.Text += "Явное преобразование:True\n";
                            break;
                        }
                    case 6:
                        {
                            bool ImplicitPassed = true;
                            decimal output;
                            try
                            {
                                output = input;
                            }
                            catch (Exception exc)
                            {
                                TextBlock1.Text = "Неявное преобразование:False\n";
                                ImplicitPassed = false;
                            }
                            if (ImplicitPassed)
                                TextBlock1.Text = "Неявное преобразование:True\n";
                            try
                            {
                                output = (decimal)input;
                            }
                            catch (Exception exc)
                            {
                                TextBlock1.Text += "Явное преобразование:False\n";
                                break;
                            }
                            TextBlock1.Text += "Явное преобразование:True\n";
                            break;
                        }
                    case 7:
                        {
                            bool ImplicitPassed = true;
                            bool output;
                            try
                            {
                                output = input;
                            }
                            catch (Exception exc)
                            {
                                TextBlock1.Text = "Неявное преобразование:False\n";
                                ImplicitPassed = false;
                            }
                            if (ImplicitPassed)
                                TextBlock1.Text = "Неявное преобразование:True\n";
                            try
                            {
                                output = (bool)input;
                            }
                            catch (Exception exc)
                            {
                                TextBlock1.Text += "Явное преобразование:False\n";
                                break;
                            }
                            TextBlock1.Text += "Явное преобразование:True\n";
                            break;
                        }
                    case 8:
                        {
                            bool ImplicitPassed = true;
                            object output;
                            try
                            {
                                output = input;
                            }
                            catch (Exception exc)
                            {
                                TextBlock1.Text = "Неявное преобразование:False\n";
                                ImplicitPassed = false;
                            }
                            if (ImplicitPassed)
                                TextBlock1.Text = "Неявное преобразование:True\n";
                            try
                            {
                                output = (object)input;
                            }
                            catch (Exception exc)
                            {
                                TextBlock1.Text += "Явное преобразование:False\n";
                                break;
                            }
                            TextBlock1.Text += "Явное преобразование:True\n";
                            break;
                        }

                    default:
                        break;
                }
            }
        }

    }
}
