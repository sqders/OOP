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
namespace StressTest
{
    // Enumerations Exercise 1
    /// <summary>
    /// Enumeration of girder material types
    /// </summary>
    public enum Material { StainlessSteel, Aluminium, ReinforcedConcrete, Composite, Titanium }
     /// <summary>
     /// Enumeration of girder cross-sections
     /// </summary>
     public enum CrossSection { IBeam, Box, ZShaped, CShaped }
    /// <summary>
    /// Enumeration of test results
    /// </summary>
    public enum TestResult { Pass, Fail }
    // Structures Exercise 2
    /// <summary>
    /// Structure containing test results
    /// </summary>
    public struct TestCaseResult
    {
        /// <summary>
        /// Test result (enumeration type)
        /// </summary>
        public TestResult Result;
        /// <summary>
        /// Description of reason for failure
        /// </summary>
        public string ReasonForFailure;
    }
}

namespace TestCaseResult
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public StressTest.TestCaseResult GenerateResult() 
        {
            System.Threading.Thread.Sleep(20);
            var rnd = new Random();
            string[] failReasonList = {"Непонимание значения слова",
                                        "Лексическая сочетаемость",
                                        "Употребление синонимов",
                                        "Употребление омонимов",
                                        "Употребление многозначных слов",
                                        "Многословие",
                                        "Лексическая неполнота высказывания",
                                        "Новые слова",
                                        "Устаревшие слова",
                                        "Слова иноязычного происхождения",
                                        "Диалектизмы",
                                        "Разговорные и просторечные слова",
                                        "Профессиональные жаргонизмы",
                                        "Фразеологизмы",
                                        "Клише и штампы "};
            StressTest.TestCaseResult result = new StressTest.TestCaseResult();
            result.Result = (StressTest.TestResult)rnd.Next(2);
            result.ReasonForFailure = failReasonList[rnd.Next(failReasonList.Length)];
            return result;
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        int failCount = 0, passCount = 0;
        private void testButton_Click(object sender, RoutedEventArgs e)
        {
            failureReasonListBox.Items.Clear();
            StressTest.TestCaseResult[] results= new StressTest.TestCaseResult[10];
            for(int i = 0; i < 10; i ++)
            {
                results[i] = GenerateResult();
            }
            foreach(StressTest.TestCaseResult result in results)
            {
                if (result.Result == StressTest.TestResult.Pass)
                    passCount++;
                if(result.Result== StressTest.TestResult.Fail)
                {
                    failCount++;
                    failureReasonListBox.Items.Add(result.ReasonForFailure);
                }
            }
            failLabel.Content = $"Fail :{failCount}";
            passLabel.Content = $"Pass :{passCount}";
        }
    }
}
