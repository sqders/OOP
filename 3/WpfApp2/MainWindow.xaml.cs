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
using System.Diagnostics;

namespace GDC
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public static int FindGCDEuclid(int a, int b,out long time )//метод Евклида
        {
            time = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            if (a == 0)
            {
                sw.Stop();
                time = sw.ElapsedTicks;
                return b;
            }
            while (b != 0)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            sw.Stop();
            time = sw.ElapsedTicks;
            return a;
        }
        static public int FindGCDStein(int u, int v, out long time)
        {
            time = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int k;
            if (u == 0 || v == 0)
                return u | v;
            for (k = 0; ((u | v) & 1) == 0; ++k)
            {
                u >>= 1;
                v >>= 1;
            }
            while ((u & 1) == 0)
                u >>= 1;
            do
            {
                while ((v & 1) == 0)
                    v >>= 1;
                if (u < v)
                {
                    v -= u;
                }
                else
                {
                    int diff = u - v;
                    u = v;
                    v = diff;
                }
                v >>= 1;
            } while (v != 0);
            u <<= k;
            sw.Stop();
            time = sw.ElapsedTicks;
            return u;
        }
            public static int FindGCDEuclid(out long time, params int[] data)//метод Евклида
        {
            time = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int NOD_result = 0;
            for(int i=0;i<data.Length;i++)
            {
                NOD_result = FindGCDEuclid(NOD_result, data[i],out time);
            }
            sw.Stop();
            time = sw.ElapsedTicks;
            return NOD_result;
        }
        public static int FindGCDStein(out long time, params int[] data)//метод Евклида
        {
            time = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int NOD_result = 0;
            for (int i = 0; i < data.Length; i++)
            {
                NOD_result = FindGCDStein(NOD_result, data[i], out time);
            }
            sw.Stop();
            time = sw.ElapsedTicks;
            return NOD_result;
        }
        public static int FindGCDEuclid(int a, int b, int c, out long time)//метод Евклида
        {
            time = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int NOD= FindGCDEuclid(FindGCDEuclid(a, b, out time), c, out time);
            sw.Stop();
            time = sw.ElapsedTicks;
            return NOD;
        }
        public static int FindGCDEuclid(int a, int b, int c, int d, out long time)//метод Евклида
        {
            time = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int NOD = FindGCDEuclid(FindGCDEuclid(FindGCDEuclid(a, b, out time), c, out time), d, out time);
            sw.Stop();
            time = sw.ElapsedTicks;
            return NOD;
        }
        public static int FindGCDEuclid(int a, int b, int c, int d, int e, out long time)//метод Евклида
        {
            time = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int NOD = FindGCDEuclid(FindGCDEuclid(FindGCDEuclid(FindGCDEuclid(a, b, out time), c, out time), d, out time),e, out time);
            sw.Stop();
            time = sw.ElapsedTicks;
            return NOD;
        }
        private void findGCD2Button_Click(object sender, RoutedEventArgs e)
        {
            int first_input, sec_input;
            if (int.TryParse(firstInteger.Text,out first_input) && int.TryParse(secondInteger.Text,out sec_input)) {
                long time;
                euclidResult.Content = "Евклид :" + FindGCDEuclid(first_input,sec_input, out time).ToString();
                euclidSpeed.Content = "Евклид :" + time.ToString();
                steinResult.Content = "Штейн :" + FindGCDStein(first_input, sec_input, out time).ToString();
                steinSpeed.Content = "Штейн :" + time.ToString();
            }
            else
            {
                steinResult.Content = "Штейн : N/A";
                euclidResult.Content = "Евклид : N/A";
                MessageBox.Show("Неверный ввод");
            }
        }

        private void findGCD3Button_Click(object sender, RoutedEventArgs e)
        {
            int first_input, sec_input, third_input;
            if (int.TryParse(firstInteger.Text, out first_input) && int.TryParse(secondInteger.Text, out sec_input)
                && int.TryParse(thirdInteger.Text, out third_input))
            {
                long time;
                euclidResult.Content = "Евклид :" + FindGCDEuclid(first_input, sec_input, third_input, out time).ToString();
                euclidSpeed.Content = "Евклид :" + time.ToString();
            }
            else
            {
                euclidResult.Content = "Евклид : N/A";
                MessageBox.Show("Неверный ввод");
            }
        }

        private void findGCD4Button_Click(object sender, RoutedEventArgs e)
        {
            int first_input, sec_input, third_input, fourth_input;
            if (int.TryParse(firstInteger.Text, out first_input) && int.TryParse(secondInteger.Text, out sec_input)
                && int.TryParse(thirdInteger.Text, out third_input) && int.TryParse(fourthInteger.Text, out fourth_input))
            {
                long time;
                euclidResult.Content = "Евклид :" + FindGCDEuclid(first_input, sec_input, third_input, fourth_input, out time).ToString();
                euclidSpeed.Content = "Евклид :" + time.ToString();
            }
            else
            {
                euclidResult.Content = "Евклид : N/A";
                MessageBox.Show("Неверный ввод");
            }
        }

        private void findGCD5Button_Click(object sender, RoutedEventArgs e)
        {
            int first_input, sec_input, third_input, fourth_input, fifth_input;
            if (int.TryParse(firstInteger.Text, out first_input) && int.TryParse(secondInteger.Text, out sec_input)
                && int.TryParse(thirdInteger.Text, out third_input) && int.TryParse(fourthInteger.Text, out fourth_input)
                && int.TryParse(fifthInteger.Text, out fifth_input))
            {
                long time;
                euclidResult.Content = "Евклид :" + FindGCDEuclid(first_input, sec_input, third_input, fourth_input,fifth_input, out time).ToString();
                euclidSpeed.Content = "Евклид :" + time.ToString();

            }
            else
            {
                euclidResult.Content = "Евклид : N/A";
                MessageBox.Show("Неверный ввод");
            }
        }

        private void findGCDParamsButton_Click(object sender, RoutedEventArgs e)
        {
            long time;
            int[] data;
            try
            { 
                data = firstInteger.Text.Split(';').
              Where(x => !string.IsNullOrWhiteSpace(x)).
              Select(x => int.Parse(x)).ToArray(); 
            }
            catch(Exception exc)
            {
                euclidResult.Content = "Евклид : N/A";
                MessageBox.Show("Ошибка ввода нескольких параметров");
                return;
            }
            euclidResult.Content = "Евклид :" + FindGCDEuclid(out time, data).ToString();
            euclidSpeed.Content = "Евклид :" + time.ToString();
            steinResult.Content = "Штейн :" + FindGCDStein(out time, data).ToString();
            steinSpeed.Content = "Штейн :" + time.ToString();
        }
    }
    
}
