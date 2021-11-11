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
    /// <summary>
    /// Enumeration of girder material types
    /// </summary>
    public enum Material
    {
        StainlessSteel,
        Aluminium,
        ReinforcedConcrete,
        Composite,
        Titanium
    }
    /// <summary>
    /// Enumeration of girder cross-sections
    /// </summary>
    public enum CrossSection
    {
        IBeam,
        Box,
        ZShaped,
        CShaped
    }
    /// <summary>
    /// Enumeration of test results
    /// </summary>
    public enum TestResult
    {
        Pass,
        Fail
    }
}
namespace Enumeration
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void selectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try {
                StressTest.Material selectedMaterial = (StressTest.Material) materialComboBox.SelectedIndex;
                StressTest.CrossSection selectedCrossSection = (StressTest.CrossSection)crossSectionComboBox.SelectedIndex;
                StressTest.TestResult selectedTestResult = (StressTest.TestResult)testResultComboBox.SelectedIndex;
                StringBuilder selectionStrinngBuilder=new StringBuilder("");
                switch (selectedMaterial)
                {
                    case StressTest.Material.Aluminium:
                        selectionStrinngBuilder.Append("Material: Aluminium,\t");
                        break;
                    case StressTest.Material.StainlessSteel:
                        selectionStrinngBuilder.Append("Material: Stainless Steel,\t");
                        break;
                    case StressTest.Material.ReinforcedConcrete:
                        selectionStrinngBuilder.Append("Material: Reinforced Concrete,\t");
                        break;
                    case StressTest.Material.Composite:
                        selectionStrinngBuilder.Append("Material: Composite,\t");
                        break;
                    case StressTest.Material.Titanium:
                        selectionStrinngBuilder.Append("Material: Titanium,\t");
                        break;
                    default:
                        throw new Exception ("Exception in selected material");
                        break;
                }
                switch (selectedCrossSection)
                {
                    case StressTest.CrossSection.IBeam:
                        selectionStrinngBuilder.Append("Cross - section: I-Beam \t");
                        break;
                    case StressTest.CrossSection.Box:
                        selectionStrinngBuilder.Append("Cross - section: Box \t");
                        break;
                    case StressTest.CrossSection.ZShaped:
                        selectionStrinngBuilder.Append("Cross - section: d Z-Shaped \t");
                        break;
                    case StressTest.CrossSection.CShaped:
                        selectionStrinngBuilder.Append("Cross - section: d C-Shaped \t");
                        break;
                    default:
                        throw new Exception("Exception in selected Cross section");
                        break;
                }
                switch (selectedTestResult)
                {
                    case StressTest.TestResult.Fail:
                        selectionStrinngBuilder.Append("Result: Fail \t");
                        break;
                    case StressTest.TestResult.Pass:
                        selectionStrinngBuilder.Append("Result: Pass \t");
                        break;
                    default:
                        throw new Exception("Exception in selected Result");
                        break;
                }
                logsTextBox.Text = selectionStrinngBuilder.ToString();
            } 
            catch (Exception exc) { }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        
    }
}
