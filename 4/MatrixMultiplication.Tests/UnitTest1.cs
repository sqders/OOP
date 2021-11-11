using System;
using System.Windows;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixMultiplication.Tests
{
    [TestClass]
    public class MatrixTest
    {
        [TestMethod]
        public void MatrixMultiplyTest1()
        {
            double[,] matrix1= { { 1, 3}, { 5,7 }, { 9, 11} },
                matrix2={ {1, 0, 0}, {0, 1, 0 }, {0, 0, 1 } },
                expected= { { 1, 3 }, { 5, 7 }, { 9, 11 } }, 
                actual = MainWindow.MatrixMultiplicationMethod(matrix1, matrix2) ;
            for (int i = 0; i < expected.GetLength(0); i++)
            {
                for (int j = 0; j < expected.GetLength(1); j++)
                {
                    Assert.AreEqual(expected[i,j], actual[i,j]);
                }
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MatrixMultiplyTest2()
        {
            double[,] matrix1 = { { 1, 3 }, { 5, 7 }, { 9, 11 } },
                matrix2 = { { -1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
            MainWindow.MatrixMultiplicationMethod(matrix1, matrix2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MatrixMultiplyTest3()
        {
            double[,] matrix1 = { { 1, 3 }, { 5, 7 }, { 9, 11 } },
                matrix2 = { { 1, 0, 0,0 }, { 0, 1, 0,0 }, { 0, 0, 1,0 } };
            MainWindow.MatrixMultiplicationMethod(matrix1, matrix2);
        }
    }
}
