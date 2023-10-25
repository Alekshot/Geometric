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

namespace Geometric
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GeometricProgression progression;
        public MainWindow()
        {
            InitializeComponent();
            progression = new GeometricProgression(1.0, 2.0);
        }

        private void btnNextTerm_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtFirstTerm.Text, out double a) && double.TryParse(txtCommonRatio.Text, out double r))
            {
                progression = new GeometricProgression(a, r);
                double nextTerm = progression.GetNextTerm();
                txtResult.Text = $"Наступний член: {nextTerm}";
            }
            else
            {
                txtResult.Text = "Введіть коректні значення для a та r.";
            }
        }

        private void btnSumOfNextTerms_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int k = Convert.ToInt32(txtK.Text);
                double sum = progression.GetSumOfNextTerms(k);
                txtResult.Text = $"Сума наступних {k} членів прогресії: {sum}";
            }
            catch (Exception ex)
            {
                txtResult.Text = "Помилка: " + ex.Message;
            }
        }

        private void txtFirstTerm_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
