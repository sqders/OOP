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

namespace MatrixMultiplication
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double[,] matrix1 = new double[0,0],
            matrix2 = new double[0, 0],
            result = new double[0, 0];
        private void getValuesFromGrid(Grid grid, double[,] matrix)
        {
            int columns = grid.ColumnDefinitions.Count;
            int rows = grid.RowDefinitions.Count;
            // Iterate over cells in Grid, copying to matrix array
            for (int c = 0; c < grid.Children.Count; c++)
            {
                TextBox t = (TextBox)grid.Children[c];
                int row = Grid.GetRow(t);
                int column = Grid.GetColumn(t);
                matrix[column, row] = double.Parse(t.Text);
            }
        }
        private void initializeGrid(Grid grid, double[,] matrix)
        {
            if (grid != null)
            {
                // Reset the grid before doing anything
                grid.Children.Clear();
                grid.ColumnDefinitions.Clear();
                grid.RowDefinitions.Clear();
                // Get the dimensions
                int columns = matrix.GetLength(0);
                int rows = matrix.GetLength(1);
                // Add the correct number of coumns to the grid
                for (int x = 0; x < columns; x++)
                {
                    grid.ColumnDefinitions.Add(new ColumnDefinition()
                    {
                        Width = new
                   GridLength(1, GridUnitType.Star),
                    });
                }
                for (int y = 0; y < rows; y++)
                {
                    // GridUnitType.Star - The value is expressed as a weighted proportion of available space
                    grid.RowDefinitions.Add(new RowDefinition()
                    {
                        Height = new
                   GridLength(1, GridUnitType.Star),
                    });
                }
         // Fill each cell of the grid with an editable TextBox containing the value from the matrix
                for (int x = 0; x < columns; x++)
                {
                    for (int y = 0; y < rows; y++)
                    {
                        double cell = (double)matrix[x, y];
                        TextBox t = new TextBox();
                        t.Text = cell.ToString();
                        t.VerticalAlignment = System.Windows.VerticalAlignment.Center;
                        t.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
                        t.SetValue(Grid.RowProperty, y);
                        t.SetValue(Grid.ColumnProperty, x);
                        grid.Children.Add(t);
                    }
                }
            }
        }
        public static double[,] MatrixMultiplicationMethod(double[,] matrix1, double[,] matrix2)
        {
            //try
            {
                if (!(matrix1.GetLength(0) == matrix2.GetLength(1)))
                    throw new ArgumentException("Кол-во коллонок в 1 матрице не совподает с количеством строк в матрице 2");
                 
                double [,] result = new double[matrix2.GetLength(0), matrix1.GetLength(1)];
                for (int row = 0; row < matrix1.GetLength(1); row++)
                {
                    for (int column = 0; column < matrix2.GetLength(0); column++)
                    {
                        double accumulator = 0;
                        for (int cell = 0; cell < matrix1.GetLength(0); cell++)
                        {
                            //try
                            {
                                if (matrix1[cell, row] < 0)
                                    throw new ArgumentException($"Неверно введены значения в Матрице 1 в координатах [{cell},{row}]");
                                if (matrix2[column, cell] < 0)
                                    throw new ArgumentException($"Неверно введены значения в Матрице 2 в координатах [{column},{cell}]");
                                accumulator += matrix1[cell, row] * matrix2[column, cell];
                            }
                            //catch (ArgumentException exc)
                            //{
                            //    MessageBox.Show(exc.ToString());
                            //}
                        }
                        result[column, row] = accumulator;
                    }
                }
                return result;
            }
            //catch (ArgumentException exc)
            //{
            //    MessageBox.Show(exc.ToString());
            //}
            return null;
        }
        private void matrix1ColumnsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int matrix1_rows = matrix1.GetLength(1),
                matrix2_columns = matrix2.GetLength(0);
            matrix1 = new double[matrix1ColumnsComboBox.SelectedIndex+1,matrix1_rows];
            matrix2 = new double[matrix2_columns,matrix1ColumnsComboBox.SelectedIndex+1];
            var rnd = new Random();
            for (int i = 0; i < matrix1_rows; i++)
            {
                for (int j = 0; j < matrix1ColumnsComboBox.SelectedIndex + 1; j++)
                {
                    matrix1[j, i]= Math.Round(rnd.NextDouble() * 10, 2);
                }
            }
            for (int i = 0; i < matrix1ColumnsComboBox.SelectedIndex + 1; i++)
            {
                for (int j = 0; j < matrix2_columns; j++)
                {
                    matrix2[j, i] = Math.Round(rnd.NextDouble() * 10, 2);
                }
            }
            initializeGrid(matrix1Grid, matrix1);
            initializeGrid(matrix2Grid, matrix2);
        }

        private void matrix1RowsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int matrix1_columns = matrix1.GetLength(0);
            matrix1 = new double[matrix1_columns, matrix1RowsComboBox.SelectedIndex + 1];
            var rnd = new Random();
            for (int i = 0; i < matrix1RowsComboBox.SelectedIndex + 1; i++)
            {
                for (int j = 0; j < matrix1_columns; j++)
                {
                    matrix1[j, i] = Math.Round(rnd.NextDouble() * 10, 2);
                }
            }
            initializeGrid(matrix1Grid, matrix1);
        }

        private void matrix2ColumnsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int matrix2_rows = matrix2.GetLength(1);
            matrix2 = new double[matrix2ColumnsComboBox.SelectedIndex + 1, matrix2_rows];
            var rnd = new Random();
            for (int i = 0; i < matrix2_rows; i++)
            {
                for (int j = 0; j < matrix2ColumnsComboBox.SelectedIndex + 1; j++)
                {
                    matrix2[j, i] = Math.Round(rnd.NextDouble() * 10,2 );
                }
            }
            initializeGrid(matrix2Grid, matrix2);
        }

        private void buttonCalculate_Click(object sender, RoutedEventArgs e)
        {
            getValuesFromGrid(matrix1Grid, matrix1);
            getValuesFromGrid(matrix2Grid, matrix2);
            result = MatrixMultiplicationMethod(matrix1, matrix2);
            initializeGrid(resultGrid, result);
        }
        //TODO - lab 4 task 4 and continues
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
