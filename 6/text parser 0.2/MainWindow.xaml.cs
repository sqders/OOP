using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Collections;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace text_parser_0._2
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

        private string StrRemLet(string input_text)
        {
            string[] text = input_text.Split('\n') ;
            string result = String.Empty;
            
            List<string> text_list = text.ToList();
            for(int i = 0;i<text_list.Count;i++)
            {
                if(System.Globalization.NumberFormatInfo.InvariantInfo.NumberDecimalSeparator==".")
                {
                    text_list[i] = text_list[i].Replace(",", ".");
                }
                else if(System.Globalization.NumberFormatInfo.InvariantInfo.NumberDecimalSeparator == ",")
                {
                    text_list[i] = text_list[i].Replace(".", ",");
                }
                for (int j=0; j < text_list[i].Length;j++)
                {
                    if(text_list[i][j]=='-'&& text_list[i][j+1]=='-'&&j!=text_list[i].Length)
                    {
                        text_list[i] = text_list[i].Remove(j + 1, 1);
                        j--;
                    }
                    if (System.Globalization.NumberFormatInfo.InvariantInfo.NumberDecimalSeparator == ",")
                    {
                        if (text_list[i][j] == ',' && text_list[i][j + 1] == ',' && j != text_list[i].Length)
                        {
                            text_list[i] = text_list[i].Remove(j + 1, 1);
                            j--;
                        }
                    }
                    else if (System.Globalization.NumberFormatInfo.InvariantInfo.NumberDecimalSeparator == ".")
                    {
                        if (text_list[i][j] == '.' && text_list[i][j + 1] == '.' && j != text_list[i].Length)
                        {
                            text_list[i] = text_list[i].Remove(j + 1, 1);
                            j--;
                        }
                    }
                }
                string add_str= text_list.ToArray()[i];
                for(int j=48;j<58;j++)
                {
                   add_str = add_str.Replace((char)j, ' ');
                }
                add_str = add_str.Replace(',', ' ');
                add_str = add_str.Replace('.', ' ');
                if (!String.IsNullOrWhiteSpace(add_str))
                {
                    text_list.Insert(i, add_str);
                    i++;
                }
                add_str = text_list.ToArray()[i];
                for (int j = 33; j <127; j++)
                {
                    if ((j < 48 || j > 58 )&&j!=44&&j!=46) {
                        add_str = add_str.Replace((char)j,' ') ;
                    }
                    
                }
                text_list.Insert(i, add_str);
                text_list.RemoveAt(i + 1);
            }
            foreach (var line in text_list)
            {
                result += line;
                result += '\n';
            }
            return result;
        }
        static byte[] UTF8ToWin1251(string sourceStr)
        {
            Encoding utf8 = Encoding.UTF8;
            Encoding win1251 = Encoding.GetEncoding("Windows-1251");
            byte[] utf8Bytes = utf8.GetBytes(sourceStr);
            byte[] win1251Bytes = Encoding.Convert(utf8, win1251, utf8Bytes);
            return win1251Bytes;
        }
        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {

            // Create OpenFileDialog
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();

            // Launch OpenFileDialog by calling ShowDialog method
            Nullable<bool> result = openFileDlg.ShowDialog();
            // Get the selected file name and display in a TextBox.
            // Load content of file in a TextBlock
            if (result == true)
            {
                string[] str_arr= System.IO.File.ReadLines(openFileDlg.FileName, Encoding.UTF8).ToArray();
                FileTextBox.Text = String.Empty;
                foreach(var line in str_arr)
                {
                    FileTextBox.Text += line;
                    FileTextBox.Text += '\n';
                }
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog
            Microsoft.Win32.SaveFileDialog saveFileDlg = new Microsoft.Win32.SaveFileDialog();
            saveFileDlg.DefaultExt = "txt";
            saveFileDlg.Filter =
                "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            Nullable<bool> result = saveFileDlg.ShowDialog();
            if (result == true)
            {
                string file_name = saveFileDlg.FileName;
                FileStream fileStream = new FileStream(file_name, FileMode.Create);
                byte[] text_byte = UTF8ToWin1251(FileTextBox.Text);
                fileStream.Write(text_byte, 0, text_byte.Length);
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Process.Start("wordpad.exe");
        }

        private void ParseButton_Click(object sender, RoutedEventArgs e)
        {
            string text = FileTextBox.Text;
            FileTextBox.Text= StrRemLet(text);
            text = FileTextBox.Text;

            string[] separators = { " ", "\n" } ,str_array = FileTextBox.Text.Split(separators,StringSplitOptions.RemoveEmptyEntries);
            ArrayList numbers= new ArrayList();
            foreach(var str in str_array)
            {
                int a = 0;
                if(int.TryParse(str,out a))
                {
                    numbers.Add(a);
                }
            }

        }
    }
}
